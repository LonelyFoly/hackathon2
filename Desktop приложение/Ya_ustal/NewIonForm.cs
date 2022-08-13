using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ya_ustal
{
	public partial class NewIonForm : Form
	{
		methods m = new methods();
		public NewIonForm()
		{
			InitializeComponent();
		}

		private void NewIonForm_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			m.fillIonInfo(textBox18.Text, textBox17.Text, textBox15.Text, textBox16.Text, textBox14.Text, textBox23.Text, textBox22.Text, textBox21.Text, textBox20.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
		}
	}
}
