namespace Coursework
{
	partial class Реєстрація
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Реєстрація));
			this.registrationLabel = new System.Windows.Forms.Label();
			this.registrationButton = new System.Windows.Forms.Button();
			this.surnameTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.patronymicTextBox = new System.Windows.Forms.TextBox();
			this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.patronymicLabel = new System.Windows.Forms.Label();
			this.emailLabel = new System.Windows.Forms.Label();
			this.phone_numberLabel = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.passwordConfirmTextBox = new System.Windows.Forms.TextBox();
			this.sexComboBox = new System.Windows.Forms.ComboBox();
			this.sexLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordConfirmLabel = new System.Windows.Forms.Label();
			this.mismatchedLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// registrationLabel
			// 
			this.registrationLabel.AutoSize = true;
			this.registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.registrationLabel.Location = new System.Drawing.Point(140, 40);
			this.registrationLabel.Name = "registrationLabel";
			this.registrationLabel.Size = new System.Drawing.Size(212, 40);
			this.registrationLabel.TabIndex = 0;
			this.registrationLabel.Text = "Реєстрація";
			// 
			// registrationButton
			// 
			this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.registrationButton.Location = new System.Drawing.Point(148, 525);
			this.registrationButton.Name = "registrationButton";
			this.registrationButton.Size = new System.Drawing.Size(194, 39);
			this.registrationButton.TabIndex = 1;
			this.registrationButton.Text = "Зареструватись";
			this.registrationButton.UseVisualStyleBackColor = true;
			this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.Location = new System.Drawing.Point(147, 116);
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(194, 20);
			this.surnameTextBox.TabIndex = 2;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(147, 161);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(194, 20);
			this.nameTextBox.TabIndex = 3;
			// 
			// patronymicTextBox
			// 
			this.patronymicTextBox.Location = new System.Drawing.Point(147, 214);
			this.patronymicTextBox.Name = "patronymicTextBox";
			this.patronymicTextBox.Size = new System.Drawing.Size(194, 20);
			this.patronymicTextBox.TabIndex = 4;
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Location = new System.Drawing.Point(147, 268);
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(194, 20);
			this.phoneNumberTextBox.TabIndex = 5;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(147, 319);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(194, 20);
			this.emailTextBox.TabIndex = 6;
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameLabel.Location = new System.Drawing.Point(144, 145);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(100, 16);
			this.nameLabel.TabIndex = 7;
			this.nameLabel.Text = "Введіть ім\'я*";
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.surnameLabel.Location = new System.Drawing.Point(144, 97);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(142, 16);
			this.surnameLabel.TabIndex = 8;
			this.surnameLabel.Text = "Введіть прізвище*";
			// 
			// patronymicLabel
			// 
			this.patronymicLabel.AutoSize = true;
			this.patronymicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.patronymicLabel.Location = new System.Drawing.Point(144, 195);
			this.patronymicLabel.Name = "patronymicLabel";
			this.patronymicLabel.Size = new System.Drawing.Size(155, 16);
			this.patronymicLabel.TabIndex = 9;
			this.patronymicLabel.Text = "Введіть по-батькові";
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.emailLabel.Location = new System.Drawing.Point(144, 300);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(111, 16);
			this.emailLabel.TabIndex = 10;
			this.emailLabel.Text = "Введіть e-mail";
			// 
			// phone_numberLabel
			// 
			this.phone_numberLabel.AutoSize = true;
			this.phone_numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.phone_numberLabel.Location = new System.Drawing.Point(144, 249);
			this.phone_numberLabel.Name = "phone_numberLabel";
			this.phone_numberLabel.Size = new System.Drawing.Size(198, 16);
			this.phone_numberLabel.TabIndex = 11;
			this.phone_numberLabel.Text = "Введіть номер телефону*";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(147, 428);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(194, 20);
			this.passwordTextBox.TabIndex = 12;
			// 
			// passwordConfirmTextBox
			// 
			this.passwordConfirmTextBox.Location = new System.Drawing.Point(147, 481);
			this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
			this.passwordConfirmTextBox.Size = new System.Drawing.Size(194, 20);
			this.passwordConfirmTextBox.TabIndex = 13;
			this.passwordConfirmTextBox.TextChanged += new System.EventHandler(this.passwordConfirmTextBox_TextChanged);
			// 
			// sexComboBox
			// 
			this.sexComboBox.FormattingEnabled = true;
			this.sexComboBox.Items.AddRange(new object[] {
            "чоловік",
            "жінка",
            "не бажаю вказувати стать "});
			this.sexComboBox.Location = new System.Drawing.Point(147, 370);
			this.sexComboBox.Name = "sexComboBox";
			this.sexComboBox.Size = new System.Drawing.Size(195, 21);
			this.sexComboBox.TabIndex = 14;
			// 
			// sexLabel
			// 
			this.sexLabel.AutoSize = true;
			this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sexLabel.Location = new System.Drawing.Point(144, 351);
			this.sexLabel.Name = "sexLabel";
			this.sexLabel.Size = new System.Drawing.Size(109, 16);
			this.sexLabel.TabIndex = 15;
			this.sexLabel.Text = "Вкажіть стать";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordLabel.Location = new System.Drawing.Point(145, 403);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(156, 16);
			this.passwordLabel.TabIndex = 16;
			this.passwordLabel.Text = "Придумайте пароль";
			// 
			// passwordConfirmLabel
			// 
			this.passwordConfirmLabel.AutoSize = true;
			this.passwordConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordConfirmLabel.Location = new System.Drawing.Point(145, 462);
			this.passwordConfirmLabel.Name = "passwordConfirmLabel";
			this.passwordConfirmLabel.Size = new System.Drawing.Size(139, 16);
			this.passwordConfirmLabel.TabIndex = 17;
			this.passwordConfirmLabel.Text = "Повторіть пароль";
			// 
			// mismatchedLabel
			// 
			this.mismatchedLabel.AutoSize = true;
			this.mismatchedLabel.ForeColor = System.Drawing.Color.Red;
			this.mismatchedLabel.Location = new System.Drawing.Point(147, 508);
			this.mismatchedLabel.Name = "mismatchedLabel";
			this.mismatchedLabel.Size = new System.Drawing.Size(0, 13);
			this.mismatchedLabel.TabIndex = 18;
			// 
			// Реєстрація
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 643);
			this.Controls.Add(this.mismatchedLabel);
			this.Controls.Add(this.passwordConfirmLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.sexLabel);
			this.Controls.Add(this.sexComboBox);
			this.Controls.Add(this.passwordConfirmTextBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.phone_numberLabel);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.patronymicLabel);
			this.Controls.Add(this.surnameLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.phoneNumberTextBox);
			this.Controls.Add(this.patronymicTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.surnameTextBox);
			this.Controls.Add(this.registrationButton);
			this.Controls.Add(this.registrationLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Реєстрація";
			this.Text = "RegisterForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label registrationLabel;
		private System.Windows.Forms.Button registrationButton;
		private System.Windows.Forms.TextBox surnameTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox patronymicTextBox;
		private System.Windows.Forms.TextBox phoneNumberTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.Label patronymicLabel;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Label phone_numberLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox passwordConfirmTextBox;
		private System.Windows.Forms.ComboBox sexComboBox;
		private System.Windows.Forms.Label sexLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label passwordConfirmLabel;
		private System.Windows.Forms.Label mismatchedLabel;
	}
}