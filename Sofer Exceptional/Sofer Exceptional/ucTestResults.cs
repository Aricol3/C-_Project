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
	public partial class ucTestResults : UserControl
	{
		private readonly Form2 _form2;
		public ucTestResults(Form2 form2, bool testPassed, int questionsTrue, int questionsFalse)
		{
			InitializeComponent();

			_form2 = form2;

			if (testPassed)
			{
				txtTestPassed.Text = "ADMIS";
				txtTestPassed.ForeColor = Color.LimeGreen;
			}
			else
			{
				txtTestPassed.Text = "RESPINS";
				txtTestPassed.ForeColor = Color.Crimson;
			}

			txtQuestionsTrueNumber.Text = questionsTrue.ToString();
			txtQuestionsFalseNumber.Text = questionsFalse.ToString();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			_form2.closeTestResults();
			_form2.showProfile();
		}
	}
}
