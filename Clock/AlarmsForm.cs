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
	public partial class AlarmsForm : Form
	{
		AlarmDialog alarm;
		public AlarmsForm()
		{
			InitializeComponent();
			alarm = new AlarmDialog();
		}
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			alarm.Location = new Point(this.Location.X + (this.Width - alarm.Width) / 2, this.Location.Y + (this.Height - alarm.Height) / 2);
			if (alarm.ShowDialog() == DialogResult.OK)
				listBoxAlarms.Items.Add(alarm.Alarm);

		}
		private void listBoxAlarms_DoubleClick(object sender, EventArgs e)
		{
			if (listBoxAlarms.SelectedIndex == -1) return;
			Alarm selectedAlarm = listBoxAlarms.SelectedItem as Alarm;
			AlarmDialog editAlarm = new AlarmDialog();
			editAlarm.SetAlarm(selectedAlarm);
			editAlarm.Location = new Point(this.Location.X + (this.Width - editAlarm.Width) / 2, this.Location.Y + (this.Height - editAlarm.Height) / 2);
			if (editAlarm.ShowDialog() == DialogResult.OK)
				listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = editAlarm.Alarm;
		}
		private void buttonRemove_Click(object sender, EventArgs e)
		{
			if (listBoxAlarms.SelectedIndex != -1)
				listBoxAlarms.Items.RemoveAt(listBoxAlarms.SelectedIndex);
		}
	}
}
