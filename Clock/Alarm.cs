using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Alarm
	{
		public Alarm() { }
		public Alarm(Alarm other)
		{
			this.Date = other.Date;
			this.Time = other.Time;
			this.Days = other.Days;
			this.Filename = other.Filename;
		}
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week Days { get; set; }
		public string Filename { get; set; }
		public override string ToString()
		{
			string info = "";
			string daysAlign = Days.ToString().Length < 9 ? "\t" : "";
			info += Date != DateTime.MinValue ? Date.ToString("dd.MM.yyyy") : Days.DaysMask != 0 ? Days.ToString() + daysAlign : "Каждый день";
			info += $"\t{DateTime.Today.Add(Time).ToString("HH:mm:ss")}";
			info += $"\t{Filename.Split('\\').Last()}";
			return info;
		}
	}
}
