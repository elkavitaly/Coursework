using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Coursework
{
	class CollectorList
	{
		public List<Collector> collectorList;
		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public CollectorList()
		{
			StreamReader reader = new StreamReader("Collector.txt");
			string str;
			List<Collector> data = new List<Collector>();

			while ((str = reader.ReadLine()) != null)
			{
				string[] line = str.Split(';');
				data.Add(new Collector(line[0], line[1], line[2], line[3], line[4]));
			}

			reader.Close();
			collectorList = data;
		}
	
		/// <summary>
		/// Преобразование в массив строк из списка коллекционеров.
		/// </summary>
		public string[][] ToStringArray()
		{
			string[][] arr = new string[collectorList.Count][];

			for (int i = 0; i < collectorList.Count; i++)
			{
				arr[i] = collectorList[i].ToArray();
			}
			return arr;
		}

		/// <summary>
		/// Запись списка коллекционеров в файл.
		/// </summary>
		public void WriteList()
		{
			StreamWriter writer = new StreamWriter("Collector.txt");

			foreach (Collector s in collectorList)
			{
				writer.WriteLine(s.ToString());
			}
			writer.Close();
		}
	}
}
