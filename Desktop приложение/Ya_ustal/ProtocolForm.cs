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
	public partial class ProtocolForm : Form
	{
		methods m = new methods();
		public ProtocolForm()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			m.GenPDFSeances(textBox2.Text);
		}

		private void ProtocolForm_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			m.GenPDFTransitions(textBox3.Text);
		}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
