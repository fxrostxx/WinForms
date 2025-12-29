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
using Microsoft.Win32;

namespace Clock
{
	public partial class MainForm : Form
	{
		FontDialog fontDialog;
		ColorDialog FGColorDialog;
		ColorDialog BGColorDialog;
		public MainForm()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, -5);
			TimeLabel.Text = DateTime.Now.ToString("HH:mm");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			LoadSettings();
			fontDialog = new FontDialog();
			FGColorDialog = new ColorDialog();
			BGColorDialog = new ColorDialog();
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
			writer.WriteLine(tsmiShowConsole.Checked);
			writer.WriteLine(TimeLabel.Font.Name);
			writer.WriteLine(TimeLabel.Font.Size);
			writer.WriteLine(TimeLabel.ForeColor.ToArgb());
			writer.WriteLine(TimeLabel.BackColor.ToArgb());
			writer.WriteLine(tsmiAutoStartup.Checked);
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
				tsmiShowConsole.Checked = Convert.ToBoolean(reader.ReadLine());
				//TimeLabel.Font.Name = reader.ReadLine();
				//TimeLabel.Font.Size = reader.ReadLine();
				reader.ReadLine();
				reader.ReadLine();
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
		private void Timer_Tick(object sender, EventArgs e)
		{
			TimeLabel.Text = DateTime.Now.ToString("HH:mm");
			if (CheckBoxShowSeconds.Checked) TimeLabel.Text += DateTime.Now.ToString(":ss");
			if (CheckBoxShowDate.Checked) TimeLabel.Text += $"\n{DateTime.Now.ToString("dd.MM.yyyy")}";
			if (CheckBoxShowWeekday.Checked && CheckBoxShowDate.Checked)
				TimeLabel.Text += $" {DateTime.Now.ToString("ddd")}";
			else if (CheckBoxShowWeekday.Checked) TimeLabel.Text += $"\n{DateTime.Now.ToString("ddd")}";
			NotifyIcon.Text = TimeLabel.Text;
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
		}
	}
}
