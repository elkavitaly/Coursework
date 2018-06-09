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
	public partial class SearchCol : Form
	{
		CollectorList collectorList = new CollectorList();
		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public SearchCol()
		{
			StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
			ActiveControl = searchCTextBox;
			AcceptButton = searchCButton;
		}

		/// <summary>
		/// Поиск по каталогу коллекционеров.
		/// </summary>
		public void SearchC(string search)
		{
			List<Collector> data = collectorList.collectorList;
			List<Collector> resultList = new List<Collector>();
			Regex reg = new Regex($@"{search}", RegexOptions.IgnoreCase);

			SearchCData.Rows.Clear();

			List<Collector> name = data.FindAll(delegate (Collector collector) { return reg.IsMatch(collector.name); });
			List<Collector> country = data.FindAll(delegate (Collector collector) { return reg.IsMatch(collector.country); });
			List<Collector> phone = data.FindAll(delegate (Collector collector) { return reg.IsMatch(collector.number); });
			List<Collector> email = data.FindAll(delegate (Collector collector) { return reg.IsMatch(collector.email); });
			List<Collector> marks = data.FindAll(delegate (Collector collector) { return reg.IsMatch(collector.marks); });
			

			if (name.Count != 0)
				resultList.InsertRange(resultList.Count, name);
			if (country.Count != 0)
				resultList.InsertRange(resultList.Count, country);
			if (phone.Count != 0)
				resultList.InsertRange(resultList.Count, phone);
			if (email.Count != 0)
				resultList.InsertRange(resultList.Count, email);
			if (marks.Count != 0)
				resultList.InsertRange(resultList.Count, marks);

			List<Collector> result = new List<Collector>();
			foreach (Collector collector in resultList)
			{
				if (result.IndexOf(collector) == -1)
				{
					result.Add(collector);
				}
			}

			foreach (Collector r in result)
			{
				SearchCData.Rows.Add(r.ToArray());
			}

		}

		/// <summary>
		/// Кнопка поиска.
		/// </summary>
		private void searchCButton_Click(object sender, EventArgs e)
		{
			try
			{
				SearchC(searchCTextBox.Text);
			}
			catch (Exception) { }
		}

		/// <summary>
		/// Осуществление поиска при изменении строки поиска.
		/// </summary>
		private void searchCTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (searchCTextBox.Text != "")
				{
					SearchCData.Rows.Clear();
					SearchC(searchCTextBox.Text);
				}
				else
					SearchCData.Rows.Clear();
			}
			catch (Exception)
			{

			}
		}
	}
}
