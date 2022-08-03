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
	public partial class ucNewUser : UserControl
	{
		public ucNewUser()
		{
			InitializeComponent();
		}

		private void Signup()
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AtestatInfo2022\Sofer Exceptional\Sofer Exceptional\Database1.mdf;Integrated Security=True");
			SqlDataAdapter sqa = new SqlDataAdapter("SELECT * FROM tblLogin", con);
			DataTable dt = new DataTable();
			sqa.Fill(dt);

			con.Open();
			string Query;
			Query = "SELECT COUNT(*) FROM tblLogin";
			SqlCommand cmdCount = new SqlCommand(Query, con);
			int totalUsers = (int)cmdCount.ExecuteScalar();

			bool newUser = true;
			for(int user = 0; user < totalUsers; user++)
			{
				if (dt.Rows[user]["Username"].ToString() == txtUsernameSignup.Text) newUser = false;
			}

			if (newUser)
			{
				Query = "INSERT INTO tblLogin(id, Username, Password) VALUES ('" + totalUsers + "','" + txtUsernameSignup.Text + "','" + txtPasswordSignup.Text + "')";
				SqlCommand cmdInsert = new SqlCommand(Query, con);
				cmdInsert.ExecuteNonQuery();

				Query = "UPDATE tblLogin SET TestsPassed = '0', TestsFailed='0', AverageTime='0' Where id =" + totalUsers;
				SqlCommand cmdUpdate = new SqlCommand(Query, con);
				cmdUpdate.ExecuteNonQuery();
				this.Hide();
			}
			else MessageBox.Show("Acest username este folosit deja!");
			con.Close();
		}

		private void txtUserEnter(object sender, EventArgs e)
		{
			if (txtUsernameSignup.Text.Equals(@"Username"))
			{
				txtUsernameSignup.Text = "";
			}
		}

		private void txtUserLeave(object sender, EventArgs e)
		{
			if (txtUsernameSignup.Text.Equals(""))
			{
				txtUsernameSignup.Text = @"Username";
			}
		}
		private void txtPasswordEnter(object sender, EventArgs e)
		{
			if (txtPasswordSignup.Text.Equals("Password"))
			{
				txtPasswordSignup.Text = "";
			}
		}

		private void txtPasswordLeave(object sender, EventArgs e)
		{
			if (txtPasswordSignup.Text.Equals(""))
			{
				txtPasswordSignup.Text = "Password";
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
				Signup();
				e.SuppressKeyPress = true;
			}
		}

		private void btnSignup_Click(object sender, EventArgs e)
		{
			Signup();
		}
	}
}
