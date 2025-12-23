using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
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
			TimeLabel.Text = DateTime.Now.ToString("HH:mm");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			FGColorDialog.FullOpen = BGColorDialog.FullOpen = true;
			FGColorDialog.Color = TimeLabel.ForeColor;
			BGColorDialog.Color = TimeLabel.BackColor;
			FontDialog.Font = TimeLabel.Font;
			FileDialog.Title = "Select custom font file";
			FileDialog.Filter = "TrueType font files (*.ttf)|*.ttf| OpenType font files (*.otf)|*.otf| All files (*.*)|*.*";
			FileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			SetVisibility(false);
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
			if (FGColorDialog.ShowDialog() == DialogResult.Cancel) return;
			TimeLabel.ForeColor = FGColorDialog.Color;
		}
		private void tsmiBackgroundColor_Click(object sender, EventArgs e)
		{
			if (BGColorDialog.ShowDialog() == DialogResult.Cancel) return;
			TimeLabel.BackColor = BGColorDialog.Color;
		}
		private void tsmiSelectSystemFont_Click(object sender, EventArgs e)
		{
			if (FontDialog.ShowDialog() == DialogResult.Cancel) return;
			TimeLabel.Font = FontDialog.Font;
		}
		private void tsmiSelectCustomFont_Click(object sender, EventArgs e)
		{
			if (FileDialog.ShowDialog() == DialogResult.Cancel) return;
			PrivateFontCollection privateFonts = new PrivateFontCollection();
			privateFonts.AddFontFile(FileDialog.FileName);
			FontFamily fontFamily = privateFonts.Families[0];
			Font customFont = new Font(fontFamily, TimeLabel.Font.Size, TimeLabel.Font.Style);
			TimeLabel.Font = customFont;
		}
	}
}
