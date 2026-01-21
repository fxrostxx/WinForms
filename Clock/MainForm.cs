using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Clock
{
	public partial class MainForm : Form
	{
		FontDialog fontDialog;
		ColorDialog FGColorDialog;
		ColorDialog BGColorDialog;
		AlarmsForm alarms;
		Alarm alarm;
		public MainForm()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, -5);
			TimeLabel.Text = DateTime.Now.ToString("HH:mm");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			fontDialog = new FontDialog();
			FGColorDialog = new ColorDialog();
			BGColorDialog = new ColorDialog();
			alarms = new AlarmsForm();
			alarm = null;
			axWindowsMediaPlayer.Visible = false;
			LoadSettings();
			LoadAlarmsSettings();
		}
		private void SetVisibility(bool visible)
		{
			CheckBoxShowSeconds.Visible = visible;
			CheckBoxShowDate.Visible = visible;
			CheckBoxShowWeekday.Visible = visible;
			ButtonHideControls.Visible = visible;
			this.ShowInTaskbar = visible;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedSingle : FormBorderStyle.None;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
		}
		private void SaveSettings()
		{
			Directory.SetCurrentDirectory(Application.StartupPath + "\\..\\..\\");
			StreamWriter writer = new StreamWriter("settings.ini");
			writer.WriteLine(this.Location.X);
			writer.WriteLine(this.Location.Y);
			writer.WriteLine(this.TopMost);
			writer.WriteLine(tsmiShowControls.Checked);
			writer.WriteLine(tsmiShowSeconds.Checked);
			writer.WriteLine(tsmiShowDate.Checked);
			writer.WriteLine(tsmiShowWeekday.Checked);
			writer.WriteLine(fontDialog.Filename);
			writer.WriteLine(TimeLabel.Font.Size);
			writer.WriteLine(TimeLabel.ForeColor.ToArgb());
			writer.WriteLine(TimeLabel.BackColor.ToArgb());
			writer.WriteLine(tsmiAutoStartup.Checked);
			writer.Close();
		}
		private void SaveAlarmsSettings()
		{
			Directory.SetCurrentDirectory(Application.StartupPath + "\\..\\..\\");
			StreamWriter writer = new StreamWriter("alarms.ini");
			for (int i = 0; i < alarms.List.Items.Count; ++i)
				writer.WriteLine((alarms.List.Items[i] as Alarm).ToSettingsString());
			writer.Close();
		}
		void LoadSettings()
		{
			Directory.SetCurrentDirectory(Application.StartupPath + "\\..\\..\\");
			if (File.Exists("settings.ini"))
			{
				StreamReader reader = new StreamReader("settings.ini");
				this.Location = new Point(Convert.ToInt32(reader.ReadLine()), Convert.ToInt32(reader.ReadLine()));
				this.TopMost = tsmiTopmost.Checked = Convert.ToBoolean(reader.ReadLine());
				tsmiShowControls.Checked = Convert.ToBoolean(reader.ReadLine());
				SetVisibility(tsmiShowControls.Checked);
				tsmiShowSeconds.Checked = Convert.ToBoolean(reader.ReadLine());
				tsmiShowDate.Checked = Convert.ToBoolean(reader.ReadLine());
				tsmiShowWeekday.Checked = Convert.ToBoolean(reader.ReadLine());
				fontDialog = new FontDialog(reader.ReadLine(), reader.ReadLine());
				TimeLabel.Font = fontDialog.Font;
				TimeLabel.ForeColor = Color.FromArgb(Convert.ToInt32(reader.ReadLine()));
				TimeLabel.BackColor = Color.FromArgb(Convert.ToInt32(reader.ReadLine()));
				tsmiAutoStartup.Checked = Convert.ToBoolean(reader.ReadLine());
				reader.Close();
			}
			else
			{
				SetVisibility(false);
				this.TopMost = tsmiTopmost.Checked = true;
			}
		}
		void LoadAlarmsSettings()
		{
			Directory.SetCurrentDirectory(Application.StartupPath + "\\..\\..\\");
			if (File.Exists("alarms.ini"))
			{
				StreamReader reader = new StreamReader("alarms.ini");
				string settings;
				while ((settings = reader.ReadLine()) != null)
					alarms.List.Items.Add(new Alarm(settings));
				reader.Close();
			}
		}
		private void Timer_Tick(object sender, EventArgs e)
		{
			TimeLabel.Text = DateTime.Now.ToString("HH:mm");
			if (CheckBoxShowSeconds.Checked) TimeLabel.Text += DateTime.Now.ToString(":ss");
			if (CheckBoxShowDate.Checked) TimeLabel.Text += $"\n{DateTime.Now.ToString("dd.MM.yyyy")}";
			if (CheckBoxShowWeekday.Checked && CheckBoxShowDate.Checked)
				TimeLabel.Text += $" {DateTime.Now.ToString("ddd")}";
			else if (CheckBoxShowWeekday.Checked) TimeLabel.Text += $"\n{DateTime.Now.ToString("ddd")}";
			if
			(
				alarm != null
				&&
				(
					alarm.Date == DateTime.MinValue ?
					alarm.Days.Contains((byte)DateTime.Now.DayOfWeek) :
					CompareDates(alarm.Date, DateTime.Now)
				)
				&& alarm.Time.Hours == DateTime.Now.Hour
				&& alarm.Time.Minutes == DateTime.Now.Minute
				&& alarm.Time.Seconds == DateTime.Now.Second
			)
				PlayAlarm();
				//MessageBox.Show(alarm.ToString());
			if (DateTime.Now.Second % 5 == 0) alarm = FindNextAlarm();
			NotifyIcon.Text = TimeLabel.Text;
			Console.WriteLine(axWindowsMediaPlayer.Visible);
		}
		void PlayAlarm()
		{
			axWindowsMediaPlayer.URL = alarm.Filename;
			axWindowsMediaPlayer.settings.volume = 100;
			axWindowsMediaPlayer.Ctlcontrols.play();
			axWindowsMediaPlayer.Visible = true;
		}
		void SetPlayerInvisible(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
		{
			if
			(
				axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded ||
				axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped ||
				axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused
			)
				axWindowsMediaPlayer.Visible = false;
		}
		bool CompareDates(DateTime date1, DateTime date2)
		{
			return date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day;
		}
		Alarm FindNextAlarm()
		{
			Alarm[] actualAlarms = alarms.List.Items.Cast<Alarm>().Where(a => a.Time > DateTime.Now.TimeOfDay).ToArray();
			return actualAlarms.Min();
		}
		private void ButtonHideControls_Click(object sender, EventArgs e)
		{
			SetVisibility(tsmiShowControls.Checked = false);
		}
		//private void TimeLabel_MouseHover(object sender, EventArgs e)
		//{
		//	SetVisibility(true);
		//}
		private void tsmiTopmost_Click(object sender, EventArgs e) =>
			this.TopMost = tsmiTopmost.Checked;
		private void tsmiShowControls_CheckedChanged(object sender, EventArgs e) =>
			SetVisibility((sender as ToolStripMenuItem).Checked);
		private void tsmiShowSeconds_CheckedChanged(object sender, EventArgs e) =>
			CheckBoxShowSeconds.Checked = tsmiShowSeconds.Checked;
		private void CheckBoxShowSeconds_CheckedChanged(object sender, EventArgs e) =>
			tsmiShowSeconds.Checked = CheckBoxShowSeconds.Checked;
		private void tsmiShowDate_CheckedChanged(object sender, EventArgs e) =>
			CheckBoxShowDate.Checked = tsmiShowDate.Checked;
		private void CheckBoxShowDate_CheckedChanged(object sender, EventArgs e) =>
			tsmiShowDate.Checked = CheckBoxShowDate.Checked;
		private void tsmiShowWeekday_CheckedChanged(object sender, EventArgs e) =>
			CheckBoxShowWeekday.Checked = tsmiShowWeekday.Checked;
		private void CheckBoxShowWeekday_CheckedChanged(object sender, EventArgs e) =>
			tsmiShowWeekday.Checked = CheckBoxShowWeekday.Checked;
		private void tsmiExit_Click(object sender, EventArgs e) => this.Close();
		private void tsmiForegroundColor_Click(object sender, EventArgs e)
		{
			if (FGColorDialog.ShowDialog() == DialogResult.OK)
				TimeLabel.ForeColor = FGColorDialog.Color;
		}
		private void tsmiBackgroundColor_Click(object sender, EventArgs e)
		{
			if (BGColorDialog.ShowDialog() == DialogResult.OK)
				TimeLabel.BackColor = BGColorDialog.Color;
		}
		private void tsmiSelectFont_Click(object sender, EventArgs e)
		{
			fontDialog.Location = new Point(this.Location.X - fontDialog.Width - 10, this.Location.Y);
			fontDialog.Font = TimeLabel.Font;
			if (fontDialog.ShowDialog() == DialogResult.OK) TimeLabel.Font = fontDialog.Font;
		}
		private void tsmiAutoStartup_CheckedChanged(object sender, EventArgs e)
		{
			string key_name = "ClockCS";
			RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (tsmiAutoStartup.Checked) rk.SetValue(key_name, Application.ExecutablePath);
			else rk.DeleteValue(key_name, false);
			rk.Dispose();
		}
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			SaveSettings();
			SaveAlarmsSettings();
		}
		private void tsmiAlarms_Click(object sender, EventArgs e)
		{
			alarms.Location = new Point(this.Location.X - alarms.Width - 10, this.Location.Y);
			alarms.ShowDialog();
		}
		private void tsmiShowConsole_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as ToolStripMenuItem).Checked) AllocConsole();
			else FreeConsole();
		}
		[DllImport("kernel32.dll")]
		public static extern void AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern void FreeConsole();
		private void MainForm_Load(object sender, EventArgs e)
		{
			axWindowsMediaPlayer.Visible = false;
		}
	}
}
