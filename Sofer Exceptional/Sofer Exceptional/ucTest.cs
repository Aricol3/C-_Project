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
	public partial class ucTest : UserControl
	{
		private readonly Form2 _form2;
		System.Timers.Timer t;
		int m, s;
		public ucTest(Form2 form2)
		{
			InitializeComponent();

			_form2 = form2;

			prepQuestion();
			nextQuestion();

			txtQuestionsTrueNumber.Text = "0";
			txtQuestionsFalseNumber.Text = "0";

			//timer
			t = new System.Timers.Timer();
			t.Interval = 1000;
			t.Elapsed += OnTimeEvent;
			t.Start();
			//

		}

		//timer event
		private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
		{
			Invoke(new Action(() =>
			{
				s += 1;
				if (s == 60)
				{
					s = 0;
					m += 1;
				}
				lblTimer.Text = string.Format("{0}:{1}", (29 - m).ToString().PadLeft(2, '0'), (59 - s).ToString().PadLeft(2, '0'));
				if (m == 30 && s == 0)
				{
					if (questionsTrueNumber >= 22) testPassed = true;
					else testPassed = false;
					endTest();
				}
			}));
		}
		//


		//Questions related methods
		Queue<int> Questions = new Queue<int>();

		int idQ;
		int questionsTrueNumber = 0;
		int questionsFalseNumber = 0;
		int questionsLeftNumber = 26;
		bool testPassed;

		private void prepQuestion()
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AtestatInfo2022\Sofer Exceptional\Sofer Exceptional\Database1.mdf;Integrated Security=True");
			con.Open();
			string Query;
			Query = "SELECT COUNT(*) FROM tblChestionare";
			SqlCommand cmdCount = new SqlCommand(Query, con);
			int totalQuestions = (int)cmdCount.ExecuteScalar();
			con.Close();

			Random rnd = new Random();
			int number;
			while (Questions.Count() < 26)
			{
				number = rnd.Next(0, totalQuestions);
				if (!Questions.Contains(number)) Questions.Enqueue(number);
			}
		}

		private void nextQuestion()
		{
			if (Questions.Count() != 0)
			{
				SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AtestatInfo2022\Sofer Exceptional\Sofer Exceptional\Database1.mdf;Integrated Security=True");
				SqlDataAdapter sqa = new SqlDataAdapter("SELECT * FROM tblChestionare", con);
				DataTable dt = new DataTable();
				sqa.Fill(dt);

				idQ = Questions.Dequeue();
				txtQuestion.Text = dt.Rows[idQ]["Intrebare"].ToString();
				btnAnswerA.Text = dt.Rows[idQ]["VariantaA"].ToString();
				btnAnswerB.Text = dt.Rows[idQ]["VariantaB"].ToString();
				btnAnswerC.Text = dt.Rows[idQ]["VariantaC"].ToString();
			}
			else
			{
				testPassed = true;
				endTest();
			}
		}
		
		private void endTest()
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AtestatInfo2022\Sofer Exceptional\Sofer Exceptional\Database1.mdf;Integrated Security=True");
			SqlDataAdapter sqa = new SqlDataAdapter("SELECT * FROM tblLogin", con);
			DataTable dt = new DataTable();
			sqa.Fill(dt);

			GlobalVariables.testPassed = testPassed;
			GlobalVariables.questionsTrue = questionsTrueNumber;
			GlobalVariables.questionsFalse = questionsFalseNumber;

			string Query;
			con.Open();
			if (testPassed)
			{
				int TestsPassed = Int32.Parse(dt.Rows[GlobalVariables.idUser]["TestsPassed"].ToString());
				TestsPassed++;
				Query = "UPDATE tblLogin SET TestsPassed='" + TestsPassed + "' WHERE id=" + GlobalVariables.idUser;
				SqlCommand cmdPassed = new SqlCommand(Query, con);
				cmdPassed.ExecuteNonQuery();
				int time = m * 60 + s;
				int totalTestsPassed = Int32.Parse(dt.Rows[GlobalVariables.idUser]["TestsPassed"].ToString());
				int oldAverageTime = Int32.Parse(dt.Rows[GlobalVariables.idUser]["AverageTime"].ToString());
				int newAverageTime = (totalTestsPassed * oldAverageTime + time) / (totalTestsPassed + 1);
				Query = "UPDATE tblLogin SET AverageTime='" + newAverageTime + "' WHERE id=" + GlobalVariables.idUser;
				SqlCommand cmdUpdate = new SqlCommand(Query, con);
				cmdUpdate.ExecuteNonQuery();
			}
			else
			{
				int TestsFailed = Int32.Parse(dt.Rows[GlobalVariables.idUser]["TestsFailed"].ToString());
				TestsFailed++;
				Query = "UPDATE tblLogin SET TestsFailed='" + TestsFailed + "' WHERE id=" + GlobalVariables.idUser;
				SqlCommand cmdFailed = new SqlCommand(Query, con);
				cmdFailed.ExecuteNonQuery();
			}
			con.Close();
			_form2.closeTest();
			_form2.openTestResults();
		}

		private bool checkAnswer()
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AtestatInfo2022\Sofer Exceptional\Sofer Exceptional\Database1.mdf;Integrated Security=True");
			SqlDataAdapter sqa = new SqlDataAdapter("SELECT * FROM tblChestionare", con);
			DataTable dt = new DataTable();
			sqa.Fill(dt);

			if (dt.Rows[idQ]["RaspunsA"].Equals(clickedA) && dt.Rows[idQ]["RaspunsB"].Equals(clickedB) && dt.Rows[idQ]["RaspunsC"].Equals(clickedC)) return true;
			else return false;
		}
		//



		//Buttons related methods
		bool clickedA = false, clickedB = false, clickedC = false;

		private void btnSendAnswer_Click(object sender, EventArgs e)
		{
			if (checkAnswer())
			{
				questionsTrueNumber++;
				txtQuestionsTrueNumber.Text = questionsTrueNumber.ToString();
			}
			else
			{
				questionsFalseNumber++;
				txtQuestionsFalseNumber.Text = questionsFalseNumber.ToString();
			}

			if (questionsFalseNumber > 4)
			{
				testPassed = false;
				endTest();
			}

			questionsLeftNumber--;
			txtQuestionsLeftNumber.Text = questionsLeftNumber.ToString();

			unlockButtons();
			nextQuestion();
		}
		private void btnEraseAnswer_Click(object sender, EventArgs e)
		{
			unlockButtons();
		}

		private void btnQueueQuestion_Click(object sender, EventArgs e)
		{
			Questions.Enqueue(idQ);
			unlockButtons();
			nextQuestion();
		}

		private void unlockButtons()
		{
			btnAnswerA.Enabled = true;
			clickedA = false;
			btnAnswerB.Enabled = true;
			clickedB = false;
			btnAnswerC.Enabled = true;
			clickedC = false;
		}

		private void btnAnswerA_Click(object sender, EventArgs e)
		{
			btnAnswerA.Enabled = false;
			clickedA = true;
		}

		private void btnAnswerB_Click(object sender, EventArgs e)
		{
			btnAnswerB.Enabled = false;
			clickedB = true;
		}

		private void btnAnswerC_Click(object sender, EventArgs e)
		{
			btnAnswerC.Enabled = false;
			clickedC = true;
		}
	}
}
