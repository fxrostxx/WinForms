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
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.CheckBoxShowDate = new System.Windows.Forms.CheckBox();
			this.CheckBoxShowWeekday = new System.Windows.Forms.CheckBox();
			this.ButtonHideControls = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TimeLabel
			// 
			this.TimeLabel.AutoSize = true;
			this.TimeLabel.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TimeLabel.Location = new System.Drawing.Point(12, 9);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(315, 60);
			this.TimeLabel.TabIndex = 0;
			this.TimeLabel.Text = "CurrentTime";
			// 
			// Timer
			// 
			this.Timer.Enabled = true;
			this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// CheckBoxShowDate
			// 
			this.CheckBoxShowDate.AutoSize = true;
			this.CheckBoxShowDate.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CheckBoxShowDate.Location = new System.Drawing.Point(22, 149);
			this.CheckBoxShowDate.Name = "CheckBoxShowDate";
			this.CheckBoxShowDate.Size = new System.Drawing.Size(167, 36);
			this.CheckBoxShowDate.TabIndex = 1;
			this.CheckBoxShowDate.Text = "Show date";
			this.CheckBoxShowDate.UseVisualStyleBackColor = true;
			// 
			// CheckBoxShowWeekday
			// 
			this.CheckBoxShowWeekday.AutoSize = true;
			this.CheckBoxShowWeekday.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CheckBoxShowWeekday.Location = new System.Drawing.Point(22, 191);
			this.CheckBoxShowWeekday.Name = "CheckBoxShowWeekday";
			this.CheckBoxShowWeekday.Size = new System.Drawing.Size(220, 36);
			this.CheckBoxShowWeekday.TabIndex = 2;
			this.CheckBoxShowWeekday.Text = "Show weekday";
			this.CheckBoxShowWeekday.UseVisualStyleBackColor = true;
			// 
			// ButtonHideControls
			// 
			this.ButtonHideControls.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ButtonHideControls.Location = new System.Drawing.Point(12, 367);
			this.ButtonHideControls.Name = "ButtonHideControls";
			this.ButtonHideControls.Size = new System.Drawing.Size(100, 54);
			this.ButtonHideControls.TabIndex = 3;
			this.ButtonHideControls.Text = "Hide controls";
			this.ButtonHideControls.UseVisualStyleBackColor = true;
			this.ButtonHideControls.Click += new System.EventHandler(this.ButtonHideControls_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 433);
			this.Controls.Add(this.ButtonHideControls);
			this.Controls.Add(this.CheckBoxShowWeekday);
			this.Controls.Add(this.CheckBoxShowDate);
			this.Controls.Add(this.TimeLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Clock";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TimeLabel;
		private System.Windows.Forms.Timer Timer;
		private System.Windows.Forms.CheckBox CheckBoxShowDate;
		private System.Windows.Forms.CheckBox CheckBoxShowWeekday;
		private System.Windows.Forms.Button ButtonHideControls;
	}
}

