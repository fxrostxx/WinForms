namespace Clock
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.TimeLabel = new System.Windows.Forms.Label();
			this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiShowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiShowSeconds = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiShowConsole = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiSelectFont = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSelectColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiAlarms = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiAutoStartup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.CheckBoxShowDate = new System.Windows.Forms.CheckBox();
			this.CheckBoxShowWeekday = new System.Windows.Forms.CheckBox();
			this.ButtonHideControls = new System.Windows.Forms.Button();
			this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.CheckBoxShowSeconds = new System.Windows.Forms.CheckBox();
			this.ContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// TimeLabel
			// 
			this.TimeLabel.AutoSize = true;
			this.TimeLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.TimeLabel.ContextMenuStrip = this.ContextMenuStrip;
			this.TimeLabel.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TimeLabel.Location = new System.Drawing.Point(12, 9);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(315, 60);
			this.TimeLabel.TabIndex = 0;
			this.TimeLabel.Text = "CurrentTime";
			this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ContextMenuStrip
			// 
			this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTopmost,
            this.tsmiShowControls,
            this.toolStripSeparator1,
            this.tsmiShowSeconds,
            this.tsmiShowDate,
            this.tsmiShowWeekday,
            this.toolStripSeparator2,
            this.tsmiShowConsole,
            this.toolStripSeparator3,
            this.tsmiSelectFont,
            this.tsmiSelectColor,
            this.toolStripSeparator4,
            this.tsmiAlarms,
            this.toolStripSeparator5,
            this.tsmiAutoStartup,
            this.toolStripSeparator6,
            this.tsmiExit});
			this.ContextMenuStrip.Name = "ContextMenuStrip";
			this.ContextMenuStrip.Size = new System.Drawing.Size(211, 354);
			// 
			// tsmiTopmost
			// 
			this.tsmiTopmost.CheckOnClick = true;
			this.tsmiTopmost.Name = "tsmiTopmost";
			this.tsmiTopmost.Size = new System.Drawing.Size(210, 26);
			this.tsmiTopmost.Text = "Topmost";
			this.tsmiTopmost.Click += new System.EventHandler(this.tsmiTopmost_Click);
			// 
			// tsmiShowControls
			// 
			this.tsmiShowControls.CheckOnClick = true;
			this.tsmiShowControls.Name = "tsmiShowControls";
			this.tsmiShowControls.Size = new System.Drawing.Size(210, 26);
			this.tsmiShowControls.Text = "Show controls";
			this.tsmiShowControls.CheckedChanged += new System.EventHandler(this.tsmiShowControls_CheckedChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
			// 
			// tsmiShowSeconds
			// 
			this.tsmiShowSeconds.CheckOnClick = true;
			this.tsmiShowSeconds.Name = "tsmiShowSeconds";
			this.tsmiShowSeconds.Size = new System.Drawing.Size(210, 26);
			this.tsmiShowSeconds.Text = "Show seconds";
			this.tsmiShowSeconds.CheckedChanged += new System.EventHandler(this.tsmiShowSeconds_CheckedChanged);
			// 
			// tsmiShowDate
			// 
			this.tsmiShowDate.CheckOnClick = true;
			this.tsmiShowDate.Name = "tsmiShowDate";
			this.tsmiShowDate.Size = new System.Drawing.Size(210, 26);
			this.tsmiShowDate.Text = "Show date";
			this.tsmiShowDate.CheckedChanged += new System.EventHandler(this.tsmiShowDate_CheckedChanged);
			// 
			// tsmiShowWeekday
			// 
			this.tsmiShowWeekday.CheckOnClick = true;
			this.tsmiShowWeekday.Name = "tsmiShowWeekday";
			this.tsmiShowWeekday.Size = new System.Drawing.Size(210, 26);
			this.tsmiShowWeekday.Text = "Show weekday";
			this.tsmiShowWeekday.CheckedChanged += new System.EventHandler(this.tsmiShowWeekday_CheckedChanged);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
			// 
			// tsmiShowConsole
			// 
			this.tsmiShowConsole.CheckOnClick = true;
			this.tsmiShowConsole.Name = "tsmiShowConsole";
			this.tsmiShowConsole.Size = new System.Drawing.Size(210, 26);
			this.tsmiShowConsole.Text = "Show console";
			this.tsmiShowConsole.CheckedChanged += new System.EventHandler(this.tsmiShowConsole_CheckedChanged);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
			// 
			// tsmiSelectFont
			// 
			this.tsmiSelectFont.Name = "tsmiSelectFont";
			this.tsmiSelectFont.Size = new System.Drawing.Size(210, 26);
			this.tsmiSelectFont.Text = "Select font";
			this.tsmiSelectFont.Click += new System.EventHandler(this.tsmiSelectFont_Click);
			// 
			// tsmiSelectColor
			// 
			this.tsmiSelectColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForegroundColor,
            this.tsmiBackgroundColor});
			this.tsmiSelectColor.Name = "tsmiSelectColor";
			this.tsmiSelectColor.Size = new System.Drawing.Size(210, 26);
			this.tsmiSelectColor.Text = "Select color";
			// 
			// tsmiForegroundColor
			// 
			this.tsmiForegroundColor.Name = "tsmiForegroundColor";
			this.tsmiForegroundColor.Size = new System.Drawing.Size(209, 26);
			this.tsmiForegroundColor.Text = "Foreground color";
			this.tsmiForegroundColor.Click += new System.EventHandler(this.tsmiForegroundColor_Click);
			// 
			// tsmiBackgroundColor
			// 
			this.tsmiBackgroundColor.Name = "tsmiBackgroundColor";
			this.tsmiBackgroundColor.Size = new System.Drawing.Size(209, 26);
			this.tsmiBackgroundColor.Text = "Background color";
			this.tsmiBackgroundColor.Click += new System.EventHandler(this.tsmiBackgroundColor_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(207, 6);
			// 
			// tsmiAlarms
			// 
			this.tsmiAlarms.Name = "tsmiAlarms";
			this.tsmiAlarms.Size = new System.Drawing.Size(210, 26);
			this.tsmiAlarms.Text = "Alarms";
			this.tsmiAlarms.Click += new System.EventHandler(this.tsmiAlarms_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(207, 6);
			// 
			// tsmiAutoStartup
			// 
			this.tsmiAutoStartup.CheckOnClick = true;
			this.tsmiAutoStartup.Name = "tsmiAutoStartup";
			this.tsmiAutoStartup.Size = new System.Drawing.Size(210, 26);
			this.tsmiAutoStartup.Text = "Auto startup";
			this.tsmiAutoStartup.CheckedChanged += new System.EventHandler(this.tsmiAutoStartup_CheckedChanged);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(207, 6);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(210, 26);
			this.tsmiExit.Text = "Exit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// Timer
			// 
			this.Timer.Enabled = true;
			this.Timer.Interval = 1000;
			this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// CheckBoxShowDate
			// 
			this.CheckBoxShowDate.AutoSize = true;
			this.CheckBoxShowDate.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CheckBoxShowDate.Location = new System.Drawing.Point(22, 184);
			this.CheckBoxShowDate.Name = "CheckBoxShowDate";
			this.CheckBoxShowDate.Size = new System.Drawing.Size(167, 36);
			this.CheckBoxShowDate.TabIndex = 1;
			this.CheckBoxShowDate.Text = "Show date";
			this.CheckBoxShowDate.UseVisualStyleBackColor = true;
			this.CheckBoxShowDate.CheckedChanged += new System.EventHandler(this.CheckBoxShowDate_CheckedChanged);
			// 
			// CheckBoxShowWeekday
			// 
			this.CheckBoxShowWeekday.AutoSize = true;
			this.CheckBoxShowWeekday.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CheckBoxShowWeekday.Location = new System.Drawing.Point(22, 226);
			this.CheckBoxShowWeekday.Name = "CheckBoxShowWeekday";
			this.CheckBoxShowWeekday.Size = new System.Drawing.Size(220, 36);
			this.CheckBoxShowWeekday.TabIndex = 2;
			this.CheckBoxShowWeekday.Text = "Show weekday";
			this.CheckBoxShowWeekday.UseVisualStyleBackColor = true;
			this.CheckBoxShowWeekday.CheckedChanged += new System.EventHandler(this.CheckBoxShowWeekday_CheckedChanged);
			// 
			// ButtonHideControls
			// 
			this.ButtonHideControls.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ButtonHideControls.Location = new System.Drawing.Point(22, 268);
			this.ButtonHideControls.Name = "ButtonHideControls";
			this.ButtonHideControls.Size = new System.Drawing.Size(100, 54);
			this.ButtonHideControls.TabIndex = 3;
			this.ButtonHideControls.Text = "Hide controls";
			this.ButtonHideControls.UseVisualStyleBackColor = true;
			this.ButtonHideControls.Click += new System.EventHandler(this.ButtonHideControls_Click);
			// 
			// NotifyIcon
			// 
			this.NotifyIcon.ContextMenuStrip = this.ContextMenuStrip;
			this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
			this.NotifyIcon.Text = "Clock";
			this.NotifyIcon.Visible = true;
			// 
			// CheckBoxShowSeconds
			// 
			this.CheckBoxShowSeconds.AutoSize = true;
			this.CheckBoxShowSeconds.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CheckBoxShowSeconds.Location = new System.Drawing.Point(22, 142);
			this.CheckBoxShowSeconds.Name = "CheckBoxShowSeconds";
			this.CheckBoxShowSeconds.Size = new System.Drawing.Size(217, 36);
			this.CheckBoxShowSeconds.TabIndex = 4;
			this.CheckBoxShowSeconds.Text = "Show seconds";
			this.CheckBoxShowSeconds.UseVisualStyleBackColor = true;
			this.CheckBoxShowSeconds.CheckedChanged += new System.EventHandler(this.CheckBoxShowSeconds_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 334);
			this.Controls.Add(this.CheckBoxShowSeconds);
			this.Controls.Add(this.ButtonHideControls);
			this.Controls.Add(this.CheckBoxShowWeekday);
			this.Controls.Add(this.CheckBoxShowDate);
			this.Controls.Add(this.TimeLabel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Clock";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.ContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TimeLabel;
		private System.Windows.Forms.Timer Timer;
		private System.Windows.Forms.CheckBox CheckBoxShowDate;
		private System.Windows.Forms.CheckBox CheckBoxShowWeekday;
		private System.Windows.Forms.Button ButtonHideControls;
		private System.Windows.Forms.NotifyIcon NotifyIcon;
		private System.Windows.Forms.CheckBox CheckBoxShowSeconds;
		private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem tsmiTopmost;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowSeconds;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowDate;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowWeekday;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowConsole;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem tsmiSelectFont;
		private System.Windows.Forms.ToolStripMenuItem tsmiSelectColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiForegroundColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem tsmiAlarms;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem tsmiAutoStartup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowControls;
	}
}

