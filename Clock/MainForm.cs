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
			this.MaximizeBox = false;
			this.MinimizeBox = false;
		}
		private void Timer_Tick(object sender, EventArgs e)
		{
			TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
			if (CheckBoxShowDate.Checked) TimeLabel.Text += $"\n{DateTime.Now.ToString("dd.MM.yyyy")}";
			if (CheckBoxShowWeekday.Checked && CheckBoxShowDate.Checked)
				TimeLabel.Text += $" {DateTime.Now.ToString("ddd")}";
			else if (CheckBoxShowWeekday.Checked) TimeLabel.Text += $"\n{DateTime.Now.ToString("ddd")}";
		}
		private void ButtonHideControls_Click(object sender, EventArgs e)
		{
			CheckBoxShowDate.Visible = false;
			CheckBoxShowWeekday.Visible = false;
			ButtonHideControls.Visible = false;
			this.ShowInTaskbar = false;
		}
	}
}
