namespace ServicePermissions
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			servicesGroupBox = new GroupBox();
			servicesListView = new ListView();
			serviceNameColumn = new ColumnHeader();
			profilesGroupBox = new GroupBox();
			profilesListView = new ListView();
			registryKeyColumn = new ColumnHeader();
			imagePathColumn = new ColumnHeader();
			addButton = new Button();
			machineLabel = new Label();
			machineNameTextBox = new TextBox();
			selectMachineButton = new Button();
			splitContainer = new SplitContainer();
			servicesGroupBox.SuspendLayout();
			profilesGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
			splitContainer.Panel1.SuspendLayout();
			splitContainer.Panel2.SuspendLayout();
			splitContainer.SuspendLayout();
			SuspendLayout();
			// 
			// servicesGroupBox
			// 
			servicesGroupBox.Controls.Add(servicesListView);
			servicesGroupBox.Dock = DockStyle.Fill;
			servicesGroupBox.Location = new Point(0, 0);
			servicesGroupBox.Name = "servicesGroupBox";
			servicesGroupBox.Size = new Size(315, 305);
			servicesGroupBox.TabIndex = 1;
			servicesGroupBox.TabStop = false;
			servicesGroupBox.Text = "Services";
			// 
			// servicesListView
			// 
			servicesListView.Columns.AddRange(new ColumnHeader[] { serviceNameColumn });
			servicesListView.Dock = DockStyle.Fill;
			servicesListView.FullRowSelect = true;
			servicesListView.Location = new Point(3, 19);
			servicesListView.MultiSelect = false;
			servicesListView.Name = "servicesListView";
			servicesListView.Size = new Size(309, 283);
			servicesListView.TabIndex = 0;
			servicesListView.UseCompatibleStateImageBehavior = false;
			servicesListView.View = View.Details;
			servicesListView.SelectedIndexChanged += ServicesListView_SelectedIndexChanged;
			// 
			// serviceNameColumn
			// 
			serviceNameColumn.Text = "Service Name";
			serviceNameColumn.Width = 150;
			// 
			// profilesGroupBox
			// 
			profilesGroupBox.Controls.Add(profilesListView);
			profilesGroupBox.Dock = DockStyle.Fill;
			profilesGroupBox.Location = new Point(0, 0);
			profilesGroupBox.Name = "profilesGroupBox";
			profilesGroupBox.Size = new Size(316, 305);
			profilesGroupBox.TabIndex = 2;
			profilesGroupBox.TabStop = false;
			profilesGroupBox.Text = "Profiles";
			// 
			// profilesListView
			// 
			profilesListView.Columns.AddRange(new ColumnHeader[] { registryKeyColumn, imagePathColumn });
			profilesListView.Dock = DockStyle.Fill;
			profilesListView.FullRowSelect = true;
			profilesListView.Location = new Point(3, 19);
			profilesListView.MultiSelect = false;
			profilesListView.Name = "profilesListView";
			profilesListView.Size = new Size(310, 283);
			profilesListView.TabIndex = 0;
			profilesListView.UseCompatibleStateImageBehavior = false;
			profilesListView.View = View.Details;
			profilesListView.SelectedIndexChanged += UsersListView_SelectedIndexChanged;
			// 
			// registryKeyColumn
			// 
			registryKeyColumn.Text = "Registry Key";
			registryKeyColumn.Width = 150;
			// 
			// imagePathColumn
			// 
			imagePathColumn.Text = "Profile Image Path";
			imagePathColumn.Width = 150;
			// 
			// addButton
			// 
			addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			addButton.Enabled = false;
			addButton.Location = new Point(12, 346);
			addButton.Name = "addButton";
			addButton.Size = new Size(635, 35);
			addButton.TabIndex = 3;
			addButton.Text = "Add selected user to selected service permissions";
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += AddButton_Click;
			// 
			// machineLabel
			// 
			machineLabel.AutoSize = true;
			machineLabel.Location = new Point(12, 9);
			machineLabel.Name = "machineLabel";
			machineLabel.Size = new Size(53, 15);
			machineLabel.TabIndex = 5;
			machineLabel.Text = "Machine";
			// 
			// machineNameTextBox
			// 
			machineNameTextBox.Location = new Point(71, 6);
			machineNameTextBox.Name = "machineNameTextBox";
			machineNameTextBox.Size = new Size(187, 23);
			machineNameTextBox.TabIndex = 6;
			// 
			// selectMachineButton
			// 
			selectMachineButton.Location = new Point(264, 6);
			selectMachineButton.Name = "selectMachineButton";
			selectMachineButton.Size = new Size(126, 23);
			selectMachineButton.TabIndex = 7;
			selectMachineButton.Text = "Select Machine";
			selectMachineButton.UseVisualStyleBackColor = true;
			selectMachineButton.Click += SelectMachineButton_Click;
			// 
			// splitContainer
			// 
			splitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			splitContainer.Location = new Point(12, 35);
			splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			splitContainer.Panel1.Controls.Add(servicesGroupBox);
			// 
			// splitContainer.Panel2
			// 
			splitContainer.Panel2.Controls.Add(profilesGroupBox);
			splitContainer.Size = new Size(635, 305);
			splitContainer.SplitterDistance = 315;
			splitContainer.TabIndex = 8;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(659, 393);
			Controls.Add(splitContainer);
			Controls.Add(selectMachineButton);
			Controls.Add(machineNameTextBox);
			Controls.Add(machineLabel);
			Controls.Add(addButton);
			Name = "MainForm";
			Text = "Service Permissions";
			Load += MainForm_Load;
			servicesGroupBox.ResumeLayout(false);
			profilesGroupBox.ResumeLayout(false);
			splitContainer.Panel1.ResumeLayout(false);
			splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
			splitContainer.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private GroupBox servicesGroupBox;
		private GroupBox profilesGroupBox;
		private Button addButton;
		private ListView servicesListView;
		private ListView profilesListView;
		private ColumnHeader serviceNameColumn;
		private ColumnHeader registryKeyColumn;
		private ColumnHeader imagePathColumn;
		private Label machineLabel;
		private TextBox machineNameTextBox;
		private Button selectMachineButton;
		private SplitContainer splitContainer;
	}
}