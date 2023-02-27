namespace ServicePermissions;

partial class ConfirmDialog
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
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
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		currentSdLabel = new Label();
		currentSdTextBox = new TextBox();
		newSdTextBox = new TextBox();
		newSdLabel = new Label();
		cancelButton = new Button();
		confirmButton = new Button();
		SuspendLayout();
		// 
		// currentSdLabel
		// 
		currentSdLabel.AutoSize = true;
		currentSdLabel.Location = new Point(12, 9);
		currentSdLabel.Name = "currentSdLabel";
		currentSdLabel.Size = new Size(150, 15);
		currentSdLabel.TabIndex = 0;
		currentSdLabel.Text = "Current security descriptor:";
		// 
		// currentSdTextBox
		// 
		currentSdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		currentSdTextBox.BackColor = SystemColors.WindowText;
		currentSdTextBox.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
		currentSdTextBox.ForeColor = SystemColors.Window;
		currentSdTextBox.Location = new Point(12, 27);
		currentSdTextBox.Multiline = true;
		currentSdTextBox.Name = "currentSdTextBox";
		currentSdTextBox.ReadOnly = true;
		currentSdTextBox.Size = new Size(545, 156);
		currentSdTextBox.TabIndex = 4;
		// 
		// newSdTextBox
		// 
		newSdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		newSdTextBox.BackColor = SystemColors.WindowText;
		newSdTextBox.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
		newSdTextBox.ForeColor = SystemColors.Window;
		newSdTextBox.Location = new Point(12, 204);
		newSdTextBox.Multiline = true;
		newSdTextBox.Name = "newSdTextBox";
		newSdTextBox.Size = new Size(545, 156);
		newSdTextBox.TabIndex = 1;
		// 
		// newSdLabel
		// 
		newSdLabel.AutoSize = true;
		newSdLabel.Location = new Point(12, 186);
		newSdLabel.Name = "newSdLabel";
		newSdLabel.Size = new Size(134, 15);
		newSdLabel.TabIndex = 2;
		newSdLabel.Text = "New security descriptor:";
		// 
		// cancelButton
		// 
		cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		cancelButton.DialogResult = DialogResult.Cancel;
		cancelButton.Location = new Point(482, 366);
		cancelButton.Name = "cancelButton";
		cancelButton.Size = new Size(75, 23);
		cancelButton.TabIndex = 3;
		cancelButton.Text = "Cancel";
		cancelButton.UseVisualStyleBackColor = true;
		// 
		// confirmButton
		// 
		confirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		confirmButton.DialogResult = DialogResult.OK;
		confirmButton.Location = new Point(401, 366);
		confirmButton.Name = "confirmButton";
		confirmButton.Size = new Size(75, 23);
		confirmButton.TabIndex = 2;
		confirmButton.Text = "Confirm";
		confirmButton.UseVisualStyleBackColor = true;
		// 
		// ConfirmDialog
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = cancelButton;
		ClientSize = new Size(569, 397);
		ControlBox = false;
		Controls.Add(confirmButton);
		Controls.Add(cancelButton);
		Controls.Add(newSdTextBox);
		Controls.Add(newSdLabel);
		Controls.Add(currentSdTextBox);
		Controls.Add(currentSdLabel);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		Name = "ConfirmDialog";
		StartPosition = FormStartPosition.CenterParent;
		Text = "Confirm Security Descriptor Change";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label currentSdLabel;
	private TextBox currentSdTextBox;
	private TextBox newSdTextBox;
	private Label newSdLabel;
	private Button cancelButton;
	private Button confirmButton;
}
