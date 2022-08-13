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
	public partial class ChangingForm : Form
	{
		methods m = new methods();
		public ChangingForm()
		{
			InitializeComponent();
		}

		private void ChangingForm_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			m.fillSystemsheet1(textBox1.Text, textBox2.Text, textBox3.Text);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text == "Смена")
			{
				m.fillDataSmena(textBox4.Text, textBox5.Text, textBox13.Text, textBox12.Text, textBox11.Text, textBox10.Text,
					textBox18.Text, textBox17.Text, textBox16.Text, textBox15.Text, textBox14.Text,
					textBox23.Text, textBox22.Text, textBox21.Text, textBox20.Text,
					textBox28.Text, textBox27.Text, textBox26.Text, textBox25.Text, textBox34.Text,
					textBox33.Text, textBox32.Text, textBox8.Text, textBox19.Text, textBox24.Text, textBox6.Text,
					textBox7.Text, textBox29.Text, textBox30.Text, textBox31.Text);
			}
			else
			{
				m.fillDataPerehod (textBox4.Text, textBox5.Text, textBox13.Text, textBox12.Text, textBox11.Text, textBox10.Text, textBox9.Text,
					textBox18.Text, textBox17.Text, textBox16.Text, textBox15.Text, textBox14.Text,
					textBox23.Text, textBox22.Text, textBox21.Text, textBox20.Text,
					textBox28.Text, textBox27.Text, textBox26.Text, textBox25.Text, textBox34.Text,
					textBox33.Text, textBox32.Text, textBox8.Text, textBox19.Text, textBox24.Text, textBox6.Text,
					textBox7.Text, textBox29.Text, textBox30.Text, textBox31.Text);
			}
		}
	}
}
