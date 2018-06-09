using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Coursework
{
	public partial class Adding : Form
	{
		MarkList markList = new MarkList();
		/// <summary>
		/// Конструктор по умолчанию для добавления марок.
		/// </summary>

		public Adding()
		{
			InitializeComponent();
			ActiveControl = aname;
			AcceptButton = okButton;
			CancelButton = cancelButton;
			comboBox1.DataSource = CountryList();
		}

		/// <summary>
		/// Проверка формата при заполнении формы.
		/// </summary>
	
		public void Validation(string name, string price, string year, string feature, string country, string edition)
		{
			if (!Regex.IsMatch(name, @"^[a-zA-Z0-9](([a-zA-Z0-9.,-]|\s){2,32})$"))
			{
				MessageBox.Show("Неверный формат названия");
				return;
			}
			if (!Regex.IsMatch(price, @"^([0-9,]{1,10})$"))
			{
				MessageBox.Show("Неверный формат цены");
				return;
			}
			if (!Regex.IsMatch(year, @"^([0-9]{1,4})$"))
			{
				MessageBox.Show("Неверный формат года");
				return;
			}
			if (Convert.ToInt32(year) < 1840 || Convert.ToInt32(year) > 2018)
			{
				MessageBox.Show("Неверный год");
				return;
			}
			if (!Regex.IsMatch(country, @"^[a-zA-Z](([a-zA-Z\-]|\s){0,30})[a-zA-Z]$"))
			{
				MessageBox.Show("Неверный формат страны");
				return;
			}
			if (!Regex.IsMatch(edition, @"^([0-9]+)$"))
			{
				MessageBox.Show("Неверный формат тиража");
				return;
			}
			WriteFile(name, price, year, feature, country, edition);
		}

		/// <summary>
		/// Запись в файл нового элемента
		/// </summary>
		public bool WriteFile(string name, string price, string year, string feature, string country, string edition )
		{
			if (name != "" && price != "" && year != "" && feature != "" && country != "" && edition != "")
			{
				StreamWriter writer = new StreamWriter("Mark.txt", true, Encoding.ASCII);
				string adding = name + ";" + price + ";" + year + ";" + feature + ";" + country + ";" + edition;
				writer.WriteLine(adding);
				writer.Close();
				MessageBox.Show("Запись добавлена");
				DialogResult = DialogResult.OK;
				return true;
			}
			else				
				return false;
		}

		public string[] CountryList()
		{
			MarkList markList = new MarkList();
			List<string> result = new List<string>();
			List<Mark> marks = markList.markList;
			foreach (Mark m in marks)
			{
				if (result.IndexOf(m.country) == -1)
					result.Add(m.country);
			}

			return result.ToArray();
		}

		/// <summary>
		/// Кнопка "ОК" для создания новой записи.
		/// </summary>
		private void okButton_Click(object sender, EventArgs e)
		{
			Validation(aname.Text, aprice.Text, ayear.Text, afeature.Text, comboBox1.Text, aedition.Text);
		}

		/// <summary>
		/// Отмена ввода данных.
		/// </summary>
		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
		
	}
}
