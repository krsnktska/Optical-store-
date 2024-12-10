using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace Coursework
{
	public partial class Main : System.Windows.Forms.Form
	{
		private bool isPasswordVisible = false;

		public Main()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		OSDataBase osDataBase = new OSDataBase();

		private void loginButton_Click(object sender, System.EventArgs e)
		{
			string login = loginTextBox.Text.Trim();
			string password = passwordTextBox.Text.Trim();

			bool loginIsNullOrEmpty = string.IsNullOrEmpty(login);
			bool passwordIsNullOrEmpty = string.IsNullOrEmpty(password);
			errorLabel.Visible = false;

			if (loginIsNullOrEmpty && passwordIsNullOrEmpty)
			{
				errorLabel.Visible = true;
				errorLabel.Location = new System.Drawing.Point(181, 309);
				errorLabel.Text = "Будь-ласка, введіть номер телефону/e-mail та пароль";
				return;
			}
			else if (loginIsNullOrEmpty)
			{
				errorLabel.Visible = true;
				errorLabel.Location = new System.Drawing.Point(181, 309);
				errorLabel.Text = "Будь-ласка, введіть номер телефону/e-mail";
				return;
			}
			else if (passwordIsNullOrEmpty)
			{
				errorLabel.Visible = true;
				errorLabel.Location = new System.Drawing.Point(181, 385);
				errorLabel.Text = "Будь-ласка, введіть пароль";
				return;
			}

			try
			{
				osDataBase.openConnection();
				string query = @"
						SELECT COUNT(*) 
						FROM [User]
						WHERE (phone_number = @login OR email = @login) AND password = @password
						";

				SqlCommand cmd = new SqlCommand(query, osDataBase.getConnection());
				cmd.Parameters.AddWithValue("@login", login);
				cmd.Parameters.AddWithValue("@password", password);

				int userIsExists = (int)cmd.ExecuteScalar();

				if (userIsExists > 0)
				{
					MessageBox.Show("Вхід виконано успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (userIsExists == 0)
				{
					errorLabel.Visible = true;
					errorLabel.Location = new System.Drawing.Point(181, 385); ;
					errorLabel.Text = "Не існує користувача з таким ім'ям та паролем.";
				}

				else
				{
					errorLabel.Visible = true;
					errorLabel.Location = new System.Drawing.Point(181, 385); ;
					errorLabel.Text = "Невірний номер телефону, email або пароль.";
				}

				if (!System.Text.RegularExpressions.Regex.IsMatch(login, @"^\+380\d{9}$"))
				{
					errorLabel.Visible = true;
					errorLabel.Text = "Введіть номер телефону у форматі +380XXXXXXXXX.";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				osDataBase.closeConnection();
			}
		}

		private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Реєстрація registerForm = new Реєстрація();
			registerForm.Show();
		}

		private void visibleButton_Click(object sender, EventArgs e) //форма входу
		{
			if (isPasswordVisible)
			{
				visibleButton.Image = Resources.visibility_off_17dp_000000_FILL0_wght400_GRAD0_opsz20;
				passwordTextBox.UseSystemPasswordChar = false;
				isPasswordVisible = false;
			}
			else
			{
				visibleButton.Image = Resources.visibility_17dp_000000_FILL0_wght400_GRAD0_opsz20;
				passwordTextBox.UseSystemPasswordChar = true;
				isPasswordVisible = true;
			}
		}
	}
}
