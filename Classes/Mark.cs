using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
	public class Mark
	{
		public string name;
		public double price;
		public int year;
		public string feature;
		public string country;
		public int edition;

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public Mark()
		{
			this.name = "DefaultMark";
			this.price = 0;
			this.year = 1840;
			this.feature = "None";
			this.country = "ua";
			this.edition = 100;
		}

		/// <summary>
		/// Конструктор с параметрами.
		/// </summary>
		public Mark(string name, double price, int year, string feature, string country, int edition)
		{
			this.name = name;
			this.price = price;
			this.year = year;
			this.feature = feature;
			this.country = country;
			this.edition = edition;
		}

		/// <summary>
		/// Конструктор по названию.
		/// </summary>
		public Mark(string name)
		{
			this.name = name;
			this.price = 0;
			this.year = 1840;
			this.feature = "None";
			this.country = "ua";
			this.edition = 1;
		}

		/// <summary>
		/// Преобразование в массив строк.
		/// </summary>
		public string[] ToArray()
		{
			string[] marks = new string[6];
			marks[0] = this.name;
			marks[1] = this.price.ToString();
			marks[2] = this.year.ToString();
			marks[3] = this.feature;
			marks[4] =this.country;
			marks[5] = this.edition.ToString();
			return marks;
		}

		/// <summary>
		/// Преобразование в строку.
		/// </summary>
		public override string ToString()
		{
			string result = name + ";" + Convert.ToString(price) + ";" + Convert.ToString(year) + ";" + feature + ";" + country + ";" + Convert.ToString(edition);
			return result;
		}

		/// <summary>
		/// Преобразование из массива в тип Mark.
		/// </summary>
		public Mark ToMark(string[] line)
		{
			Mark mark = new Mark(line[0], Convert.ToDouble(line[1]), Convert.ToInt32(line[2]), line[3], line[4], Convert.ToInt32(line[5]));
			return mark;
		}

	}
}
