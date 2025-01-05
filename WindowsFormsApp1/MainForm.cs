using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.Properties;

namespace Coursework
{
	public partial class Main : System.Windows.Forms.Form
	{
		private bool isPasswordVisible = false;
		private int userId;

		public Main()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			this.Size = new Size(650, 700);
		}

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
				OSDataBase.openConnection();
				string query = @"SELECT number_of_the_client_card 
								FROM [User] 
								WHERE (phone_number = @login OR email = @login) AND password = @password";

				SqlCommand cmd = new SqlCommand(query, OSDataBase.getConnection());

				cmd.Parameters.AddWithValue("@login", login);
				cmd.Parameters.AddWithValue("@password", password);

				object result = cmd.ExecuteScalar();

				int? userIsExists = (int?)result;

				if (userIsExists != null)
				{
					userId = (int)result;
					this.Hide();
					Home Home = new Home(userId);
					Home.Show();
				}
				else
				{
					errorLabel.Visible = true;
					errorLabel.Location = new System.Drawing.Point(181, 385); ;
					errorLabel.Text = "Невірний номер телефону, email або пароль.";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				OSDataBase.closeConnection();
			}
		}

		private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Реєстрація registerForm = new Реєстрація();
			registerForm.Show();
		}

		private void visibleButton_Click(object sender, EventArgs e)
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
