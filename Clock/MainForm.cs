using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			Point pt = Screen.PrimaryScreen.WorkingArea.Location;
			pt.Offset(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
			this.Location = pt;
			TimeLabel.Text = DateTime.Now.ToString("HH:mm");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
		}
		private void SetVisibility(bool visible)
		{
			CheckBoxShowDate.Visible = visible;
			CheckBoxShowWeekday.Visible = visible;
			CheckBoxShowSeconds.Visible = visible;
			ButtonHideControls.Visible = visible;
			this.ShowInTaskbar = visible;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedSingle : FormBorderStyle.None;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
			this.TopMost = visible ? false : true;
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
			SetVisibility(false);
		}
		private void TimeLabel_MouseHover(object sender, EventArgs e)
		{
			SetVisibility(true);
		}
	}
}
