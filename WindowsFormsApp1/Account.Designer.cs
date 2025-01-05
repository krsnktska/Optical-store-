namespace WindowsFormsApp1
{
	partial class Account
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
			this.surnameLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.patronymicLabel = new System.Windows.Forms.Label();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.emailLabel = new System.Windows.Forms.Label();
			this.sexLabel = new System.Windows.Forms.Label();
			this.surnameTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.patronymicTextBox = new System.Windows.Forms.TextBox();
			this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.sexComboBox = new System.Windows.Forms.ComboBox();
			this.editButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.addressesLabel = new System.Windows.Forms.Label();
			this.addressesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.addAddressButton = new System.Windows.Forms.Button();
			this.homePicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.homePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Location = new System.Drawing.Point(59, 62);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(56, 13);
			this.surnameLabel.TabIndex = 0;
			this.surnameLabel.Text = "Прізвище";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(89, 112);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(26, 13);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "Ім\'я";
			// 
			// patronymicLabel
			// 
			this.patronymicLabel.AutoSize = true;
			this.patronymicLabel.Location = new System.Drawing.Point(48, 169);
			this.patronymicLabel.Name = "patronymicLabel";
			this.patronymicLabel.Size = new System.Drawing.Size(67, 13);
			this.patronymicLabel.TabIndex = 2;
			this.patronymicLabel.Text = "По-батькові";
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Location = new System.Drawing.Point(23, 223);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(92, 13);
			this.phoneNumberLabel.TabIndex = 3;
			this.phoneNumberLabel.Text = "Номер телефону";
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(79, 282);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(35, 13);
			this.emailLabel.TabIndex = 4;
			this.emailLabel.Text = "Е-mail";
			// 
			// sexLabel
			// 
			this.sexLabel.AutoSize = true;
			this.sexLabel.Location = new System.Drawing.Point(79, 343);
			this.sexLabel.Name = "sexLabel";
			this.sexLabel.Size = new System.Drawing.Size(36, 13);
			this.sexLabel.TabIndex = 5;
			this.sexLabel.Text = "Стать";
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.Location = new System.Drawing.Point(133, 62);
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(196, 20);
			this.surnameTextBox.TabIndex = 6;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(133, 109);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(196, 20);
			this.nameTextBox.TabIndex = 7;
			// 
			// patronymicTextBox
			// 
			this.patronymicTextBox.Location = new System.Drawing.Point(133, 162);
			this.patronymicTextBox.Name = "patronymicTextBox";
			this.patronymicTextBox.Size = new System.Drawing.Size(196, 20);
			this.patronymicTextBox.TabIndex = 8;
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Location = new System.Drawing.Point(133, 223);
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(196, 20);
			this.phoneNumberTextBox.TabIndex = 9;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(133, 279);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(196, 20);
			this.emailTextBox.TabIndex = 10;
			// 
			// sexComboBox
			// 
			this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sexComboBox.FormattingEnabled = true;
			this.sexComboBox.Items.AddRange(new object[] {
            "чоловік",
            "жінка",
            "інше"});
			this.sexComboBox.Location = new System.Drawing.Point(133, 335);
			this.sexComboBox.Name = "sexComboBox";
			this.sexComboBox.Size = new System.Drawing.Size(196, 21);
			this.sexComboBox.TabIndex = 11;
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(187, 379);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(75, 23);
			this.editButton.TabIndex = 12;
			this.editButton.Text = "Редагувати";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(149, 379);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 13;
			this.saveButton.Text = "Зберегти";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Visible = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(230, 379);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 14;
			this.cancelButton.Text = "Відмінити";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Visible = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// addressesLabel
			// 
			this.addressesLabel.AutoSize = true;
			this.addressesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addressesLabel.Location = new System.Drawing.Point(492, 62);
			this.addressesLabel.Name = "addressesLabel";
			this.addressesLabel.Size = new System.Drawing.Size(84, 24);
			this.addressesLabel.TabIndex = 16;
			this.addressesLabel.Text = "Адреси";
			// 
			// addressesFlowLayoutPanel
			// 
			this.addressesFlowLayoutPanel.AutoScroll = true;
			this.addressesFlowLayoutPanel.Location = new System.Drawing.Point(364, 109);
			this.addressesFlowLayoutPanel.Name = "addressesFlowLayoutPanel";
			this.addressesFlowLayoutPanel.Size = new System.Drawing.Size(335, 247);
			this.addressesFlowLayoutPanel.TabIndex = 17;
			// 
			// addAddressButton
			// 
			this.addAddressButton.Location = new System.Drawing.Point(485, 379);
			this.addAddressButton.Name = "addAddressButton";
			this.addAddressButton.Size = new System.Drawing.Size(103, 23);
			this.addAddressButton.TabIndex = 18;
			this.addAddressButton.Text = "Додати адресу";
			this.addAddressButton.UseVisualStyleBackColor = true;
			this.addAddressButton.Click += new System.EventHandler(this.addAddressButton_Click);
			// 
			// homePicture
			// 
			this.homePicture.Image = global::WindowsFormsApp1.Properties.Resources.home;
			this.homePicture.Location = new System.Drawing.Point(678, 12);
			this.homePicture.Name = "homePicture";
			this.homePicture.Size = new System.Drawing.Size(38, 41);
			this.homePicture.TabIndex = 15;
			this.homePicture.TabStop = false;
			this.homePicture.Click += new System.EventHandler(this.homePicture_Click);
			// 
			// Account
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 445);
			this.Controls.Add(this.addAddressButton);
			this.Controls.Add(this.addressesFlowLayoutPanel);
			this.Controls.Add(this.addressesLabel);
			this.Controls.Add(this.homePicture);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.sexComboBox);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.phoneNumberTextBox);
			this.Controls.Add(this.patronymicTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.surnameTextBox);
			this.Controls.Add(this.sexLabel);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.phoneNumberLabel);
			this.Controls.Add(this.patronymicLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.surnameLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Account";
			this.Text = "Акаунт";
			this.Load += new System.EventHandler(this.Account_Load);
			((System.ComponentModel.ISupportInitialize)(this.homePicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.ListBox addresseslistBox;

		#endregion

		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label patronymicLabel;
		private System.Windows.Forms.Label phoneNumberLabel;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Label sexLabel;
		private System.Windows.Forms.TextBox surnameTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox patronymicTextBox;
		private System.Windows.Forms.TextBox phoneNumberTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.ComboBox sexComboBox;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.PictureBox homePicture;
		private System.Windows.Forms.Label addressesLabel;
		private System.Windows.Forms.FlowLayoutPanel addressesFlowLayoutPanel;
		private System.Windows.Forms.Button addAddressButton;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}