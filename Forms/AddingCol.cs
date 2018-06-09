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
	public partial class AddingCol : Form
	{
		MarkList markList = new MarkList();

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public AddingCol()
		{
			StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
			ActiveControl = aCName;
			AcceptButton = okCButton;
			CancelButton = cancelCButton;
			comboBox1.DataSource = markList.ToNameList();
			
		}

		/// <summary>
		/// Проверка правильности заполнения формы.
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
		/// Добавление новой записи в файл.
		/// </summary>
		public void WriteFile(string name, string country, string phone, string email, string marks)
		{
			StreamWriter writer = new StreamWriter("Collector.txt", true, Encoding.ASCII);
			string adding = name + ";" + country + ";" + phone + ";" + email + ";" + marks;
			writer.WriteLine(adding);
			writer.Close();
			MessageBox.Show("Запись добавлена");
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
		/// Добавление нового элемента в список.
		/// </summary>
		public List<string> ListSource(ListBox listBox, string str, string dis)
		{
			List<string> list = List(listBox);
			string res;
			if (dis == "")
			{
				dis = "new";
			}
			res = str + " (" + dis + ")";
			list.Add(res);
			return list;
		}

		/// <summary>
		/// Преобразование списка в строку.
		/// </summary>
		public string ToString(List<string> list)
		{
			string[] arr = new string[list.Count];
			for(int i=0; i < list.Count; i++)
			{
				arr[i] = list[i];
			}
			return String.Join(", ", arr);
		}

		/// <summary>
		/// Добавление элемента в список
		/// </summary>
		private void button1_Click(object sender, EventArgs e)
		{
			string str = comboBox1.Text;
			string disc = textBox1.Text;
			List<string> list = ListSource(listBox1, str, disc);
			textBox1.Text = "";
			listBox1.DataSource = list;
			
		}

		/// <summary>
		/// Отмена добавления.
		/// </summary>
		private void cancelButton_Click(object sender, EventArgs e)
		{			
			DialogResult = DialogResult.Cancel;
			Close();
		}

		/// <summary>
		/// Добавление новой записи и закрытие файла.
		/// </summary>
		private void okCButton_Click(object sender, EventArgs e)
		{
			
			List<string> list = List(listBox1);
			Validation(aCName.Text, aCCountry.Text, maskedTextBox1.Text, aCMail.Text, ToString(list));
		}

		/// <summary>
		/// Удаление элемента из списка.
		/// </summary>
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				int ind = listBox1.SelectedIndex;
				List<string> list = List(listBox1);
				list.RemoveAt(ind);
				listBox1.DataSource = list;
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show("Элемент не выбран");
			}
		}
	}
}
