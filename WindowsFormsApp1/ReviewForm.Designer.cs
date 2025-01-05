namespace WindowsFormsApp1
{
	partial class ReviewForm
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
			this.ratingSlider = new System.Windows.Forms.TrackBar();
			this.reviewTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.confirmButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ratingSlider)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Відгук";
			// 
			// ratingSlider
			// 
			this.ratingSlider.LargeChange = 1;
			this.ratingSlider.Location = new System.Drawing.Point(74, 158);
			this.ratingSlider.Margin = new System.Windows.Forms.Padding(0);
			this.ratingSlider.Maximum = 5;
			this.ratingSlider.Minimum = 1;
			this.ratingSlider.Name = "ratingSlider";
			this.ratingSlider.Size = new System.Drawing.Size(133, 45);
			this.ratingSlider.TabIndex = 2;
			this.ratingSlider.Value = 5;
			// 
			// reviewTextBox
			// 
			this.reviewTextBox.Location = new System.Drawing.Point(13, 37);
			this.reviewTextBox.Multiline = true;
			this.reviewTextBox.Name = "reviewTextBox";
			this.reviewTextBox.Size = new System.Drawing.Size(194, 115);
			this.reviewTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(14, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Оцінка:";
			// 
			// confirmButton
			// 
			this.confirmButton.Location = new System.Drawing.Point(12, 209);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(194, 23);
			this.confirmButton.TabIndex = 3;
			this.confirmButton.Text = "Залишити відгук";
			this.confirmButton.UseVisualStyleBackColor = true;
			this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
			// 
			// ReviewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(223, 247);
			this.Controls.Add(this.confirmButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.reviewTextBox);
			this.Controls.Add(this.ratingSlider);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "ReviewForm";
			this.Text = "Відгук";
			((System.ComponentModel.ISupportInitialize)(this.ratingSlider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar ratingSlider;
		private System.Windows.Forms.TextBox reviewTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button confirmButton;
	}
}