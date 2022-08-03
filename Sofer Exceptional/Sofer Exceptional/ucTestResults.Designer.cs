
namespace Sofer_Exceptional
{
	partial class ucTestResults
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtTestPassed = new System.Windows.Forms.Label();
			this.txtQuestionsTrueText = new System.Windows.Forms.Label();
			this.txtQuestionsTrueNumber = new System.Windows.Forms.Label();
			this.txtQuestionsFalseNumber = new System.Windows.Forms.Label();
			this.txtQuestionsFalseText = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtTestPassed
			// 
			this.txtTestPassed.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTestPassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTestPassed.ForeColor = System.Drawing.Color.LimeGreen;
			this.txtTestPassed.Location = new System.Drawing.Point(0, 180);
			this.txtTestPassed.Name = "txtTestPassed";
			this.txtTestPassed.Size = new System.Drawing.Size(1181, 119);
			this.txtTestPassed.TabIndex = 0;
			this.txtTestPassed.Text = "Admis";
			this.txtTestPassed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtQuestionsTrueText
			// 
			this.txtQuestionsTrueText.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtQuestionsTrueText.AutoSize = true;
			this.txtQuestionsTrueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuestionsTrueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.txtQuestionsTrueText.Location = new System.Drawing.Point(365, 329);
			this.txtQuestionsTrueText.Name = "txtQuestionsTrueText";
			this.txtQuestionsTrueText.Size = new System.Drawing.Size(412, 39);
			this.txtQuestionsTrueText.TabIndex = 1;
			this.txtQuestionsTrueText.Text = "Intrebari raspunse corect -";
			// 
			// txtQuestionsTrueNumber
			// 
			this.txtQuestionsTrueNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtQuestionsTrueNumber.AutoSize = true;
			this.txtQuestionsTrueNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuestionsTrueNumber.ForeColor = System.Drawing.Color.LimeGreen;
			this.txtQuestionsTrueNumber.Location = new System.Drawing.Point(774, 329);
			this.txtQuestionsTrueNumber.Name = "txtQuestionsTrueNumber";
			this.txtQuestionsTrueNumber.Size = new System.Drawing.Size(55, 39);
			this.txtQuestionsTrueNumber.TabIndex = 2;
			this.txtQuestionsTrueNumber.Text = "26";
			// 
			// txtQuestionsFalseNumber
			// 
			this.txtQuestionsFalseNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtQuestionsFalseNumber.AutoSize = true;
			this.txtQuestionsFalseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuestionsFalseNumber.ForeColor = System.Drawing.Color.Crimson;
			this.txtQuestionsFalseNumber.Location = new System.Drawing.Point(765, 377);
			this.txtQuestionsFalseNumber.Name = "txtQuestionsFalseNumber";
			this.txtQuestionsFalseNumber.Size = new System.Drawing.Size(36, 39);
			this.txtQuestionsFalseNumber.TabIndex = 4;
			this.txtQuestionsFalseNumber.Text = "0";
			// 
			// txtQuestionsFalseText
			// 
			this.txtQuestionsFalseText.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtQuestionsFalseText.AutoSize = true;
			this.txtQuestionsFalseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuestionsFalseText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.txtQuestionsFalseText.Location = new System.Drawing.Point(365, 377);
			this.txtQuestionsFalseText.Name = "txtQuestionsFalseText";
			this.txtQuestionsFalseText.Size = new System.Drawing.Size(403, 39);
			this.txtQuestionsFalseText.TabIndex = 3;
			this.txtQuestionsFalseText.Text = "Intrebari raspunse gresit -";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(508, 487);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(166, 74);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// ucTestResults
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtQuestionsFalseNumber);
			this.Controls.Add(this.txtQuestionsFalseText);
			this.Controls.Add(this.txtQuestionsTrueNumber);
			this.Controls.Add(this.txtQuestionsTrueText);
			this.Controls.Add(this.txtTestPassed);
			this.Name = "ucTestResults";
			this.Size = new System.Drawing.Size(1181, 705);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label txtTestPassed;
		private System.Windows.Forms.Label txtQuestionsTrueText;
		private System.Windows.Forms.Label txtQuestionsTrueNumber;
		private System.Windows.Forms.Label txtQuestionsFalseNumber;
		private System.Windows.Forms.Label txtQuestionsFalseText;
		private System.Windows.Forms.Button btnOK;
	}
}
