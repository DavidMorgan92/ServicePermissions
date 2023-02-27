namespace ServicePermissions;

public partial class ConfirmDialog : Form
{
	public string NewSecurityDescriptor => newSdTextBox.Text;

	public ConfirmDialog(string currentSd, string newSd)
	{
		InitializeComponent();

		currentSdTextBox.Text = currentSd;
		newSdTextBox.Text = newSd;
	}
}
