namespace Coursework
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.mainLabel = new System.Windows.Forms.Label();
			this.loginTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.loginLabel = new System.Windows.Forms.Label();
			this.labelCreateAccount = new System.Windows.Forms.Label();
			this.linkCreateAccount = new System.Windows.Forms.LinkLabel();
			this.nameOrEmailLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.errorLabel = new System.Windows.Forms.Label();
			this.visibleButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mainLabel
			// 
			this.mainLabel.AutoSize = true;
			this.mainLabel.Location = new System.Drawing.Point(26, 130);
			this.mainLabel.Name = "mainLabel";
			this.mainLabel.Size = new System.Drawing.Size(582, 42);
			this.mainLabel.TabIndex = 0;
			this.mainLabel.Text = "Вітаємо в онлайн-оптиці Opti+!";
			this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// loginTextBox
			// 
			this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.loginTextBox.Location = new System.Drawing.Point(183, 277);
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(282, 29);
			this.loginTextBox.TabIndex = 1;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordTextBox.Location = new System.Drawing.Point(183, 352);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(282, 29);
			this.passwordTextBox.TabIndex = 2;
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Location = new System.Drawing.Point(257, 200);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(135, 42);
			this.loginLabel.TabIndex = 3;
			this.loginLabel.Text = "Увійти";
			// 
			// labelCreateAccount
			// 
			this.labelCreateAccount.AutoSize = true;
			this.labelCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCreateAccount.Location = new System.Drawing.Point(164, 479);
			this.labelCreateAccount.Name = "labelCreateAccount";
			this.labelCreateAccount.Size = new System.Drawing.Size(195, 20);
			this.labelCreateAccount.TabIndex = 4;
			this.labelCreateAccount.Text = "Ще не маєте акаунту?";
			// 
			// linkCreateAccount
			// 
			this.linkCreateAccount.AutoSize = true;
			this.linkCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.linkCreateAccount.Location = new System.Drawing.Point(355, 479);
			this.linkCreateAccount.Name = "linkCreateAccount";
			this.linkCreateAccount.Size = new System.Drawing.Size(157, 20);
			this.linkCreateAccount.TabIndex = 5;
			this.linkCreateAccount.TabStop = true;
			this.linkCreateAccount.Text = "Зареєструватись";
			this.linkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateAccount_LinkClicked);
			// 
			// nameOrEmailLabel
			// 
			this.nameOrEmailLabel.AutoSize = true;
			this.nameOrEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameOrEmailLabel.Location = new System.Drawing.Point(181, 258);
			this.nameOrEmailLabel.Name = "nameOrEmailLabel";
			this.nameOrEmailLabel.Size = new System.Drawing.Size(211, 16);
			this.nameOrEmailLabel.TabIndex = 7;
			this.nameOrEmailLabel.Text = "Номер телефону або e-mail";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordLabel.Location = new System.Drawing.Point(181, 333);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(62, 16);
			this.passwordLabel.TabIndex = 8;
			this.passwordLabel.Text = "Пароль";
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.errorLabel.ForeColor = System.Drawing.Color.Red;
			this.errorLabel.Location = new System.Drawing.Point(181, 309);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(0, 13);
			this.errorLabel.TabIndex = 9;
			// 
			// visibleButton
			// 
			this.visibleButton.Image = global::WindowsFormsApp1.Properties.Resources.visibility_17dp_000000_FILL0_wght400_GRAD0_opsz20;
			this.visibleButton.Location = new System.Drawing.Point(472, 346);
			this.visibleButton.Name = "visibleButton";
			this.visibleButton.Size = new System.Drawing.Size(40, 40);
			this.visibleButton.TabIndex = 4;
			this.visibleButton.UseVisualStyleBackColor = true;
			this.visibleButton.Click += new System.EventHandler(this.visibleButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.loginButton.Location = new System.Drawing.Point(250, 417);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(142, 35);
			this.loginButton.TabIndex = 3;
			this.loginButton.Text = "Увійти";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// Main
			// 
			this.ClientSize = new System.Drawing.Size(634, 661);
			this.Controls.Add(this.visibleButton);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.nameOrEmailLabel);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.linkCreateAccount);
			this.Controls.Add(this.labelCreateAccount);
			this.Controls.Add(this.loginLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.loginTextBox);
			this.Controls.Add(this.mainLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label mainLabel;
		private System.Windows.Forms.TextBox loginTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.Label labelCreateAccount;
		private System.Windows.Forms.LinkLabel linkCreateAccount;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Label nameOrEmailLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label errorLabel;
		private System.Windows.Forms.Button visibleButton;
	}
}

