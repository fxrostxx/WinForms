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
		public List<string> alarmsSettings { get; set; }
		public AlarmDialog()
		{
			InitializeComponent();
			alarmsSettings = new List<string>();
			dateTimePicker.Format = DateTimePickerFormat.Custom;
			checkedListBoxWeekdays.Enabled = false;
			dateTimePicker.CustomFormat = "dd MMMM yyyy - HH:mm";
		}
		public AlarmDialog(List<string> alarms) : this()
		{
			alarmsSettings = alarms;
			for (int i = 0; i < alarms.Count; ++i)
				checkedListBoxAlarms.Items.Add(alarms[i].Split(';').Last(), Convert.ToBoolean(alarms[i].Split(';').First()));
		}
		private void AlarmDialog_Load(object sender, EventArgs e)
		{
			dateTimePicker.MinDate = DateTime.Now.AddMinutes(3);
			for (int i = 0; i < checkedListBoxWeekdays.Items.Count; ++i) checkedListBoxWeekdays.SetItemChecked(i, false);
			checkBoxByWeekday.Checked = false;
			dateTimePicker.CustomFormat = "dd MMMM yyyy - HH:mm";
		}
		private void checkBoxByWeekday_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxByWeekday.Checked)
			{
				dateTimePicker.MinDate = DateTime.Today;
				checkedListBoxWeekdays.Enabled = true;
				dateTimePicker.CustomFormat = "HH:mm";
			}
			else
			{
				dateTimePicker.MinDate = DateTime.Now.AddMinutes(3);
				for (int i = 0; i < checkedListBoxWeekdays.Items.Count; ++i) checkedListBoxWeekdays.SetItemChecked(i, false);
				checkedListBoxWeekdays.Enabled = false;
				dateTimePicker.CustomFormat = "dd MMMM yyyy - HH:mm";
			}
		}
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (checkBoxByWeekday.Checked)
			{
				if (checkedListBoxWeekdays.CheckedItems.Count == 0)
				{
					MessageBox.Show("Choose at least one weekday", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				string alarmSettings = "";
				foreach (string item in checkedListBoxWeekdays.CheckedItems)
					alarmSettings += $"{item} ";
				alarmSettings += $"- {dateTimePicker.Text}";
				if (checkedListBoxAlarms.FindString(alarmSettings) == ListBox.NoMatches)
					checkedListBoxAlarms.Items.Add(alarmSettings, true);
			}
			else
			{
				string alarmSettings = "";
				alarmSettings += $"{dateTimePicker.Text}";
				if (checkedListBoxAlarms.FindString(alarmSettings) == ListBox.NoMatches)
					checkedListBoxAlarms.Items.Add(alarmSettings, true);
			}
		}
		private void buttonRemove_Click(object sender, EventArgs e)
		{
			if (checkedListBoxAlarms.SelectedIndex >= 0)
				checkedListBoxAlarms.Items.RemoveAt(checkedListBoxAlarms.SelectedIndex);
			else MessageBox.Show("Please select an alarm to remove", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		private void buttonOK_Click(object sender, EventArgs e)
		{
			alarmsSettings.Clear();
			for (int i = 0; i < checkedListBoxAlarms.Items.Count; ++i)
				alarmsSettings.Add($"{checkedListBoxAlarms.GetItemChecked(i)};{checkedListBoxAlarms.Items[i].ToString()}");
		}
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			checkedListBoxAlarms.Items.Clear();
			for (int i = 0; i < alarmsSettings.Count; ++i)
				checkedListBoxAlarms.Items.Add(alarmsSettings[i].Split(';').Last(), Convert.ToBoolean(alarmsSettings[i].Split(';').First()));
		}
	}
}
