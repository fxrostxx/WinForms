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
		public AlarmDialog()
		{
			InitializeComponent();
			fileDialog = new OpenFileDialog();
			fileDialog.Filter = "All audiofiles|*.wav;*.mp3;*.flac;*.wma|" + "WAV files (*.wav)|*.wav|" + "MP3 files (*.mp3)|*.mp3|" + "FLAC files (*.flac)|*.flac|" + "WMA files (*.wma)|*.wma";
			dtpDate.Enabled = false;
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
	}
}
