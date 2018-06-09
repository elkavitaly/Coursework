using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Coursework
{
	public partial class EditCol : Form
	{
		MarkList markList = new MarkList();
		CollectorList collectorList = new CollectorList();

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public EditCol()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Конструктор с параметрами.
		/// </summary>
		public EditCol(string name, string country, string phone, string email, string marks)
		{
			InitializeComponent();
			ActiveControl = aCName;
			AcceptButton = okCButton;
			CancelButton = cancelCButton;
			
			aCName.Text = name;
			contr.Text = country;
			maskedTextBox1.Text = phone;
			aCMail.Text = email;
			string[] cmarks;
			cmarks = marks.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
			List<string> list = new List<string>(cmarks);
			markComboBox.DataSource = markList.ToNameList();
			markListBox.DataSource = list;
			contr.DataSource = CountryList();
		}

		/// <summary>
		/// Проверка формата заполнения формы.
		/// </summary>
		public void Validation(string name, string country, string phone, string email, string marks)
		{
			if (!Regex.IsMatch(name, @"^[a-zA-Z](([a-zA-Z-]|\s){2,32})$"))
			{
				MessageBox.Show("Неверный формат названия");
				return;
			}
			if (!Regex.IsMatch(country, @"^[a-zA-Z]([a-zA-Z\-]{0,30})[a-zA-Z]$"))
			{
				MessageBox.Show("Неверный формат страны");
				return;
			}
			string mail = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
				@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
			if (!Regex.IsMatch(email, mail))
			{
				MessageBox.Show("Неверный формат почты");
				return;
			}

			WriteFile(name, country, phone, email, marks);
		}

		/// <summary>
		/// Запись в файл измененных данных.
		/// </summary>
		public void WriteFile(string name, string country, string phone, string email, string marks)
		{
			StreamWriter writer = new StreamWriter("Collector.txt", true, Encoding.ASCII);
			string adding = name + ";" + country + ";" + phone + ";" + email + ";" + marks;
			writer.WriteLine(adding);
			writer.Close();
			MessageBox.Show("Запись обновлена");
			DialogResult = DialogResult.OK;

		}

		/// <summary>
		/// Формирование списка марок.
		/// </summary>
		public List<string> List(ListBox listBox)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < listBox.Items.Count; i++)
			{
				list.Add(listBox.Items[i].ToString());
			}
			return list;
		}

		/// <summary>
		/// Добавление новой марки в список марок.
		/// </summary>
		public List<string> ListSource(ListBox listBox, string mark, string discription)
		{
			List<string> list = List(listBox);
			string res;
			if (discription == "")
			{
				discription = "new";
			}
			if (Regex.IsMatch(discription, @"[\,\(\)\;]"))
			{
				MessageBox.Show("Неверный формат описания\nЗапрещенные символы: ';' ',' '(' ')' ");
				return list;
			}
			res = mark + " (" + discription + ")";
			list.Add(res);
			return list;
			
		}

		/// <summary>
		/// Преобразование списка марок в строку.
		/// </summary>
		public string ToString(List<string> list)
		{
			string[] arr = new string[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				arr[i] = list[i];
			}
			return String.Join(", ", arr);
		}

		/// <summary>
		/// Преобразование к типу Collector.
		/// </summary>
		public Collector ToCollector(string[] line)
		{
			Collector collector = new Collector(line[0], line[1], line[2], line[3], line[4]);
			return collector;
		}

		/// <summary>
		/// Преобразование выбранного элемента списка в название марки и ее описание.
		/// </summary>
		private string[] EditLoad(string value)
		{
			string[] result;
			string[] arr;
			result = value.Split(new string[] { " (", ")" }, StringSplitOptions.RemoveEmptyEntries);
			if (result.Length == 1)
				arr = new string[] { result[0], "" };
			else
				arr = result;
			return arr;
		}

		/// <summary>
		/// Список стран.
		/// </summary>
		public string[] CountryList()
		{
			List<string> result = new List<string>();
			//List<Collector> collectors = collectorList.collectorList;
			foreach (Collector m in collectorList.collectorList)
			{
				if (result.IndexOf(m.country) == -1)
					result.Add(m.country);
			}

			return result.ToArray();
		}

		/// <summary>
		/// Добавление марки в список марок.
		/// </summary>
		private void aButton_Click(object sender, EventArgs e)
		{
			string mark = markComboBox.Text;
			string discription = textBox1.Text;
			List<string> list = ListSource(markListBox, mark, discription);
			textBox1.Text = "";
			markListBox.DataSource = list;
			markListBox.SelectionMode = SelectionMode.One;
		}

		/// <summary>
		/// Удаление марки из списка марок.
		/// </summary>
		private void dButton_Click(object sender, EventArgs e)
		{
			try
			{
				int ind = markListBox.SelectedIndex;
				List<string> list = List(markListBox);
				list.RemoveAt(ind);
				markListBox.DataSource = list;
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show("Элемент не выбран");
			}
		}

		/// <summary>
		/// Добавление новой записи.
		/// </summary>
		private void okCButton_Click(object sender, EventArgs e)
		{
			List<string> list = List(markListBox);
			Validation(aCName.Text, contr.Text, maskedTextBox1.Text, aCMail.Text, ToString(list));
		}

		/// <summary>
		/// Отмена добавления.
		/// </summary>
		private void cancelCButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void eButton_Click(object sender, EventArgs e)
		{
			int index = markListBox.SelectedIndex;
			string value = markListBox.SelectedItem.ToString();
			string[] res = new string[2];
			res	= EditLoad(value);
			markComboBox.Text = res[0];
			textBox1.Text = res[1];
			List<string> list = List(markListBox);
			markListBox.SelectionMode = SelectionMode.None;
			list.RemoveAt(index);
			markListBox.DataSource = list;
			
		}
	}
}
