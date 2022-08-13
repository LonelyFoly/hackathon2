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
    partial class Form1 : Form
    {
		Button currentButton;
		System.Drawing.Color lightColor = System.Drawing.Color.FromArgb(142, 228, 175);
		System.Drawing.Color darkColor = System.Drawing.Color.FromArgb(5, 56, 107);
		Form activeForm;
		ChangingForm сhangingForm;
		ReadingForm readingForm;
		ProtocolForm protocolForm;
		NewIonForm newIonForm;

		public Form1()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e) // вкладка чтение
		{
			OpenChildForm(readingForm, sender);
		}	

		private void ClickedButton(object buttonSender)
		{
			if (buttonSender != null)
			{
				if (currentButton != (Button)buttonSender)
				{
					DisableButton();
					currentButton = (Button)buttonSender;
					currentButton.BackColor = lightColor;
					currentButton.ForeColor = darkColor;
				}
			}
		}

		private void DisableButton()
		{
			foreach (Control button in panel1.Controls)
			{
				if (button.GetType() == typeof(Button))
				{
					button.BackColor = darkColor;
					button.ForeColor = lightColor;
				}
			}
		}

		private void OpenChildForm(Form childForm, object btnSender)
		{
			ClickedButton(btnSender);
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panel2.Controls.Add(childForm);
			this.panel2.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void Form1_Load(object sender, EventArgs e)
        {
			сhangingForm = new ChangingForm();
			readingForm = new ReadingForm();
			protocolForm = new ProtocolForm();
			newIonForm = new NewIonForm();
			this.WindowState = FormWindowState.Maximized;

			activeForm = new ReadingForm();
			activeForm.TopLevel = false;
			activeForm.FormBorderStyle = FormBorderStyle.None;
			activeForm.Dock = DockStyle.Fill;
			this.panel2.Controls.Add(activeForm);
			this.panel2.Tag = activeForm;
			activeForm.BringToFront();
			activeForm.Show();
		}

		private void button2_Click(object sender, EventArgs e) //вкладка добавление
		{
			OpenChildForm(сhangingForm, sender);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			OpenChildForm(protocolForm, sender);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			OpenChildForm(newIonForm, sender);
		}
	}
}
