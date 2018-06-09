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

namespace Coursework
{
	public partial class Search : Form
	{
		MarkList markList = new MarkList();

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public Search()
		{
			StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
			ActiveControl = searchTextBox;
			AcceptButton = searchButton;
		}

		/// <summary>
		/// Метод поиска и формирования результирующего списка.
		/// </summary>
		public void SearchM(string search)
		{
			Main main = new Main();
			List<Mark> data = markList.markList;
			List<Mark> resultList = new List<Mark>();
			Regex reg = new Regex($@"{search}", RegexOptions.IgnoreCase);
			
			SearchData.Rows.Clear();

			List<Mark> name = data.FindAll(delegate (Mark mark) { return reg.IsMatch(mark.name); });
			List<Mark> price = data.FindAll(delegate (Mark mark) { return reg.IsMatch(mark.price.ToString()); });
			List<Mark> year = data.FindAll(delegate (Mark mark) { return reg.IsMatch(mark.year.ToString()); });
			List<Mark> feature = data.FindAll(delegate (Mark mark) { return reg.IsMatch(mark.feature); });
			List<Mark> country = data.FindAll(delegate (Mark mark) { return reg.IsMatch(mark.country); });
			List<Mark> edition = data.FindAll(delegate (Mark mark) { return reg.IsMatch(mark.edition.ToString()); });


			if (name.Count != 0)
				resultList.InsertRange(resultList.Count, name);
			if (price.Count != 0)
				resultList.InsertRange(resultList.Count, price);
			if (year.Count != 0)
				resultList.InsertRange(resultList.Count, year);
			if (feature.Count != 0)
				resultList.InsertRange(resultList.Count, feature);
			if (country.Count != 0)
				resultList.InsertRange(resultList.Count, country);
			if (edition.Count != 0)
				resultList.InsertRange(resultList.Count, edition);

			List<Mark> result = new List<Mark>();
			foreach(Mark mark in resultList)
			{
				if (result.IndexOf(mark) == -1)
				{
					result.Add(mark);
				}
			}

			foreach (Mark r in result)
			{
				SearchData.Rows.Add(r.ToArray());
			}

		}

		/// <summary>
		/// Кнопка поиска.
		/// </summary>
		private void searchButton_Click(object sender, EventArgs e)
		{

			SearchM(searchTextBox.Text);
		}

		/// <summary>
		/// Поиск при изменении состояния строки поиска.
		/// </summary>
		private void searchTextBox_TextChanged(object sender, EventArgs e)
		{
			if (searchTextBox.Text != "")
			{
				SearchData.Rows.Clear();
				SearchM(searchTextBox.Text);
			}
			else
				SearchData.Rows.Clear();
		}

	}
}
