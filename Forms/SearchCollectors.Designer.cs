namespace Coursework
{
	partial class SearchCollectors
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
			this.TableSearch = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.TableSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// TableSearch
			// 
			this.TableSearch.AllowUserToAddRows = false;
			this.TableSearch.AllowUserToDeleteRows = false;
			this.TableSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.TableSearch.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.TableSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TableSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.TableSearch.GridColor = System.Drawing.Color.WhiteSmoke;
			this.TableSearch.Location = new System.Drawing.Point(12, 30);
			this.TableSearch.MaximumSize = new System.Drawing.Size(547, 201);
			this.TableSearch.MinimumSize = new System.Drawing.Size(547, 201);
			this.TableSearch.Name = "TableSearch";
			this.TableSearch.ReadOnly = true;
			this.TableSearch.Size = new System.Drawing.Size(547, 201);
			this.TableSearch.TabIndex = 8;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Имя";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Страна";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Телефон";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Почта";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Коллекция";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// SearchCollectors
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 243);
			this.Controls.Add(this.TableSearch);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(587, 282);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(587, 282);
			this.Name = "SearchCollectors";
			this.Text = "SearchCollectors";
			((System.ComponentModel.ISupportInitialize)(this.TableSearch)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataGridView TableSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}