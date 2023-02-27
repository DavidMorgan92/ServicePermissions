namespace ServicePermissions;

public partial class MainForm : Form
{
	private string MachineName { get; set; }

	public MainForm()
	{
		InitializeComponent();

		machineNameTextBox.Text = SystemInformation.ComputerName;
		MachineName = machineNameTextBox.Text;
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		InitUI();
	}

	private void AddButton_Click(object sender, EventArgs e)
	{
		if (servicesListView.SelectedIndices.Count != 1 || profilesListView.SelectedIndices.Count != 1)
		{
			throw new Exception("Select a service and a user");
		}

		var selectedService = servicesListView.SelectedItems[0].Text;
		var selectedProfile = profilesListView.SelectedItems[0].Text;

		var securityDescriptor = ServiceHelper.GetSecurityDescriptor(MachineName, selectedService);
		var newSecurityDescriptor = ServiceHelper.AddProfileToSecurityDescriptor(securityDescriptor, selectedProfile);

		using var confirmDialog = new ConfirmDialog(securityDescriptor, newSecurityDescriptor);

		if (confirmDialog.ShowDialog() == DialogResult.OK)
		{
			var editedSecurityDescriptor = confirmDialog.NewSecurityDescriptor;
			var output = ServiceHelper.SetSecurityDescriptor(MachineName, selectedService, editedSecurityDescriptor);
			MessageBox.Show(output, "sc output", MessageBoxButtons.OK);
		}
	}

	private void ServicesListView_SelectedIndexChanged(object sender, EventArgs e)
	{
		DecideAddButtonEnabled();
	}

	private void UsersListView_SelectedIndexChanged(object sender, EventArgs e)
	{
		DecideAddButtonEnabled();
	}

	private void SelectMachineButton_Click(object sender, EventArgs e)
	{
		InitUI();
	}

	private void InitUI()
	{
		LoadServices();
		LoadProfiles();
		DecideAddButtonEnabled();
	}

	private void LoadServices()
	{
		var services = ServiceHelper.GetServices(MachineName);
		servicesListView.Items.Clear();
		servicesListView.Items.AddRange(services.Select(s => new ListViewItem(s)).ToArray());
	}

	private void LoadProfiles()
	{
		var profiles = RegistryHelper.GetProfiles(MachineName);
		profilesListView.Items.Clear();
		profilesListView.Items.AddRange(profiles.Select(p => new ListViewItem(new[] { p.Key, p.Value ?? string.Empty })).ToArray());
	}

	private void DecideAddButtonEnabled()
	{
		addButton.Enabled = servicesListView.SelectedIndices.Count == 1 && profilesListView.SelectedIndices.Count == 1;
	}
}
