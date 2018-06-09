using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
	public class Collector
	{
		public string name;
		public string country;
		public string number;
		public string email;
		public string marks;

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public Collector()
		{
			name = "Ivanov";
			country = "ukr";
			number = "+38(000)000-000-000";
			email = "ivanov@gmail.com";
			marks = "DefaultMark";
		}

		/// <summary>
		/// Конструктор с параметрами.
		/// </summary>
		public Collector (string name, string country, string number, string email, string marks)
		{
			this.name = name;
			this.country = country;
			this.number = number;
			this.email = email;
			this.marks = marks;
		}

		/// <summary>
		/// Преобразование в массив.
		/// </summary>
		public string[] ToArray()
		{

			string[] colector = new string[5];
			colector[0] = this.name;
			colector[1] = this.country;
			colector[2] = this.number;
			colector[3] = this.email;
			colector[4] = this.marks;
			return colector;
		}

		/// <summary>
		/// Преобразование в строку.
		/// </summary>
		public override string ToString()
		{
			string result = name + ";" + country + ";" + number + ";" + email + ";" + marks;
			return result;
		}

		/// <summary>
		/// Преобразование в тип Collector из списка строк.
		/// </summary>
		public Collector ToCollector(string[] line)
		{
			Collector collector = new Collector(line[0], line[1], line[2], line[3], line[4]);
			return collector;
		}
	}
}
