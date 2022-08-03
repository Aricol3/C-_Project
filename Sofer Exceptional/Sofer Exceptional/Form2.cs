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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();

			showProfile();

			pnlTest.Visible = false;
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		public void showProfile()
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AtestatInfo2022\Sofer Exceptional\Sofer Exceptional\Database1.mdf;Integrated Security=True");
			SqlDataAdapter sqa = new SqlDataAdapter("SELECT * FROM tblLogin", con);
			DataTable dt = new DataTable();
			sqa.Fill(dt);

			txtProfileName.Text = "Profil " + dt.Rows[GlobalVariables.idUser]["Username"].ToString();
			txtTestsPassedNumber.Text = dt.Rows[GlobalVariables.idUser]["TestsPassed"].ToString();
			txtTestsFailedNumber.Text = dt.Rows[GlobalVariables.idUser]["TestsFailed"].ToString();

			int m, s;
			s = Int32.Parse(dt.Rows[GlobalVariables.idUser]["AverageTime"].ToString());
			m = s / 60;
			s = s % 60;
			txtAverageTimeNumber.Text = string.Format("{0}:{1}", (m).ToString().PadLeft(2, '0'), (s).ToString().PadLeft(2, '0'));
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			openTest();
		}

		public void openTest()
		{
			pnlMenuTop.Dock = DockStyle.None;
			ucTest openTest = new ucTest(this);
			pnlTest.Controls.Add(openTest);
			pnlTest.Dock = DockStyle.Fill;
			openTest.Dock = DockStyle.Fill;
			pnlTest.Visible = true;
			pnlTest.BringToFront();
		}

		public void closeTest()
		{
			pnlMenuTop.Dock = DockStyle.Top;
			pnlTest.Controls.Clear();
			pnlTest.Visible = false;
		}

		public void openTestResults()
		{
			pnlMenuTop.Dock = DockStyle.None;
			ucTestResults openTestResults = new ucTestResults(this,GlobalVariables.testPassed,GlobalVariables.questionsTrue,GlobalVariables.questionsFalse);
			pnlTest.Controls.Add(openTestResults);
			pnlTest.Dock = DockStyle.Fill;
			openTestResults.Dock = DockStyle.Fill;
			pnlTest.Visible = true;
			pnlTest.BringToFront();
		}

		public void closeTestResults()
		{
			pnlMenuTop.Dock = DockStyle.Top;
			pnlTest.Controls.Clear();
			pnlTest.Visible = false;
		}
	}
}
