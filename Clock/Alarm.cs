using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Alarm
	{
		public DateTime Date { get; set; }
		public DateTime Time { get; set; }
		public Week Days { get; set; }
		public string Filename { get; set; }
		public override string ToString()
		{
			string info = "";
			info += Date != DateTime.MinValue ? Date.ToString("dd.MM.yyyy") : "Каждый день";
			info += $"\t{Time.ToString("HH:mm:ss")}";
			info += $"\t{Days}";
			info += $"\t{Filename.Split('\\').Last()}";
			return info;
		}
	}
}
