using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Clock
{
	public partial class FontDialog : Form
	{
		public Font Font { get; set; }
		int lastChosenIndex;
		public FontDialog()
		{
			InitializeComponent();
			lastChosenIndex = 0;
			LoadFonts("*.otf");
			LoadFonts("*.ttf");
			comboBoxFont.SelectedIndex = lastChosenIndex;
		}
		private void FontDialog_Load(object sender, EventArgs e)
		{
			numericUpDownFontSize.Value = (decimal)Font.Size;
		}
		void LoadFonts(string extension)
		{
			string currentDir = Application.StartupPath;
			Directory.SetCurrentDirectory($"{currentDir}\\..\\..\\Fonts");
			//MessageBox.Show
			//	(
			//	this,
			//	Directory.GetCurrentDirectory(),
			//	"Select folder",
			//	MessageBoxButtons.OK,
			//	MessageBoxIcon.Information
			//	);
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), extension);
			for (int i = 0; i < files.Length; ++i) comboBoxFont.Items.Add(files[i].Split('\\').Last());
		}
		private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetFont();
		}
		void SetFont()
		{
			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile(comboBoxFont.SelectedItem.ToString());
			labelExample.Font = new Font(pfc.Families[0], (float)numericUpDownFontSize.Value);
		}
		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.Font = labelExample.Font;
			this.lastChosenIndex = comboBoxFont.SelectedIndex;
		}
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			labelExample.Font = this.Font;
			comboBoxFont.SelectedIndex = lastChosenIndex;
		}
		private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
		{
			SetFont();
		}
	}
}
