namespace WindowsFormsApp1
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
			this.mainlabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// mainlabel
			// 
			this.mainlabel.AutoSize = true;
			this.mainlabel.Location = new System.Drawing.Point(163, 66);
			this.mainlabel.Name = "mainlabel";
			this.mainlabel.Size = new System.Drawing.Size(582, 42);
			this.mainlabel.TabIndex = 0;
			this.mainlabel.Text = "Вітаємо в онлайн-оптиці Opti+!";
			this.mainlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Main
			// 
			this.ClientSize = new System.Drawing.Size(909, 556);
			this.Controls.Add(this.mainlabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label mainlabel;
	}
}

