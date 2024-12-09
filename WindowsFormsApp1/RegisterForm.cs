using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coursework
{
	public partial class Реєстрація : Form
	{
		public Реєстрація()
		{
			InitializeComponent();
			registrationButton.Enabled = false;

			surnameTextBox.TextChanged += textBoxChanged;
			nameTextBox.TextChanged += textBoxChanged;
			phoneNumberTextBox.TextChanged += textBoxChanged;
			passwordTextBox.TextChanged += textBoxChanged;
			passwordConfirmTextBox.TextChanged += textBoxChanged;

			surnameTextBox.Leave += textBoxLeaved;
			nameTextBox.Leave += textBoxLeaved;
			phoneNumberTextBox.Leave += textBoxLeaved;
			passwordTextBox.Leave += textBoxLeaved;
			passwordConfirmTextBox.Leave += textBoxLeaved;
		}

		OSDataBase osDataBase = new OSDataBase();

		private void registrationButton_Click(object sender, System.EventArgs e)
		{
			string surname = surnameTextBox.Text.Trim();
			string name = nameTextBox.Text.Trim();
			string patronymic = patronymicTextBox.Text.Trim();
			string phoneNumber = phoneNumberTextBox.Text.Trim();
			string email = emailTextBox.Text.Trim();
			string sex = sexComboBox.Text.Trim();
			string password = passwordTextBox.Text.Trim();

			try
			{
				osDataBase.openConnection();

				string checkQuery = @"
					SELECT COUNT(*) 
					FROM [User] 
					WHERE phone_number = @phoneNumber OR email = @email";

				SqlCommand cmdCheck = new SqlCommand(checkQuery, osDataBase.getConnection());
				int userIsExists = (int)cmdCheck.ExecuteScalar();
				cmdCheck.Parameters.AddWithValue("@phone_number", phoneNumber);
				cmdCheck.Parameters.AddWithValue("@email", email);

				if (userIsExists > 0)
				{
					mismatchedLabel.Visible = true;
					mismatchedLabel.Text = "Користувач з таким номером телефону або електронною поштою вже існує.";
					return;
				}

				string insertQuery = @"
						INSERT INTO [User] (surname, name, patronymic, phone_number, email, sex, password)
						VALUES (@surname, @name, @patronymic, @phoneNumber, @email, @sex, @password)";

				SqlCommand cmdInsert = new SqlCommand(insertQuery, osDataBase.getConnection());
				cmdInsert.Parameters.AddWithValue("@surname", surname);
				cmdInsert.Parameters.AddWithValue("@name", name);
				cmdInsert.Parameters.AddWithValue("@patronymic", patronymic);
				cmdInsert.Parameters.AddWithValue("@phone_number", phoneNumber);
				cmdInsert.Parameters.AddWithValue("@email", email);
				cmdInsert.Parameters.AddWithValue("@sex", sex);
				cmdInsert.Parameters.AddWithValue("@password", password);

				cmdInsert.ExecuteNonQuery();


			}
			catch (Exception ex)
			{
				MessageBox.Show($"Помилка реєстрації: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			finally
			{
				MessageBox.Show("Реєстрація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
				osDataBase.closeConnection();
			}
		}

		private void passwordConfirmTextBox_TextChanged(object sender, System.EventArgs e)
		{
			string password = passwordTextBox.Text.Trim();
			string passwordConfirm = passwordConfirmTextBox.Text.Trim();
			mismatchedLabel.Visible = false;

			if (string.IsNullOrEmpty(passwordConfirm) && password == passwordConfirm)
			{
				mismatchedLabel.Visible = false;
			}
			else
			{
				mismatchedLabel.Visible = true;
				mismatchedLabel.Text = "Паролі не співпадають";
			}
			Validate();
		}

		private void Validate()
		{
			bool isValid = (!string.IsNullOrEmpty(surnameTextBox.Text)
				&&
				!string.IsNullOrEmpty(nameTextBox.Text)
				&&
				!string.IsNullOrEmpty(phoneNumberTextBox.Text)
				&&
				!string.IsNullOrEmpty(passwordTextBox.Text)
				&&
				passwordTextBox.Text.Trim() == passwordConfirmTextBox.Text.Trim()
				);

			registrationButton.Enabled = isValid;
		}

		private void textBoxLeaved(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;

			if (textBox == phoneNumberTextBox || textBox == emailTextBox)
			{
				if (string.IsNullOrEmpty(phoneNumberTextBox.Text.Trim()))
				{
					mismatchedLabel.Text = "Заповніть номер телефону.";
					mismatchedLabel.Visible = true;
				}
				else if (!System.Text.RegularExpressions.Regex.IsMatch(phoneNumberTextBox.Text.Trim(), @"^\+380\d{9}$"))
				{
					mismatchedLabel.Visible = true;
					mismatchedLabel.Text = "Введіть номер телефону у форматі +380XXXXXXXXX.";
				}
				else
				{
					mismatchedLabel.Visible = false;
				}
			}
			else if (textBox == passwordTextBox || textBox == passwordConfirmTextBox)
			{

				if (passwordTextBox.Text.Trim() != passwordConfirmTextBox.Text.Trim())
				{
					mismatchedLabel.Text = "Паролі не співпадають.";
					mismatchedLabel.Visible = true;
				}

				else if (string.IsNullOrEmpty(passwordConfirmTextBox.Text.Trim()))
				{
					mismatchedLabel.Visible = true;
					mismatchedLabel.Text = "Введіть повторно пароль.";
				}
				else
				{
					mismatchedLabel.Visible = false;
				}
			}
			else if (textBox == surnameTextBox && string.IsNullOrEmpty(surnameTextBox.Text.Trim()))
			{
				mismatchedLabel.Visible = true;
				mismatchedLabel.Text = "Введіть прізвище.";
			}
			else if (textBox == nameTextBox && string.IsNullOrEmpty(nameTextBox.Text.Trim()))
			{
				mismatchedLabel.Visible = true;
				mismatchedLabel.Text = "Введіть ім'я.";
			}
			else
			{
				mismatchedLabel.Visible = false;
			}

			Validate();
		}

		private void textBoxChanged(object sender, EventArgs e)
		{
			Validate();
		}
	}
}
