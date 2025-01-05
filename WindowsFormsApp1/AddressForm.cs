using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class AddressForm : Form
	{
		public Address Address { get; set; }
		public AddressForm(Address address)
		{
			this.Address = address;

			InitializeComponent();
		}

		private void AddressForm_Load(object sender, EventArgs e)
		{
			countryTextBox.Text = this.Address.Country;
			cityTextBox.Text = this.Address.City;
			regionTextBox.Text = this.Address.Region;
			streetTextBox.Text = this.Address.Street;
			houseTextBox.Text = this.Address.House.ToString();
			apartmentTextBox.Text = this.Address.Apartment.ToString();
			postalIndexTextBox.Text = this.Address.PostalIndex.ToString();
		}

		private void confirmButton_Click(object sender, EventArgs e)
		{
			bool success;
			int result;

			this.Address.Country = countryTextBox.Text;
			this.Address.City = cityTextBox.Text;
			this.Address.Region = regionTextBox.Text;
			this.Address.Street = streetTextBox.Text;

			success = int.TryParse(houseTextBox.Text, out result);
			if (!success)
			{
				MessageBox.Show("Поле \"Будинок\" заповнено невірно!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				houseTextBox.Focus();
				return;
			}
			this.Address.House = result;

			success = int.TryParse(apartmentTextBox.Text, out result);
			if (!success)
			{
				MessageBox.Show("Поле \"Квартира\" заповнено невірно!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				apartmentTextBox.Focus();
				return;
			}
			this.Address.Apartment = result;

			this.Address.PostalIndex = postalIndexTextBox.Text;

			if (this.Address.AddressID == -1)
			{
				Address.Create();
			}
			else
			{
				Address.Update();
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
