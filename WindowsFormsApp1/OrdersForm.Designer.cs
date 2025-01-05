namespace WindowsFormsApp1
{
	partial class OrdersForm
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
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.ordersFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.orderByComboBox = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cancelledCheckBox = new System.Windows.Forms.CheckBox();
			this.doneCheckBox = new System.Windows.Forms.CheckBox();
			this.inWorkCheckBox = new System.Windows.Forms.CheckBox();
			this.acceptedCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateToPicker = new System.Windows.Forms.DateTimePicker();
			this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
			this.statsLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(12, 13);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(220, 20);
			this.searchTextBox.TabIndex = 0;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(12, 39);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(105, 20);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "Пошук";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(127, 39);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(105, 20);
			this.clearButton.TabIndex = 2;
			this.clearButton.Text = "Очистити";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// ordersFlowLayoutPanel
			// 
			this.ordersFlowLayoutPanel.AutoScroll = true;
			this.ordersFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ordersFlowLayoutPanel.Location = new System.Drawing.Point(239, 15);
			this.ordersFlowLayoutPanel.Name = "ordersFlowLayoutPanel";
			this.ordersFlowLayoutPanel.Size = new System.Drawing.Size(385, 250);
			this.ordersFlowLayoutPanel.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Сортувати за:";
			// 
			// orderByComboBox
			// 
			this.orderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.orderByComboBox.DropDownWidth = 219;
			this.orderByComboBox.FormattingEnabled = true;
			this.orderByComboBox.Items.AddRange(new object[] {
            "За датою створення (спершу нові)",
            "За датою створення (спершу старі)",
            "За статусом"});
			this.orderByComboBox.Location = new System.Drawing.Point(13, 78);
			this.orderByComboBox.Name = "orderByComboBox";
			this.orderByComboBox.Size = new System.Drawing.Size(219, 21);
			this.orderByComboBox.TabIndex = 5;
			this.orderByComboBox.SelectedIndexChanged += new System.EventHandler(this.orderByComboBox_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cancelledCheckBox);
			this.groupBox1.Controls.Add(this.doneCheckBox);
			this.groupBox1.Controls.Add(this.inWorkCheckBox);
			this.groupBox1.Controls.Add(this.acceptedCheckBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 105);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(220, 114);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Фільтрувати за статусом";
			// 
			// cancelledCheckBox
			// 
			this.cancelledCheckBox.AutoSize = true;
			this.cancelledCheckBox.Checked = true;
			this.cancelledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cancelledCheckBox.Location = new System.Drawing.Point(10, 92);
			this.cancelledCheckBox.Name = "cancelledCheckBox";
			this.cancelledCheckBox.Size = new System.Drawing.Size(81, 17);
			this.cancelledCheckBox.TabIndex = 3;
			this.cancelledCheckBox.Text = "Скасовано";
			this.cancelledCheckBox.UseVisualStyleBackColor = true;
			this.cancelledCheckBox.CheckedChanged += new System.EventHandler(this.cancelledCheckBox_CheckedChanged);
			// 
			// doneCheckBox
			// 
			this.doneCheckBox.AutoSize = true;
			this.doneCheckBox.Checked = true;
			this.doneCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.doneCheckBox.Location = new System.Drawing.Point(10, 68);
			this.doneCheckBox.Name = "doneCheckBox";
			this.doneCheckBox.Size = new System.Drawing.Size(75, 17);
			this.doneCheckBox.TabIndex = 2;
			this.doneCheckBox.Text = "Виконано";
			this.doneCheckBox.UseVisualStyleBackColor = true;
			this.doneCheckBox.CheckedChanged += new System.EventHandler(this.doneCheckBox_CheckedChanged);
			// 
			// inWorkCheckBox
			// 
			this.inWorkCheckBox.AutoSize = true;
			this.inWorkCheckBox.Checked = true;
			this.inWorkCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.inWorkCheckBox.Location = new System.Drawing.Point(10, 44);
			this.inWorkCheckBox.Name = "inWorkCheckBox";
			this.inWorkCheckBox.Size = new System.Drawing.Size(74, 17);
			this.inWorkCheckBox.TabIndex = 1;
			this.inWorkCheckBox.Text = "В обробці";
			this.inWorkCheckBox.UseVisualStyleBackColor = true;
			this.inWorkCheckBox.CheckedChanged += new System.EventHandler(this.inWorkCheckBox_CheckedChanged);
			// 
			// acceptedCheckBox
			// 
			this.acceptedCheckBox.AutoSize = true;
			this.acceptedCheckBox.Checked = true;
			this.acceptedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.acceptedCheckBox.Location = new System.Drawing.Point(10, 20);
			this.acceptedCheckBox.Name = "acceptedCheckBox";
			this.acceptedCheckBox.Size = new System.Drawing.Size(75, 17);
			this.acceptedCheckBox.TabIndex = 0;
			this.acceptedCheckBox.Text = "Прийнято";
			this.acceptedCheckBox.UseVisualStyleBackColor = true;
			this.acceptedCheckBox.CheckedChanged += new System.EventHandler(this.acceptedCheckBox_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.dateToPicker);
			this.groupBox2.Controls.Add(this.dateFromPicker);
			this.groupBox2.Location = new System.Drawing.Point(12, 225);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(220, 82);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Фільтрувати за датою";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "До:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Від:";
			// 
			// dateToPicker
			// 
			this.dateToPicker.Location = new System.Drawing.Point(38, 52);
			this.dateToPicker.Name = "dateToPicker";
			this.dateToPicker.Size = new System.Drawing.Size(175, 20);
			this.dateToPicker.TabIndex = 9;
			this.dateToPicker.Value = new System.DateTime(2025, 1, 4, 20, 37, 12, 0);
			this.dateToPicker.ValueChanged += new System.EventHandler(this.dateToPicker_ValueChanged);
			// 
			// dateFromPicker
			// 
			this.dateFromPicker.Location = new System.Drawing.Point(38, 20);
			this.dateFromPicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dateFromPicker.Name = "dateFromPicker";
			this.dateFromPicker.Size = new System.Drawing.Size(175, 20);
			this.dateFromPicker.TabIndex = 8;
			this.dateFromPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dateFromPicker.ValueChanged += new System.EventHandler(this.dateFromPicker_ValueChanged);
			// 
			// statsLabel
			// 
			this.statsLabel.AutoSize = true;
			this.statsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.statsLabel.ForeColor = System.Drawing.Color.Gray;
			this.statsLabel.Location = new System.Drawing.Point(239, 272);
			this.statsLabel.MaximumSize = new System.Drawing.Size(385, 0);
			this.statsLabel.Name = "statsLabel";
			this.statsLabel.Size = new System.Drawing.Size(44, 16);
			this.statsLabel.TabIndex = 8;
			this.statsLabel.Text = "label2";
			// 
			// OrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 319);
			this.Controls.Add(this.statsLabel);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.orderByComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ordersFlowLayoutPanel);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.searchTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "OrdersForm";
			this.Text = "Історія замовлень";
			this.Load += new System.EventHandler(this.OrdersForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.FlowLayoutPanel ordersFlowLayoutPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox orderByComboBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dateFromPicker;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateToPicker;
		private System.Windows.Forms.CheckBox cancelledCheckBox;
		private System.Windows.Forms.CheckBox doneCheckBox;
		private System.Windows.Forms.CheckBox inWorkCheckBox;
		private System.Windows.Forms.CheckBox acceptedCheckBox;
		private System.Windows.Forms.Label statsLabel;
	}
}