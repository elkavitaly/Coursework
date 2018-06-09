using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Coursework
{
	class MarkList
	{
		public List<Mark> markList;
		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public MarkList()
		{
			StreamReader reader = new StreamReader("Mark.txt");
			string str;
			List<Mark> data = new List<Mark>();

			while ((str = reader.ReadLine()) != null)
			{
				string[] line = str.Split(';');
				data.Add(new Mark(line[0], Convert.ToDouble(line[1]), Convert.ToInt32(line[2]), line[3], line[4], Convert.ToInt32(line[5])));
			}

			reader.Close();
			markList = data;
		}

		/// <summary>
		/// Преобразование списка марок в массив строк.
		/// </summary>

		public string[][] ToStringArray()
		{
			string[][] arr = new string[markList.Count][];

			for (int i = 0; i < markList.Count; i++)
			{
				arr[i] = markList[i].ToArray();
			}
			return arr;
		}

		/// <summary>
		/// Запись списка марок в файл.
		/// </summary>
		public void WriteList()
		{
			StreamWriter writer = new StreamWriter("Mark.txt");

			foreach (Mark s in markList)
			{
				writer.WriteLine(s.ToString());
			}
			writer.Close();
		}

		/// <summary>
		/// Преобразование списка названий марок в массив строк.
		/// </summary>
		public string[] ToNameList()
		{
			string[] arr = new string[markList.Count];
			for (int i = 0; i < markList.Count; i++)
			{
				arr[i] = markList[i].name;
			}
			return arr;
		}
	}
}
