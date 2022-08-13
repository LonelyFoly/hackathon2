using System;
using System.Collections.Generic;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using System.IO;
using Google.Apis.Sheets.v4.Data;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Windows.Forms;
using System.Drawing;

namespace Ya_ustal
{
	public partial class ReadingForm : Form
	{
		List<CheckBox> check_list;
		List<Action> requests = new List<Action>();
		methods m = new methods();
		public ReadingForm()
		{
			InitializeComponent();
		}

		private void ReadingForm_Load(object sender, EventArgs e)
		{
			check_list = new List<CheckBox>() { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7 };
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (check_list[0].Checked) m.Request1(textBox1.Text);
			if (check_list[1].Checked) m.Request2(textBox1.Text);
			if (textBox2.Text != "")
			{
				string ion = textBox2.Text.Substring(0, 2);
				string iso = textBox2.Text.Substring(2);
				if (check_list[2].Checked) m.Request3(ion, iso, textBox3.Text);
				if (check_list[3].Checked) m.Request4(ion);
				if (check_list[4].Checked) m.Request5(ion);
			}
			if (check_list[5].Checked) m.Request6();
			if (check_list[6].Checked) m.Request7();
		}
	}
}
