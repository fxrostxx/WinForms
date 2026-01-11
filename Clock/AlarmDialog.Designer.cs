namespace Clock
{
    partial class AlarmDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.checkedListBoxAlarms = new System.Windows.Forms.CheckedListBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.checkedListBoxWeekdays = new System.Windows.Forms.CheckedListBox();
			this.checkBoxByWeekday = new System.Windows.Forms.CheckBox();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			this.buttonChooseMelody = new System.Windows.Forms.Button();
			this.labelMelody = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkedListBoxAlarms
			// 
			this.checkedListBoxAlarms.FormattingEnabled = true;
			this.checkedListBoxAlarms.Location = new System.Drawing.Point(12, 12);
			this.checkedListBoxAlarms.Name = "checkedListBoxAlarms";
			this.checkedListBoxAlarms.Size = new System.Drawing.Size(818, 123);
			this.checkedListBoxAlarms.TabIndex = 0;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(755, 371);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 30);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(674, 371);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 30);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(12, 371);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 30);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonRemove
			// 
			this.buttonRemove.Location = new System.Drawing.Point(93, 371);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(75, 30);
			this.buttonRemove.TabIndex = 7;
			this.buttonRemove.Text = "Remove";
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(93, 208);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(239, 22);
			this.dateTimePicker.TabIndex = 8;
			// 
			// checkedListBoxWeekdays
			// 
			this.checkedListBoxWeekdays.FormattingEnabled = true;
			this.checkedListBoxWeekdays.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
			this.checkedListBoxWeekdays.Location = new System.Drawing.Point(12, 178);
			this.checkedListBoxWeekdays.Name = "checkedListBoxWeekdays";
			this.checkedListBoxWeekdays.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.checkedListBoxWeekdays.Size = new System.Drawing.Size(75, 140);
			this.checkedListBoxWeekdays.TabIndex = 9;
			// 
			// checkBoxByWeekday
			// 
			this.checkBoxByWeekday.AutoSize = true;
			this.checkBoxByWeekday.Location = new System.Drawing.Point(93, 178);
			this.checkBoxByWeekday.Name = "checkBoxByWeekday";
			this.checkBoxByWeekday.Size = new System.Drawing.Size(110, 20);
			this.checkBoxByWeekday.TabIndex = 10;
			this.checkBoxByWeekday.Text = "By weekdays";
			this.checkBoxByWeekday.UseVisualStyleBackColor = true;
			this.checkBoxByWeekday.CheckedChanged += new System.EventHandler(this.checkBoxByWeekday_CheckedChanged);
			// 
			// buttonChooseMelody
			// 
			this.buttonChooseMelody.Location = new System.Drawing.Point(174, 371);
			this.buttonChooseMelody.Name = "buttonChooseMelody";
			this.buttonChooseMelody.Size = new System.Drawing.Size(119, 30);
			this.buttonChooseMelody.TabIndex = 11;
			this.buttonChooseMelody.Text = "Choose melody";
			this.buttonChooseMelody.UseVisualStyleBackColor = true;
			this.buttonChooseMelody.Click += new System.EventHandler(this.buttonChooseMelody_Click);
			// 
			// labelMelody
			// 
			this.labelMelody.AutoSize = true;
			this.labelMelody.Location = new System.Drawing.Point(93, 242);
			this.labelMelody.Name = "labelMelody";
			this.labelMelody.Size = new System.Drawing.Size(58, 16);
			this.labelMelody.TabIndex = 12;
			this.labelMelody.Text = "Melody: ";
			// 
			// AlarmDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(842, 413);
			this.Controls.Add(this.labelMelody);
			this.Controls.Add(this.buttonChooseMelody);
			this.Controls.Add(this.checkBoxByWeekday);
			this.Controls.Add(this.checkedListBoxWeekdays);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.buttonRemove);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.checkedListBoxAlarms);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AlarmDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Set alarm";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.AlarmDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.CheckedListBox checkedListBoxAlarms;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.CheckedListBox checkedListBoxWeekdays;
		private System.Windows.Forms.CheckBox checkBoxByWeekday;
		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.Button buttonChooseMelody;
		private System.Windows.Forms.Label labelMelody;
	}
}