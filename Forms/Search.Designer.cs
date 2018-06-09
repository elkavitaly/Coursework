namespace Coursework
{
	partial class Search
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
			this.SearchData = new System.Windows.Forms.DataGridView();
			this.searchButton = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.feature = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.SearchData)).BeginInit();
			this.SuspendLayout();
			// 
			// SearchData
			// 
			this.SearchData.AllowUserToAddRows = false;
			this.SearchData.AllowUserToDeleteRows = false;
			this.SearchData.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.SearchData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SearchData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.SearchData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SearchData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.year,
            this.feature,
            this.country,
            this.edition});
			this.SearchData.GridColor = System.Drawing.Color.WhiteSmoke;
			this.SearchData.Location = new System.Drawing.Point(12, 82);
			this.SearchData.Name = "SearchData";
			this.SearchData.ReadOnly = true;
			this.SearchData.RowHeadersVisible = false;
			this.SearchData.Size = new System.Drawing.Size(641, 265);
			this.SearchData.TabIndex = 3;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(553, 22);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(101, 25);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "Поиск";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(12, 25);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(535, 20);
			this.searchTextBox.TabIndex = 1;
			this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "D:\\C# Projects\\Coursework\\Info.html";
			// 
			// name
			// 
			this.name.HeaderText = "Название";
			this.name.MinimumWidth = 50;
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// price
			// 
			this.price.HeaderText = "Стоимость";
			this.price.MinimumWidth = 50;
			this.price.Name = "price";
			this.price.ReadOnly = true;
			// 
			// year
			// 
			this.year.HeaderText = "Год выпуска";
			this.year.MinimumWidth = 50;
			this.year.Name = "year";
			this.year.ReadOnly = true;
			// 
			// feature
			// 
			this.feature.HeaderText = "Особенности";
			this.feature.MinimumWidth = 50;
			this.feature.Name = "feature";
			this.feature.ReadOnly = true;
			this.feature.Width = 140;
			// 
			// country
			// 
			this.country.HeaderText = "Страна";
			this.country.MinimumWidth = 50;
			this.country.Name = "country";
			this.country.ReadOnly = true;
			// 
			// edition
			// 
			this.edition.HeaderText = "Тираж";
			this.edition.MinimumWidth = 50;
			this.edition.Name = "edition";
			this.edition.ReadOnly = true;
			// 
			// Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(669, 365);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.SearchData);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(685, 404);
			this.MinimumSize = new System.Drawing.Size(685, 404);
			this.Name = "Search";
			this.helpProvider1.SetShowHelp(this, true);
			this.Text = "Поиск";
			((System.ComponentModel.ISupportInitialize)(this.SearchData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		protected System.Windows.Forms.DataGridView SearchData;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.DataGridViewTextBoxColumn year;
		private System.Windows.Forms.DataGridViewTextBoxColumn feature;
		private System.Windows.Forms.DataGridViewTextBoxColumn country;
		private System.Windows.Forms.DataGridViewTextBoxColumn edition;
	}
}