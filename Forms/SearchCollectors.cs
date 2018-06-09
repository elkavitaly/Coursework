using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
	public partial class SearchCollectors : Form
	{
		public SearchCollectors()
		{
			InitializeComponent();
		}
		public SearchCollectors(List<Collector> list)
		{
			InitializeComponent();
			TableSearch.Rows.Clear();
			foreach(Collector c in list)
			{
				TableSearch.Rows.Add(c.ToArray());
			}
		}

	}
}
