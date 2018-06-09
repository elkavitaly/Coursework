namespace Coursework
{
	partial class Main
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.TableData = new System.Windows.Forms.DataGridView();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.feature = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.marks = new System.Windows.Forms.TabPage();
			this.searchCollectorButton = new System.Windows.Forms.Button();
			this.addbutton = new System.Windows.Forms.Button();
			this.sButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.collectors = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.TableColData = new System.Windows.Forms.DataGridView();
			this.searchCButton = new System.Windows.Forms.Button();
			this.deleteCButton = new System.Windows.Forms.Button();
			this.addCButton = new System.Windows.Forms.Button();
			this.markBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.TableData)).BeginInit();
			this.tabControl2.SuspendLayout();
			this.marks.SuspendLayout();
			this.collectors.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TableColData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// TableData
			// 
			this.TableData.AllowUserToAddRows = false;
			this.TableData.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.TableData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TableData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.TableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.year,
            this.feature,
            this.country,
            this.edition});
			this.TableData.GridColor = System.Drawing.Color.WhiteSmoke;
			this.TableData.Location = new System.Drawing.Point(30, 55);
			this.TableData.MaximumSize = new System.Drawing.Size(661, 310);
			this.TableData.Name = "TableData";
			this.TableData.RowHeadersVisible = false;
			this.TableData.Size = new System.Drawing.Size(661, 310);
			this.TableData.TabIndex = 6;
			this.TableData.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableData_CellMouseEnter);
			// 
			// name
			// 
			this.name.HeaderText = "Название";
			this.name.Name = "name";
			this.name.Width = 110;
			// 
			// price
			// 
			this.price.HeaderText = "Стоимость";
			this.price.Name = "price";
			this.price.Width = 110;
			// 
			// year
			// 
			this.year.HeaderText = "Год выпуска";
			this.year.Name = "year";
			this.year.Width = 110;
			// 
			// feature
			// 
			this.feature.HeaderText = "Особенности";
			this.feature.Name = "feature";
			this.feature.Width = 110;
			// 
			// country
			// 
			this.country.HeaderText = "Страна";
			this.country.Name = "country";
			this.country.Width = 110;
			// 
			// edition
			// 
			this.edition.HeaderText = "Тираж";
			this.edition.Name = "edition";
			this.edition.Width = 93;
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.marks);
			this.tabControl2.Controls.Add(this.collectors);
			this.tabControl2.Location = new System.Drawing.Point(12, 12);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.helpProvider1.SetShowHelp(this.tabControl2, true);
			this.tabControl2.Size = new System.Drawing.Size(716, 402);
			this.tabControl2.TabIndex = 2;
			// 
			// marks
			// 
			this.marks.BackColor = System.Drawing.Color.White;
			this.marks.Controls.Add(this.searchCollectorButton);
			this.marks.Controls.Add(this.addbutton);
			this.marks.Controls.Add(this.TableData);
			this.marks.Controls.Add(this.sButton);
			this.marks.Controls.Add(this.deleteButton);
			this.marks.Controls.Add(this.editButton);
			this.helpProvider1.SetHelpString(this.marks, "Марки");
			this.marks.Location = new System.Drawing.Point(4, 22);
			this.marks.Name = "marks";
			this.marks.Padding = new System.Windows.Forms.Padding(3);
			this.helpProvider1.SetShowHelp(this.marks, true);
			this.marks.Size = new System.Drawing.Size(708, 376);
			this.marks.TabIndex = 1;
			this.marks.Text = "Марки";
			// 
			// searchCollectorButton
			// 
			this.searchCollectorButton.Location = new System.Drawing.Point(292, 19);
			this.searchCollectorButton.Name = "searchCollectorButton";
			this.searchCollectorButton.Size = new System.Drawing.Size(137, 25);
			this.searchCollectorButton.TabIndex = 3;
			this.searchCollectorButton.Text = "Поиск у коллекционера";
			this.searchCollectorButton.UseVisualStyleBackColor = true;
			this.searchCollectorButton.Click += new System.EventHandler(this.searchCollectorButton_Click);
			// 
			// addbutton
			// 
			this.helpProvider1.SetHelpString(this.addbutton, "Добавить");
			this.addbutton.Location = new System.Drawing.Point(30, 19);
			this.addbutton.Name = "addbutton";
			this.helpProvider1.SetShowHelp(this.addbutton, true);
			this.addbutton.Size = new System.Drawing.Size(95, 25);
			this.addbutton.TabIndex = 1;
			this.addbutton.Text = "Добавить";
			this.addbutton.UseVisualStyleBackColor = true;
			this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
			// 
			// sButton
			// 
			this.sButton.Location = new System.Drawing.Point(596, 19);
			this.sButton.Name = "sButton";
			this.sButton.Size = new System.Drawing.Size(95, 25);
			this.sButton.TabIndex = 5;
			this.sButton.Text = "Поиск";
			this.sButton.UseVisualStyleBackColor = true;
			this.sButton.Click += new System.EventHandler(this.sButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(462, 19);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(95, 25);
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "Удалить";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(161, 19);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(95, 25);
			this.editButton.TabIndex = 2;
			this.editButton.Text = "Редактировать";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// collectors
			// 
			this.collectors.BackColor = System.Drawing.Color.White;
			this.collectors.Controls.Add(this.button1);
			this.collectors.Controls.Add(this.TableColData);
			this.collectors.Controls.Add(this.searchCButton);
			this.collectors.Controls.Add(this.deleteCButton);
			this.collectors.Controls.Add(this.addCButton);
			this.collectors.Location = new System.Drawing.Point(4, 22);
			this.collectors.Name = "collectors";
			this.collectors.Padding = new System.Windows.Forms.Padding(3);
			this.collectors.Size = new System.Drawing.Size(708, 376);
			this.collectors.TabIndex = 0;
			this.collectors.Text = "Коллекционеры";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(231, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 25);
			this.button1.TabIndex = 2;
			this.button1.Text = "Редактировать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TableColData
			// 
			this.TableColData.AllowUserToOrderColumns = true;
			this.TableColData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.TableColData.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.TableColData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TableColData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.TableColData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableColData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.TableColData.GridColor = System.Drawing.Color.WhiteSmoke;
			this.TableColData.Location = new System.Drawing.Point(80, 55);
			this.TableColData.Name = "TableColData";
			this.TableColData.ReadOnly = true;
			this.TableColData.RowHeadersVisible = false;
			this.TableColData.Size = new System.Drawing.Size(545, 310);
			this.TableColData.TabIndex = 7;
			this.TableColData.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableColData_CellMouseEnter);
			// 
			// searchCButton
			// 
			this.searchCButton.Location = new System.Drawing.Point(527, 19);
			this.searchCButton.Name = "searchCButton";
			this.searchCButton.Size = new System.Drawing.Size(95, 25);
			this.searchCButton.TabIndex = 4;
			this.searchCButton.Text = "Поиск";
			this.searchCButton.UseVisualStyleBackColor = true;
			this.searchCButton.Click += new System.EventHandler(this.searchCButton_Click);
			// 
			// deleteCButton
			// 
			this.deleteCButton.Location = new System.Drawing.Point(379, 19);
			this.deleteCButton.Name = "deleteCButton";
			this.deleteCButton.Size = new System.Drawing.Size(95, 25);
			this.deleteCButton.TabIndex = 3;
			this.deleteCButton.Text = "Удалить";
			this.deleteCButton.UseVisualStyleBackColor = true;
			this.deleteCButton.Click += new System.EventHandler(this.deleteCButton_Click);
			// 
			// addCButton
			// 
			this.addCButton.Location = new System.Drawing.Point(83, 19);
			this.addCButton.Name = "addCButton";
			this.addCButton.Size = new System.Drawing.Size(95, 25);
			this.addCButton.TabIndex = 1;
			this.addCButton.Text = "Добавить";
			this.addCButton.UseVisualStyleBackColor = true;
			this.addCButton.Click += new System.EventHandler(this.addCButton_Click);
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "D:\\C# Projects\\Coursework\\Info.html";
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Имя";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 109;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Страна";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 80;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Телефон";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 109;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Почта";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 109;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Коллекция";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 137;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(740, 423);
			this.Controls.Add(this.tabControl2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(756, 462);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(756, 462);
			this.Name = "Main";
			this.helpProvider1.SetShowHelp(this, true);
			this.Text = "Дневник филателиста";
			((System.ComponentModel.ISupportInitialize)(this.TableData)).EndInit();
			this.tabControl2.ResumeLayout(false);
			this.marks.ResumeLayout(false);
			this.collectors.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TableColData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource markBindingSource;
		protected System.Windows.Forms.DataGridView TableData;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage collectors;
		private System.Windows.Forms.TabPage marks;
		private System.Windows.Forms.Button addbutton;
		private System.Windows.Forms.Button sButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button searchCButton;
		private System.Windows.Forms.Button deleteCButton;
		private System.Windows.Forms.Button addCButton;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.HelpProvider helpProvider1;
		public System.Windows.Forms.DataGridView TableColData;
		private System.Windows.Forms.Button searchCollectorButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.DataGridViewTextBoxColumn year;
		private System.Windows.Forms.DataGridViewTextBoxColumn feature;
		private System.Windows.Forms.DataGridViewTextBoxColumn country;
		private System.Windows.Forms.DataGridViewTextBoxColumn edition;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}

