using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RightsChange
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Directory.SetCurrentDirectory("\\..\\..\\Program Files\\PV_521\\Clock");
			FileSecurity settings = File.GetAccessControl("settings.ini");
			FileSecurity alarms = File.GetAccessControl("alarms.ini");
			FileSystemAccessRule everyone = new FileSystemAccessRule
			(
				new SecurityIdentifier(WellKnownSidType.WorldSid, null),
				FileSystemRights.FullControl,
				AccessControlType.Allow
			);
			settings.AddAccessRule(everyone);
			alarms.AddAccessRule(everyone);
			File.SetAccessControl("settings.ini", settings);
			File.SetAccessControl("alarms.ini", alarms);
			Directory.SetCurrentDirectory("\\..\\..\\Program Files\\PV_521\\Clock\\bin\\Debug");
			bool end = false;
			while (!end)
			{
				Console.Write("Launch app now? (Y/n): ");
				string choice = Console.ReadLine();
				switch (choice)
				{
					case "Y":
					case "y":
					case "": Process.Start("Clock.exe"); ; end = true; break;
					case "N":
					case "n": end = true; break;
					default: Console.WriteLine("Invalid input"); break;
				}
			}
		}
	}
}
