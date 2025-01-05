namespace WindowsFormsApp1
{
	partial class AddressForm
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
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.streetTextBox = new System.Windows.Forms.TextBox();
			this.countryTextBox = new System.Windows.Forms.TextBox();
			this.regionTextBox = new System.Windows.Forms.TextBox();
			this.houseTextBox = new System.Windows.Forms.TextBox();
			this.apartmentTextBox = new System.Windows.Forms.TextBox();
			this.postalIndexTextBox = new System.Windows.Forms.TextBox();
			this.countryLabel = new System.Windows.Forms.Label();
			this.cityLabel = new System.Windows.Forms.Label();
			this.streetLabel = new System.Windows.Forms.Label();
			this.houseLabel = new System.Windows.Forms.Label();
			this.regionLabel = new System.Windows.Forms.Label();
			this.apartmentLabel = new System.Windows.Forms.Label();
			this.postalIndexLabel = new System.Windows.Forms.Label();
			this.confirmButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cityTextBox
			// 
			this.cityTextBox.Location = new System.Drawing.Point(12, 114);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(140, 20);
			this.cityTextBox.TabIndex = 3;
			// 
			// streetTextBox
			// 
			this.streetTextBox.Location = new System.Drawing.Point(12, 162);
			this.streetTextBox.Name = "streetTextBox";
			this.streetTextBox.Size = new System.Drawing.Size(140, 20);
			this.streetTextBox.TabIndex = 4;
			// 
			// countryTextBox
			// 
			this.countryTextBox.Location = new System.Drawing.Point(12, 25);
			this.countryTextBox.Name = "countryTextBox";
			this.countryTextBox.Size = new System.Drawing.Size(140, 20);
			this.countryTextBox.TabIndex = 1;
			// 
			// regionTextBox
			// 
			this.regionTextBox.Location = new System.Drawing.Point(12, 68);
			this.regionTextBox.Name = "regionTextBox";
			this.regionTextBox.Size = new System.Drawing.Size(140, 20);
			this.regionTextBox.TabIndex = 2;
			// 
			// houseTextBox
			// 
			this.houseTextBox.Location = new System.Drawing.Point(186, 25);
			this.houseTextBox.Name = "houseTextBox";
			this.houseTextBox.Size = new System.Drawing.Size(140, 20);
			this.houseTextBox.TabIndex = 5;
			// 
			// apartmentTextBox
			// 
			this.apartmentTextBox.Location = new System.Drawing.Point(186, 68);
			this.apartmentTextBox.Name = "apartmentTextBox";
			this.apartmentTextBox.Size = new System.Drawing.Size(140, 20);
			this.apartmentTextBox.TabIndex = 6;
			// 
			// postalIndexTextBox
			// 
			this.postalIndexTextBox.Location = new System.Drawing.Point(186, 115);
			this.postalIndexTextBox.Name = "postalIndexTextBox";
			this.postalIndexTextBox.Size = new System.Drawing.Size(140, 20);
			this.postalIndexTextBox.TabIndex = 7;
			// 
			// countryLabel
			// 
			this.countryLabel.AutoSize = true;
			this.countryLabel.Location = new System.Drawing.Point(12, 9);
			this.countryLabel.Name = "countryLabel";
			this.countryLabel.Size = new System.Drawing.Size(41, 13);
			this.countryLabel.TabIndex = 7;
			this.countryLabel.Text = "Країна";
			// 
			// cityLabel
			// 
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new System.Drawing.Point(12, 99);
			this.cityLabel.Name = "cityLabel";
			this.cityLabel.Size = new System.Drawing.Size(35, 13);
			this.cityLabel.TabIndex = 8;
			this.cityLabel.Text = "Місто";
			// 
			// streetLabel
			// 
			this.streetLabel.AutoSize = true;
			this.streetLabel.Location = new System.Drawing.Point(12, 146);
			this.streetLabel.Name = "streetLabel";
			this.streetLabel.Size = new System.Drawing.Size(43, 13);
			this.streetLabel.TabIndex = 9;
			this.streetLabel.Text = "Вулиця";
			// 
			// houseLabel
			// 
			this.houseLabel.AutoSize = true;
			this.houseLabel.Location = new System.Drawing.Point(183, 9);
			this.houseLabel.Name = "houseLabel";
			this.houseLabel.Size = new System.Drawing.Size(49, 13);
			this.houseLabel.TabIndex = 10;
			this.houseLabel.Text = "Будинок";
			// 
			// regionLabel
			// 
			this.regionLabel.AutoSize = true;
			this.regionLabel.Location = new System.Drawing.Point(12, 52);
			this.regionLabel.Name = "regionLabel";
			this.regionLabel.Size = new System.Drawing.Size(50, 13);
			this.regionLabel.TabIndex = 11;
			this.regionLabel.Text = "Область";
			// 
			// apartmentLabel
			// 
			this.apartmentLabel.AutoSize = true;
			this.apartmentLabel.Location = new System.Drawing.Point(183, 52);
			this.apartmentLabel.Name = "apartmentLabel";
			this.apartmentLabel.Size = new System.Drawing.Size(55, 13);
			this.apartmentLabel.TabIndex = 12;
			this.apartmentLabel.Text = "Квартира";
			// 
			// postalIndexLabel
			// 
			this.postalIndexLabel.AutoSize = true;
			this.postalIndexLabel.Location = new System.Drawing.Point(183, 99);
			this.postalIndexLabel.Name = "postalIndexLabel";
			this.postalIndexLabel.Size = new System.Drawing.Size(93, 13);
			this.postalIndexLabel.TabIndex = 13;
			this.postalIndexLabel.Text = "Поштовий індекс";
			// 
			// confirmButton
			// 
			this.confirmButton.Location = new System.Drawing.Point(186, 200);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(140, 23);
			this.confirmButton.TabIndex = 9;
			this.confirmButton.Text = "Підтвердити";
			this.confirmButton.UseVisualStyleBackColor = true;
			this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(12, 200);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(140, 23);
			this.cancelButton.TabIndex = 8;
			this.cancelButton.Text = "Скасувати";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// AddressForm
			// 
			this.AcceptButton = this.confirmButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 235);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.confirmButton);
			this.Controls.Add(this.postalIndexLabel);
			this.Controls.Add(this.apartmentLabel);
			this.Controls.Add(this.regionLabel);
			this.Controls.Add(this.houseLabel);
			this.Controls.Add(this.streetLabel);
			this.Controls.Add(this.cityLabel);
			this.Controls.Add(this.countryLabel);
			this.Controls.Add(this.postalIndexTextBox);
			this.Controls.Add(this.apartmentTextBox);
			this.Controls.Add(this.houseTextBox);
			this.Controls.Add(this.regionTextBox);
			this.Controls.Add(this.countryTextBox);
			this.Controls.Add(this.streetTextBox);
			this.Controls.Add(this.cityTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "AddressForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Адреса";
			this.Load += new System.EventHandler(this.AddressForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.TextBox streetTextBox;
		private System.Windows.Forms.TextBox countryTextBox;
		private System.Windows.Forms.TextBox regionTextBox;
		private System.Windows.Forms.TextBox houseTextBox;
		private System.Windows.Forms.TextBox apartmentTextBox;
		private System.Windows.Forms.TextBox postalIndexTextBox;
		private System.Windows.Forms.Label countryLabel;
		private System.Windows.Forms.Label cityLabel;
		private System.Windows.Forms.Label streetLabel;
		private System.Windows.Forms.Label houseLabel;
		private System.Windows.Forms.Label regionLabel;
		private System.Windows.Forms.Label apartmentLabel;
		private System.Windows.Forms.Label postalIndexLabel;
		private System.Windows.Forms.Button confirmButton;
		private System.Windows.Forms.Button cancelButton;
	}
}