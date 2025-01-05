namespace WindowsFormsApp1
{
	partial class CreateOrderForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.addressesComboBox = new System.Windows.Forms.ComboBox();
			this.commentTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.confirmOrderButton = new System.Windows.Forms.Button();
			this.addAddressButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Створення замовлення";
			// 
			// addressesComboBox
			// 
			this.addressesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.addressesComboBox.FormattingEnabled = true;
			this.addressesComboBox.Location = new System.Drawing.Point(17, 57);
			this.addressesComboBox.Name = "addressesComboBox";
			this.addressesComboBox.Size = new System.Drawing.Size(209, 21);
			this.addressesComboBox.TabIndex = 1;
			// 
			// commentTextBox
			// 
			this.commentTextBox.Location = new System.Drawing.Point(17, 99);
			this.commentTextBox.Multiline = true;
			this.commentTextBox.Name = "commentTextBox";
			this.commentTextBox.Size = new System.Drawing.Size(238, 96);
			this.commentTextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Адреса";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Коментар";
			// 
			// confirmOrderButton
			// 
			this.confirmOrderButton.Location = new System.Drawing.Point(17, 205);
			this.confirmOrderButton.Name = "confirmOrderButton";
			this.confirmOrderButton.Size = new System.Drawing.Size(238, 23);
			this.confirmOrderButton.TabIndex = 5;
			this.confirmOrderButton.Text = "Підтвердити замовлення";
			this.confirmOrderButton.UseVisualStyleBackColor = true;
			this.confirmOrderButton.Click += new System.EventHandler(this.confirmOrderButton_Click);
			// 
			// addAddressButton
			// 
			this.addAddressButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.add;
			this.addAddressButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.addAddressButton.Location = new System.Drawing.Point(232, 57);
			this.addAddressButton.Name = "addAddressButton";
			this.addAddressButton.Size = new System.Drawing.Size(23, 23);
			this.addAddressButton.TabIndex = 6;
			this.addAddressButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.addAddressButton.UseVisualStyleBackColor = true;
			this.addAddressButton.Click += new System.EventHandler(this.addAddressButton_Click);
			// 
			// CreateOrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 240);
			this.Controls.Add(this.addAddressButton);
			this.Controls.Add(this.confirmOrderButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.commentTextBox);
			this.Controls.Add(this.addressesComboBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "CreateOrderForm";
			this.Text = "Замовлення";
			this.Load += new System.EventHandler(this.CreateOrderForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox addressesComboBox;
		private System.Windows.Forms.TextBox commentTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button confirmOrderButton;
		private System.Windows.Forms.Button addAddressButton;
	}
}