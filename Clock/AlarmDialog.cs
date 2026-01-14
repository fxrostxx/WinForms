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
	public partial class AlarmDialog : Form
	{
		OpenFileDialog fileDialog;
		public Alarm Alarm { get; private set; }
		public AlarmDialog()
		{
			InitializeComponent();
			fileDialog = new OpenFileDialog();
			fileDialog.Filter = "All audiofiles|*.wav;*.mp3;*.flac;*.wma|" + "WAV files (*.wav)|*.wav|" + "MP3 files (*.mp3)|*.mp3|" + "FLAC files (*.flac)|*.flac|" + "WMA files (*.wma)|*.wma";
			dtpDate.Enabled = false;
			Alarm = new Alarm();
		}
		private void checkBoxUseDate_CheckedChanged(object sender, EventArgs e)
		{
			dtpDate.Enabled = (sender as CheckBox).Checked;
			clbWeekdays.Enabled = !dtpDate.Enabled;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				labelFilename.Text = fileDialog.FileName;
			}
		}
		private void clbWeekdays_SelectedIndexChanged(object sender, EventArgs e)
		{
			Console.WriteLine("clbWeekdays_SelectedIndexChanged");
			for (int i = 0; i < clbWeekdays.CheckedItems.Count; ++i)
				Console.Write($"{clbWeekdays.CheckedItems[i]} ");
			Console.WriteLine();
			for (int i = 0; i < clbWeekdays.CheckedIndices.Count; ++i)
				Console.Write($"{clbWeekdays.CheckedIndices[i]} ");
			Console.WriteLine();
			byte days = 0;
			for (int i = 0; i < clbWeekdays.CheckedIndices.Count; ++i)
			{
				days |= (byte)(1 << clbWeekdays.CheckedIndices[i]);
				Console.Write($"{clbWeekdays.CheckedIndices[i]} ");
			}
			Console.WriteLine($"Days mask: {days}");
			Console.WriteLine("\n------------------------------------\n");
		}
		byte GetDaysMask()
		{
			byte days = 0;
			for (int i = 0; i < clbWeekdays.CheckedIndices.Count; ++i)
				days |= (byte)(1 << clbWeekdays.CheckedIndices[i]);
			return days;
		}
		private void buttonOk_Click(object sender, EventArgs e)
		{
			Alarm.Date = checkBoxUseDate.Checked ? dtpDate.Value : DateTime.MinValue;
			Alarm.Time = dtpTime.Value;
			Alarm.Days = new Week(GetDaysMask());
			Alarm.Filename = labelFilename.Text;
		}
	}
}
