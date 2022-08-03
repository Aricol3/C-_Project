using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Sofer_Exceptional
{
	public partial class Form1 : Form
	{
		private readonly Form3 _form3;
		public Form1(Form3 form3)
		{
			InitializeComponent();

			_form3 = form3;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void LoginCheck()
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AtestatInfo2022\Sofer Exceptional\Sofer Exceptional\Database1.mdf;Integrated Security=True");
			SqlDataAdapter sqa = new SqlDataAdapter("SELECT * FROM tblLogin", con);
			DataTable dt = new DataTable();
			sqa.Fill(dt);

			con.Open();
			string Query = "SELECT COUNT(*) FROM tblLogin";
			SqlCommand cmdCount = new SqlCommand(Query, con);
			int totalUsers = (int)cmdCount.ExecuteScalar();
			con.Close();

			bool ok = false;
			for (int user = 0; user < totalUsers; user++)
			{
				if (dt.Rows[user]["Username"].ToString() == txtUsername.Text.ToString())
				{
					if (dt.Rows[user]["Password"].ToString() == txtPassword.Text.ToString())
					{
						GlobalVariables.idUser = user;
						ok = true;
						break;
					}
				}
			}

			if (ok == true)
			{
				this.Close();
				_form3.openTest();
			}
			else MessageBox.Show("Utilizator sau parola incorecta");
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			LoginCheck();
		}

		private void txtUserEnter(object sender, EventArgs e)
		{
			if (txtUsername.Text.Equals(@"Username"))
			{
				txtUsername.Text = "";
			}
		}

		private void txtUserLeave(object sender, EventArgs e)
		{
			if (txtUsername.Text.Equals(""))
			{
				txtUsername.Text = @"Username";
			}
		}

		private void txtPasswordEnter(object sender, EventArgs e)
		{
			if (txtPassword.Text.Equals("Password"))
			{
				txtPassword.Text = "";
			}
		}

		private void txtPasswordLeave(object sender, EventArgs e)
		{
			if (txtPassword.Text.Equals(""))
			{
				txtPassword.Text = "Password";
			}
		}

		private void txtUsername_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SelectNextControl(ActiveControl, true, true, true, true);
				e.SuppressKeyPress = true;
			}
		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				LoginCheck();
				e.SuppressKeyPress = true;
			}
		}

		private void btnNewUser_Click(object sender, EventArgs e)
		{
			ucNewUser newUser1 = new ucNewUser();
			pnlLogin.Controls.Add(newUser1);
			newUser1.Dock = DockStyle.Fill;
			newUser1.BringToFront();
		}
	}
}
