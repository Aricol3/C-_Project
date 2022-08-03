
namespace Sofer_Exceptional
{
	partial class Form2
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlTest = new System.Windows.Forms.Panel();
			this.txtAverageTimeNumber = new System.Windows.Forms.Label();
			this.txtAverageTimeText = new System.Windows.Forms.Label();
			this.txtTestsFailedNumber = new System.Windows.Forms.Label();
			this.txtTestsPassedNumber = new System.Windows.Forms.Label();
			this.txtTestsFailedText = new System.Windows.Forms.Label();
			this.txtTestsPassedText = new System.Windows.Forms.Label();
			this.txtProfileName = new System.Windows.Forms.Label();
			this.btnTest = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.pnlMenuTop = new System.Windows.Forms.Panel();
			this.txtMenu = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.panel1.SuspendLayout();
			this.pnlMenuTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.pnlTest);
			this.panel1.Controls.Add(this.txtAverageTimeNumber);
			this.panel1.Controls.Add(this.txtAverageTimeText);
			this.panel1.Controls.Add(this.txtTestsFailedNumber);
			this.panel1.Controls.Add(this.txtTestsPassedNumber);
			this.panel1.Controls.Add(this.txtTestsFailedText);
			this.panel1.Controls.Add(this.txtTestsPassedText);
			this.panel1.Controls.Add(this.txtProfileName);
			this.panel1.Controls.Add(this.btnTest);
			this.panel1.Controls.Add(this.pnlMenuTop);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1210, 660);
			this.panel1.TabIndex = 0;
			// 
			// pnlTest
			// 
			this.pnlTest.Location = new System.Drawing.Point(1010, 560);
			this.pnlTest.Name = "pnlTest";
			this.pnlTest.Size = new System.Drawing.Size(200, 100);
			this.pnlTest.TabIndex = 14;
			// 
			// txtAverageTimeNumber
			// 
			this.txtAverageTimeNumber.AutoSize = true;
			this.txtAverageTimeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAverageTimeNumber.ForeColor = System.Drawing.Color.DimGray;
			this.txtAverageTimeNumber.Location = new System.Drawing.Point(288, 315);
			this.txtAverageTimeNumber.Name = "txtAverageTimeNumber";
			this.txtAverageTimeNumber.Size = new System.Drawing.Size(87, 31);
			this.txtAverageTimeNumber.TabIndex = 13;
			this.txtAverageTimeNumber.Text = "00:00";
			// 
			// txtAverageTimeText
			// 
			this.txtAverageTimeText.AutoSize = true;
			this.txtAverageTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAverageTimeText.ForeColor = System.Drawing.Color.DimGray;
			this.txtAverageTimeText.Location = new System.Drawing.Point(22, 313);
			this.txtAverageTimeText.Name = "txtAverageTimeText";
			this.txtAverageTimeText.Size = new System.Drawing.Size(273, 31);
			this.txtAverageTimeText.TabIndex = 12;
			this.txtAverageTimeText.Text = "Timp mediu de lucru -";
			// 
			// txtTestsFailedNumber
			// 
			this.txtTestsFailedNumber.AutoSize = true;
			this.txtTestsFailedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTestsFailedNumber.ForeColor = System.Drawing.Color.Crimson;
			this.txtTestsFailedNumber.Location = new System.Drawing.Point(224, 257);
			this.txtTestsFailedNumber.Name = "txtTestsFailedNumber";
			this.txtTestsFailedNumber.Size = new System.Drawing.Size(29, 31);
			this.txtTestsFailedNumber.TabIndex = 11;
			this.txtTestsFailedNumber.Text = "0";
			// 
			// txtTestsPassedNumber
			// 
			this.txtTestsPassedNumber.AutoSize = true;
			this.txtTestsPassedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTestsPassedNumber.ForeColor = System.Drawing.Color.LimeGreen;
			this.txtTestsPassedNumber.Location = new System.Drawing.Point(208, 196);
			this.txtTestsPassedNumber.Name = "txtTestsPassedNumber";
			this.txtTestsPassedNumber.Size = new System.Drawing.Size(29, 31);
			this.txtTestsPassedNumber.TabIndex = 10;
			this.txtTestsPassedNumber.Text = "0";
			// 
			// txtTestsFailedText
			// 
			this.txtTestsFailedText.AutoSize = true;
			this.txtTestsFailedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTestsFailedText.ForeColor = System.Drawing.Color.DimGray;
			this.txtTestsFailedText.Location = new System.Drawing.Point(18, 257);
			this.txtTestsFailedText.Name = "txtTestsFailedText";
			this.txtTestsFailedText.Size = new System.Drawing.Size(209, 31);
			this.txtTestsFailedText.TabIndex = 9;
			this.txtTestsFailedText.Text = "Teste respinse -";
			// 
			// txtTestsPassedText
			// 
			this.txtTestsPassedText.AutoSize = true;
			this.txtTestsPassedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTestsPassedText.ForeColor = System.Drawing.Color.DimGray;
			this.txtTestsPassedText.Location = new System.Drawing.Point(18, 196);
			this.txtTestsPassedText.Name = "txtTestsPassedText";
			this.txtTestsPassedText.Size = new System.Drawing.Size(193, 31);
			this.txtTestsPassedText.TabIndex = 8;
			this.txtTestsPassedText.Text = "Teste admise -";
			// 
			// txtProfileName
			// 
			this.txtProfileName.AutoSize = true;
			this.txtProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProfileName.ForeColor = System.Drawing.Color.DimGray;
			this.txtProfileName.Location = new System.Drawing.Point(16, 110);
			this.txtProfileName.Name = "txtProfileName";
			this.txtProfileName.Size = new System.Drawing.Size(148, 54);
			this.txtProfileName.TabIndex = 7;
			this.txtProfileName.Text = "Profil ";
			// 
			// btnTest
			// 
			this.btnTest.AllowToggling = false;
			this.btnTest.AnimationSpeed = 200;
			this.btnTest.AutoGenerateColors = false;
			this.btnTest.BackColor = System.Drawing.Color.Transparent;
			this.btnTest.BackColor1 = System.Drawing.Color.CornflowerBlue;
			this.btnTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTest.BackgroundImage")));
			this.btnTest.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnTest.ButtonText = "Incepe un nou test";
			this.btnTest.ButtonTextMarginLeft = 0;
			this.btnTest.ColorContrastOnClick = 45;
			this.btnTest.ColorContrastOnHover = 45;
			this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.btnTest.CustomizableEdges = borderEdges1;
			this.btnTest.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnTest.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnTest.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnTest.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnTest.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnTest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.btnTest.ForeColor = System.Drawing.Color.White;
			this.btnTest.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
			this.btnTest.IconMarginLeft = 11;
			this.btnTest.IconPadding = 10;
			this.btnTest.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.btnTest.IdleBorderColor = System.Drawing.Color.CornflowerBlue;
			this.btnTest.IdleBorderRadius = 10;
			this.btnTest.IdleBorderThickness = 1;
			this.btnTest.IdleFillColor = System.Drawing.Color.CornflowerBlue;
			this.btnTest.IdleIconLeftImage = null;
			this.btnTest.IdleIconRightImage = null;
			this.btnTest.IndicateFocus = false;
			this.btnTest.Location = new System.Drawing.Point(28, 375);
			this.btnTest.Name = "btnTest";
			stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties1.BorderRadius = 10;
			stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			stateProperties1.BorderThickness = 1;
			stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties1.ForeColor = System.Drawing.Color.White;
			stateProperties1.IconLeftImage = null;
			stateProperties1.IconRightImage = null;
			this.btnTest.onHoverState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties2.BorderRadius = 10;
			stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			stateProperties2.BorderThickness = 1;
			stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties2.ForeColor = System.Drawing.Color.White;
			stateProperties2.IconLeftImage = null;
			stateProperties2.IconRightImage = null;
			this.btnTest.OnPressedState = stateProperties2;
			this.btnTest.Size = new System.Drawing.Size(206, 67);
			this.btnTest.TabIndex = 6;
			this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnTest.TextMarginLeft = 0;
			this.btnTest.UseDefaultRadiusAndThickness = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// pnlMenuTop
			// 
			this.pnlMenuTop.BackColor = System.Drawing.Color.White;
			this.pnlMenuTop.Controls.Add(this.txtMenu);
			this.pnlMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMenuTop.Location = new System.Drawing.Point(0, 0);
			this.pnlMenuTop.Name = "pnlMenuTop";
			this.pnlMenuTop.Size = new System.Drawing.Size(1210, 85);
			this.pnlMenuTop.TabIndex = 5;
			// 
			// txtMenu
			// 
			this.txtMenu.AutoSize = true;
			this.txtMenu.BackColor = System.Drawing.Color.White;
			this.txtMenu.Cursor = System.Windows.Forms.Cursors.No;
			this.txtMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.txtMenu.Location = new System.Drawing.Point(3, 0);
			this.txtMenu.Name = "txtMenu";
			this.txtMenu.Size = new System.Drawing.Size(214, 76);
			this.txtMenu.TabIndex = 3;
			this.txtMenu.Text = "Meniu";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1210, 660);
			this.Controls.Add(this.panel1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnlMenuTop.ResumeLayout(false);
			this.pnlMenuTop.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlMenuTop;
		private Bunifu.Framework.UI.BunifuCustomLabel txtMenu;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTest;
		private System.Windows.Forms.Label txtProfileName;
		private System.Windows.Forms.Label txtTestsPassedText;
		private System.Windows.Forms.Label txtTestsPassedNumber;
		private System.Windows.Forms.Label txtTestsFailedText;
		private System.Windows.Forms.Label txtTestsFailedNumber;
		private System.Windows.Forms.Label txtAverageTimeNumber;
		private System.Windows.Forms.Label txtAverageTimeText;
		private System.Windows.Forms.Panel pnlTest;
	}
}