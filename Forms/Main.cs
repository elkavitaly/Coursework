using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Coursework;
using System.Text.RegularExpressions;

namespace Coursework
{
	public partial class Main : Form
	{
		MarkList markList = new MarkList();
		CollectorList collectorList = new CollectorList();

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public Main()
		{
			StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
			MarkList();
			CollectorList();
		}

		/// <summary>
		/// Заполнение таблицы каталогом марок.
		/// </summary>
		public void MarkList()
		{
			TableData.Rows.Clear();
			foreach (Mark d in markList.markList)
			{
				TableData.Rows.Add(d.ToArray());
			}
		}

		/// <summary>
		/// Удаление марки из таблицы.
		/// </summary>
		public void Delete()
		{
			
			int i = TableData.CurrentCell.RowIndex;
			List<Mark> data = markList.markList;

			if (data.Count != 0)
			{
				data.RemoveAt(i);
				markList.markList = data;
				markList.WriteList();
				MarkList();
			}
			else
				MessageBox.Show("Список пуст");

		}

		/// <summary>
		/// Преобразование к типу Mark.
		/// </summary>
		public Mark ToMark(string[] line)
		{
			Mark mark = new Mark(line[0], Convert.ToDouble(line[1]), Convert.ToInt32(line[2]), line[3], line[4], Convert.ToInt32(line[5]));
			return mark;
		}

		/// <summary>
		/// Изменение данных марок.
		/// </summary>
		public void Update(int row, int col, string str)
		{
			List<Mark> data = markList.markList;

			if (col == 0 && !Regex.IsMatch(str, @"^[a-zA-Z0-9](([a-zA-Z0-9.,-]|\s){2,32})$"))
			{
				MessageBox.Show("Недопустимый формат ввода имени");
				return;
			}
			if (col == 1 && !Regex.IsMatch(str, @"^([0-9,]{1,10})$"))
			{
				MessageBox.Show("Недопустимый формат ввода стоимости");
				return;
			}
			
			if (col == 2 && !Regex.IsMatch(str, @"^([0-9]{4})$"))
			{
				MessageBox.Show("Недопустимый формат ввода года");
				return;
			}
			if (col == 2 && Convert.ToInt32(str) > 2018)
			{
				MessageBox.Show("Недопустимый формат ввода года");
				return;
			}
			if (col == 2 && Convert.ToInt32(str) < 1840)
			{
				MessageBox.Show("Недопустимый формат ввода года");
				return;
			}
			if (col == 4 && !Regex.IsMatch(str, @"^[a-zA-Z]([a-zA-Z\-]{0,30})[a-zA-Z]$"))
			{
				MessageBox.Show("Недопустимый формат ввода");
				return;
			}
			if (col == 5 && !Regex.IsMatch(str, @"^([0-9]{1,10})$"))
			{
				MessageBox.Show("Недопустимый формат ввода");
				return;
			}

			string[][] d = new string[data.Count][];
			d = markList.ToStringArray();
			d[row][col] = str;

			List<Mark> resList = new List<Mark>();

			foreach (string[] s in d)
			{
				Mark mark = ToMark(s);
				resList.Add(mark);
			}
			markList.markList = resList;
			markList.WriteList();
			MarkList();

		}

		public List<Collector> SearchInCollectors(string str)
		{
			List<Collector> colect = collectorList.collectorList;
			List<Collector> result = new List<Collector>();
			foreach (Collector col in colect) {
				if (col.marks.IndexOf(str) != -1)
					result.Add(col);
			}
			return result;
		}


		/// <summary>
		/// Кнопка добавления марки.
		/// </summary>
		private void addbutton_Click(object sender, EventArgs e)
		{
			Form add = new Adding();
			if (add.ShowDialog() == DialogResult.OK)
			{
				markList = new MarkList();
				MarkList();
			}
		}

		/// <summary>
		/// Удаление марки из списка.
		/// </summary>
		private void deleteButton_Click(object sender, EventArgs e)
		{
			try
			{
				var r = MessageBox.Show("Удалить элемент?", "", MessageBoxButtons.YesNo);
				if(r==DialogResult.Yes)
					Delete();
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("Ячейка не выбрана");
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show("Ячейка не выбрана");
			}
		}

		/// <summary>
		/// Редактирование данных ячейки.
		/// </summary>
		private void editButton_Click(object sender, EventArgs e)
		{
			try
			{
				int i = TableData.CurrentCell.RowIndex;
				int n = TableData.CurrentCell.ColumnIndex;
				string str = TableData.CurrentCell.Value.ToString();
				Update(i, n, str);
				MarkList();
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("Ячейка не выбрана");
				MarkList();
			}
			catch (IndexOutOfRangeException)
			{
				MessageBox.Show("Ячейка не выбрана");
				MarkList();
			}
			catch (OverflowException)
			{
				MessageBox.Show("Слишком большое число");
				MarkList();
			}
		}

		/// <summary>
		/// Форма для поиска марок.
		/// </summary>
		private void sButton_Click(object sender, EventArgs e)
		{
			Search s = new Search();
			s.Show();
		}

		/// <summary>
		/// Отображение подписей к ячейкам.
		/// </summary>
		private void TableData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				TableData.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = TableData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
			}
			catch (ArgumentOutOfRangeException)
			{

			}
			catch (NullReferenceException)
			{

			}
		}

		/// <summary>
		/// Заполнение каталога коллекционеров.
		/// </summary>
		public void CollectorList()
		{
			TableColData.Rows.Clear();
			foreach (Collector d in collectorList.collectorList)
			{
				TableColData.Rows.Add(d.ToArray());
			}
		}

		/// <summary>
		/// Удаление записи коллекционера.
		/// </summary>
		public void DeleteCollector()
		{

			int i = TableColData.CurrentCell.RowIndex;
			List<Collector> data = collectorList.collectorList;

			if (data.Count != 0)
			{
				data.RemoveAt(i);
				collectorList.collectorList = data;
				collectorList.WriteList();
				CollectorList();
			}
			else
				MessageBox.Show("Список пуст");

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
		/// Кнопка добавления коллекционера.
		/// </summary>
		private void addCButton_Click(object sender, EventArgs e)
		{
			AddingCol addCol = new AddingCol();
			if (addCol.ShowDialog() == DialogResult.OK)
			{
				collectorList = new CollectorList();
				CollectorList();
				
			}

		}

		/// <summary>
		/// Удаление записи коллекционера.
		/// </summary>
		private void deleteCButton_Click(object sender, EventArgs e)
		{
			try
			{
				var r = MessageBox.Show("Удалить элемент?", "", MessageBoxButtons.YesNo);
				if (r == DialogResult.Yes)
					DeleteCollector();
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("Ячейка не выбрана");
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show("Ячейка не выбрана");
			}
		}

		/// <summary>
		/// Форма для поиска в каталоге коллекционеров.
		/// </summary>
		private void searchCButton_Click(object sender, EventArgs e)
		{
			SearchCol ser = new SearchCol();
			ser.Show();
		}

		/// <summary>
		/// Отображение подписей к ячейкам.
		/// </summary>
		private void TableColData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				TableColData.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = TableColData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
			}
			catch (ArgumentOutOfRangeException)
			{

			}
			catch (NullReferenceException)
			{

			}
		}

		/// <summary>
		/// Открытие окна редактирования записи коллекционера.
		/// </summary>
		private void button1_Click(object sender, EventArgs e)
		{
			int ind = TableColData.CurrentRow.Index;
			string[] arr = new string[TableColData.ColumnCount];
			for(int i=0; i < TableColData.ColumnCount; i++)
			{
				arr[i] = TableColData[i, ind].Value.ToString();
			}

			EditCol edit = new EditCol(arr[0], arr[1], arr[2], arr[3], arr[4]);
			if (edit.ShowDialog() == DialogResult.OK)
			{
				collectorList = new CollectorList();
				List<Collector> collectors = collectorList.collectorList;
				collectors.RemoveAt(ind);
				collectorList.collectorList = collectors;
				collectorList.WriteList();
				
				CollectorList();
			}
		}

		private void searchCollectorButton_Click(object sender, EventArgs e)
		{
			int i = TableData.CurrentCell.RowIndex;
			string str = TableData[0, i].Value.ToString();
			List<Collector> list= SearchInCollectors(str);
			if (list.Count == 0)
				MessageBox.Show("Ничего не найдено");
			else
			{
				SearchCollectors search = new SearchCollectors(list);
				search.Show();
			}
		}
	}
}
