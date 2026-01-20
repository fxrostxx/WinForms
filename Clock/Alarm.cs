using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Alarm : IComparable<Alarm>
	{
		public Alarm() { }
		public Alarm(Alarm other)
		{
			this.Date = other.Date;
			this.Time = other.Time;
			this.Days = other.Days;
			this.Filename = other.Filename;
		}
		public Alarm(string settings)
		{
			string[] parts = settings.Split('|');
			this.Date = DateTime.Parse(parts[0]);
			this.Time = TimeSpan.Parse(parts[1]);
			this.Days = new Week(byte.Parse(parts[2]));
			this.Filename = parts[3];
		}
		public int CompareTo(Alarm other)
		{
			return this.Time.CompareTo(other.Time);
		}
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week Days { get; set; }
		public string Filename { get; set; }
		public string ToSettingsString()
		{
			return $"{Date.ToString("dd.MM.yyyy")}|{Time.ToString()}|{Days.DaysMask}|{Filename}";
		}
		public override string ToString()
		{
			string info = "";
			string daysAlign = Days.ToString().Length < 9 ? "\t" : "";
			info += Date != DateTime.MinValue ? Date.ToString("dd.MM.yyyy") : Days.DaysMask != 127 ? Days.ToString() + daysAlign : "Каждый день";
			info += $"\t{DateTime.Today.Add(Time).ToString("HH:mm:ss")}";
			info += $"\t{Filename.Split('\\').Last()}";
			return info;
		}
	}
}
