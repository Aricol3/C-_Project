using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sofer_Exceptional
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();

			this.MinimumSize= new Size(1200, 690);

			openLogin();
		}

		public void openLogin()
		{
			Form1 openLogin = new Form1(this);
			openLogin.FormBorderStyle = FormBorderStyle.None;
			openLogin.TopLevel = false;
			openLogin.AutoScroll = true;
			this.Controls.Add(openLogin);
			openLogin.Dock = DockStyle.Fill;
			openLogin.Show();
			openLogin.BringToFront();
		}

		public void openTest()
		{
			Form2 openTest = new Form2();
			openTest.FormBorderStyle = FormBorderStyle.None;
			openTest.TopLevel = false;
			openTest.AutoScroll = true;
			this.Controls.Add(openTest);
			openTest.Dock = DockStyle.Fill;
			openTest.Show();
			openTest.BringToFront();
		}
		
	}
}
