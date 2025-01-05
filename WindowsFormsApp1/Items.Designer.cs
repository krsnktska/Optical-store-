namespace WindowsFormsApp1
{
	partial class Items
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
			this.itemsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.cancelSearchButton = new System.Windows.Forms.Button();
			this.sortByLabel = new System.Windows.Forms.Label();
			this.sortTypes = new System.Windows.Forms.ComboBox();
			this.groupByQuantity = new System.Windows.Forms.GroupBox();
			this.forQuantityText = new System.Windows.Forms.TextBox();
			this.forQuantity = new System.Windows.Forms.Label();
			this.fromQuantityText = new System.Windows.Forms.TextBox();
			this.fromQuantity = new System.Windows.Forms.Label();
			this.groupByCost = new System.Windows.Forms.GroupBox();
			this.forCostText = new System.Windows.Forms.TextBox();
			this.forCost = new System.Windows.Forms.Label();
			this.fromCost = new System.Windows.Forms.Label();
			this.fromCostText = new System.Windows.Forms.TextBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.homePicture = new System.Windows.Forms.PictureBox();
			this.popularItemsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.itemsCountLabel = new System.Windows.Forms.Label();
			this.generatePdfButton = new System.Windows.Forms.Button();
			this.groupByQuantity.SuspendLayout();
			this.groupByCost.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.homePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// itemsFlowPanel
			// 
			this.itemsFlowPanel.AutoScroll = true;
			this.itemsFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemsFlowPanel.Location = new System.Drawing.Point(226, 59);
			this.itemsFlowPanel.Name = "itemsFlowPanel";
			this.itemsFlowPanel.Size = new System.Drawing.Size(959, 536);
			this.itemsFlowPanel.TabIndex = 0;
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(436, 35);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(260, 20);
			this.searchTextBox.TabIndex = 1;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(702, 33);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "Пошук";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// cancelSearchButton
			// 
			this.cancelSearchButton.Location = new System.Drawing.Point(783, 33);
			this.cancelSearchButton.Name = "cancelSearchButton";
			this.cancelSearchButton.Size = new System.Drawing.Size(75, 23);
			this.cancelSearchButton.TabIndex = 3;
			this.cancelSearchButton.Text = "Стерти";
			this.cancelSearchButton.UseVisualStyleBackColor = true;
			this.cancelSearchButton.Click += new System.EventHandler(this.cancelSearchButton_Click);
			// 
			// sortByLabel
			// 
			this.sortByLabel.AutoSize = true;
			this.sortByLabel.Location = new System.Drawing.Point(223, 43);
			this.sortByLabel.Name = "sortByLabel";
			this.sortByLabel.Size = new System.Drawing.Size(80, 13);
			this.sortByLabel.TabIndex = 4;
			this.sortByLabel.Text = "Сортувати за: ";
			// 
			// sortTypes
			// 
			this.sortTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sortTypes.FormattingEnabled = true;
			this.sortTypes.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.sortTypes.Items.AddRange(new object[] {
            "назвою (А-Я)",
            "назвою (Я-А)",
            "зростанням ціни",
            "спаданням ціни"});
			this.sortTypes.Location = new System.Drawing.Point(309, 35);
			this.sortTypes.Name = "sortTypes";
			this.sortTypes.Size = new System.Drawing.Size(121, 21);
			this.sortTypes.TabIndex = 0;
			this.sortTypes.SelectedIndexChanged += new System.EventHandler(this.sortTypes_SelectedIndexChanged);
			// 
			// groupByQuantity
			// 
			this.groupByQuantity.Controls.Add(this.forQuantityText);
			this.groupByQuantity.Controls.Add(this.forQuantity);
			this.groupByQuantity.Controls.Add(this.fromQuantityText);
			this.groupByQuantity.Controls.Add(this.fromQuantity);
			this.groupByQuantity.Location = new System.Drawing.Point(12, 59);
			this.groupByQuantity.Name = "groupByQuantity";
			this.groupByQuantity.Size = new System.Drawing.Size(200, 72);
			this.groupByQuantity.TabIndex = 5;
			this.groupByQuantity.TabStop = false;
			this.groupByQuantity.Text = "Фільтрувати за кількістю";
			// 
			// forQuantityText
			// 
			this.forQuantityText.Location = new System.Drawing.Point(110, 43);
			this.forQuantityText.Name = "forQuantityText";
			this.forQuantityText.Size = new System.Drawing.Size(54, 20);
			this.forQuantityText.TabIndex = 3;
			this.forQuantityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.forQuantityText_KeyPress);
			// 
			// forQuantity
			// 
			this.forQuantity.AutoSize = true;
			this.forQuantity.Location = new System.Drawing.Point(107, 27);
			this.forQuantity.Name = "forQuantity";
			this.forQuantity.Size = new System.Drawing.Size(22, 13);
			this.forQuantity.TabIndex = 2;
			this.forQuantity.Text = "До";
			// 
			// fromQuantityText
			// 
			this.fromQuantityText.Location = new System.Drawing.Point(12, 44);
			this.fromQuantityText.Name = "fromQuantityText";
			this.fromQuantityText.Size = new System.Drawing.Size(54, 20);
			this.fromQuantityText.TabIndex = 1;
			this.fromQuantityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fromQuantityText_KeyPress);
			// 
			// fromQuantity
			// 
			this.fromQuantity.AutoSize = true;
			this.fromQuantity.Location = new System.Drawing.Point(12, 27);
			this.fromQuantity.Name = "fromQuantity";
			this.fromQuantity.Size = new System.Drawing.Size(22, 13);
			this.fromQuantity.TabIndex = 0;
			this.fromQuantity.Text = "Від";
			// 
			// groupByCost
			// 
			this.groupByCost.Controls.Add(this.forCostText);
			this.groupByCost.Controls.Add(this.forCost);
			this.groupByCost.Controls.Add(this.fromCost);
			this.groupByCost.Controls.Add(this.fromCostText);
			this.groupByCost.Location = new System.Drawing.Point(12, 137);
			this.groupByCost.Name = "groupByCost";
			this.groupByCost.Size = new System.Drawing.Size(200, 72);
			this.groupByCost.TabIndex = 6;
			this.groupByCost.TabStop = false;
			this.groupByCost.Text = "Фільтрувати за ціною";
			// 
			// forCostText
			// 
			this.forCostText.Location = new System.Drawing.Point(110, 44);
			this.forCostText.Name = "forCostText";
			this.forCostText.Size = new System.Drawing.Size(54, 20);
			this.forCostText.TabIndex = 3;
			this.forCostText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.forQuantityText_KeyPress);
			// 
			// forCost
			// 
			this.forCost.AutoSize = true;
			this.forCost.Location = new System.Drawing.Point(107, 28);
			this.forCost.Name = "forCost";
			this.forCost.Size = new System.Drawing.Size(22, 13);
			this.forCost.TabIndex = 2;
			this.forCost.Text = "До";
			// 
			// fromCost
			// 
			this.fromCost.AutoSize = true;
			this.fromCost.Location = new System.Drawing.Point(12, 28);
			this.fromCost.Name = "fromCost";
			this.fromCost.Size = new System.Drawing.Size(22, 13);
			this.fromCost.TabIndex = 0;
			this.fromCost.Text = "Від";
			// 
			// fromCostText
			// 
			this.fromCostText.Location = new System.Drawing.Point(12, 44);
			this.fromCostText.Name = "fromCostText";
			this.fromCostText.Size = new System.Drawing.Size(54, 20);
			this.fromCostText.TabIndex = 1;
			this.fromCostText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fromCostText_KeyPress);
			// 
			// toolTip
			// 
			this.toolTip.AutomaticDelay = 100;
			// 
			// homePicture
			// 
			this.homePicture.Image = global::WindowsFormsApp1.Properties.Resources.home;
			this.homePicture.Location = new System.Drawing.Point(12, 9);
			this.homePicture.Name = "homePicture";
			this.homePicture.Size = new System.Drawing.Size(43, 44);
			this.homePicture.TabIndex = 7;
			this.homePicture.TabStop = false;
			this.homePicture.Click += new System.EventHandler(this.homePicture_Click);
			// 
			// popularItemsFlowPanel
			// 
			this.popularItemsFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.popularItemsFlowPanel.Location = new System.Drawing.Point(1191, 59);
			this.popularItemsFlowPanel.Name = "popularItemsFlowPanel";
			this.popularItemsFlowPanel.Size = new System.Drawing.Size(250, 536);
			this.popularItemsFlowPanel.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(1187, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Купують найчастіше";
			// 
			// itemsCountLabel
			// 
			this.itemsCountLabel.AutoSize = true;
			this.itemsCountLabel.Location = new System.Drawing.Point(1050, 43);
			this.itemsCountLabel.Name = "itemsCountLabel";
			this.itemsCountLabel.Size = new System.Drawing.Size(46, 13);
			this.itemsCountLabel.TabIndex = 10;
			this.itemsCountLabel.Text = "Всього ";
			// 
			// generatePdfButton
			// 
			this.generatePdfButton.Location = new System.Drawing.Point(12, 571);
			this.generatePdfButton.Name = "generatePdfButton";
			this.generatePdfButton.Size = new System.Drawing.Size(208, 23);
			this.generatePdfButton.TabIndex = 11;
			this.generatePdfButton.Text = "Отримати список товарів";
			this.generatePdfButton.UseVisualStyleBackColor = true;
			this.generatePdfButton.Click += new System.EventHandler(this.generatePdfButton_Click);
			// 
			// Items
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1452, 602);
			this.Controls.Add(this.generatePdfButton);
			this.Controls.Add(this.itemsCountLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.popularItemsFlowPanel);
			this.Controls.Add(this.homePicture);
			this.Controls.Add(this.groupByCost);
			this.Controls.Add(this.groupByQuantity);
			this.Controls.Add(this.sortTypes);
			this.Controls.Add(this.sortByLabel);
			this.Controls.Add(this.cancelSearchButton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.itemsFlowPanel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Items";
			this.Text = "Товари";
			this.Load += new System.EventHandler(this.Items_Load);
			this.groupByQuantity.ResumeLayout(false);
			this.groupByQuantity.PerformLayout();
			this.groupByCost.ResumeLayout(false);
			this.groupByCost.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.homePicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel itemsFlowPanel;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button cancelSearchButton;
		private System.Windows.Forms.Label sortByLabel;
		private System.Windows.Forms.ComboBox sortTypes;
		private System.Windows.Forms.GroupBox groupByQuantity;
		private System.Windows.Forms.GroupBox groupByCost;
		private System.Windows.Forms.TextBox forCostText;
		private System.Windows.Forms.Label forCost;
		private System.Windows.Forms.TextBox fromCostText;
		private System.Windows.Forms.Label fromCost;
		private System.Windows.Forms.Label fromQuantity;
		private System.Windows.Forms.TextBox forQuantityText;
		private System.Windows.Forms.Label forQuantity;
		private System.Windows.Forms.TextBox fromQuantityText;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.PictureBox homePicture;
		private System.Windows.Forms.FlowLayoutPanel popularItemsFlowPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label itemsCountLabel;
		private System.Windows.Forms.Button generatePdfButton;
	}
}