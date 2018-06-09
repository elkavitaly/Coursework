namespace Coursework
{
	partial class SearchCol
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCol));
			this.SearchCData = new System.Windows.Forms.DataGridView();
			this.searchCButton = new System.Windows.Forms.Button();
			this.searchCTextBox = new System.Windows.Forms.TextBox();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.SearchCData)).BeginInit();
			this.SuspendLayout();
			// 
			// SearchCData
			// 
			this.SearchCData.AllowUserToAddRows = false;
			this.SearchCData.AllowUserToDeleteRows = false;
			this.SearchCData.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.SearchCData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SearchCData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.SearchCData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SearchCData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.country,
            this.phone,
            this.email,
            this.marks});
			this.SearchCData.GridColor = System.Drawing.Color.WhiteSmoke;
			this.SearchCData.Location = new System.Drawing.Point(12, 62);
			this.SearchCData.Name = "SearchCData";
			this.SearchCData.ReadOnly = true;
			this.SearchCData.RowHeadersVisible = false;
			this.SearchCData.Size = new System.Drawing.Size(541, 200);
			this.SearchCData.TabIndex = 3;
			// 
			// searchCButton
			// 
			this.searchCButton.Location = new System.Drawing.Point(482, 25);
			this.searchCButton.Name = "searchCButton";
			this.searchCButton.Size = new System.Drawing.Size(75, 25);
			this.searchCButton.TabIndex = 2;
			this.searchCButton.Text = "Поиск";
			this.searchCButton.UseVisualStyleBackColor = true;
			this.searchCButton.Click += new System.EventHandler(this.searchCButton_Click);
			// 
			// searchCTextBox
			// 
			this.searchCTextBox.Location = new System.Drawing.Point(12, 28);
			this.searchCTextBox.Name = "searchCTextBox";
			this.searchCTextBox.Size = new System.Drawing.Size(464, 20);
			this.searchCTextBox.TabIndex = 1;
			this.searchCTextBox.TextChanged += new System.EventHandler(this.searchCTextBox_TextChanged);
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "D:\\C# Projects\\Coursework\\Info.html";
			// 
			// name
			// 
			this.name.HeaderText = "Имя";
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// country
			// 
			this.country.HeaderText = "Страна";
			this.country.Name = "country";
			this.country.ReadOnly = true;
			this.country.Width = 70;
			// 
			// phone
			// 
			this.phone.HeaderText = "Телефон";
			this.phone.Name = "phone";
			this.phone.ReadOnly = true;
			// 
			// email
			// 
			this.email.HeaderText = "Почта";
			this.email.Name = "email";
			this.email.ReadOnly = true;
			// 
			// marks
			// 
			this.marks.HeaderText = "Марки";
			this.marks.Name = "marks";
			this.marks.ReadOnly = true;
			this.marks.Width = 170;
			// 
			// SearchCol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(569, 261);
			this.Controls.Add(this.searchCTextBox);
			this.Controls.Add(this.searchCButton);
			this.Controls.Add(this.SearchCData);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(585, 300);
			this.MinimumSize = new System.Drawing.Size(585, 300);
			this.Name = "SearchCol";
			this.helpProvider1.SetShowHelp(this, true);
			this.Text = "Поиск";
			((System.ComponentModel.ISupportInitialize)(this.SearchCData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView SearchCData;
		private System.Windows.Forms.Button searchCButton;
		private System.Windows.Forms.TextBox searchCTextBox;
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn country;
		private System.Windows.Forms.DataGridViewTextBoxColumn phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn email;
		private System.Windows.Forms.DataGridViewTextBoxColumn marks;
	}
}