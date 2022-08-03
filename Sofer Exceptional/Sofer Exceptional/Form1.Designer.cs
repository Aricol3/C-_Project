
namespace Sofer_Exceptional
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.pnlLogin = new System.Windows.Forms.Panel();
			this.btnNewUser = new System.Windows.Forms.Label();
			this.txtLogin = new System.Windows.Forms.Label();
			this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnlLoginTop = new System.Windows.Forms.Panel();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.pnlLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlLogin
			// 
			this.pnlLogin.AllowDrop = true;
			this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlLogin.BackColor = System.Drawing.Color.White;
			this.pnlLogin.Controls.Add(this.btnNewUser);
			this.pnlLogin.Controls.Add(this.txtLogin);
			this.pnlLogin.Controls.Add(this.txtPassword);
			this.pnlLogin.Controls.Add(this.txtUsername);
			this.pnlLogin.Controls.Add(this.btnLogin);
			this.pnlLogin.Controls.Add(this.pictureBox1);
			this.pnlLogin.Location = new System.Drawing.Point(86, 70);
			this.pnlLogin.Name = "pnlLogin";
			this.pnlLogin.Size = new System.Drawing.Size(1011, 505);
			this.pnlLogin.TabIndex = 0;
			// 
			// btnNewUser
			// 
			this.btnNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnNewUser.AutoSize = true;
			this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewUser.ForeColor = System.Drawing.Color.DimGray;
			this.btnNewUser.Location = new System.Drawing.Point(418, 456);
			this.btnNewUser.Name = "btnNewUser";
			this.btnNewUser.Size = new System.Drawing.Size(151, 20);
			this.btnNewUser.TabIndex = 6;
			this.btnNewUser.Text = "Creeaza cont nou";
			this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
			// 
			// txtLogin
			// 
			this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtLogin.AutoSize = true;
			this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLogin.ForeColor = System.Drawing.Color.DimGray;
			this.txtLogin.Location = new System.Drawing.Point(408, 175);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(179, 31);
			this.txtLogin.TabIndex = 5;
			this.txtLogin.Text = "Autentificare";
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
			this.txtPassword.HintText = "";
			this.txtPassword.isPassword = true;
			this.txtPassword.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
			this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
			this.txtPassword.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
			this.txtPassword.LineThickness = 3;
			this.txtPassword.Location = new System.Drawing.Point(285, 291);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtPassword.MaxLength = 32767;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(417, 37);
			this.txtPassword.TabIndex = 4;
			this.txtPassword.Text = "Password";
			this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPassword.Enter += new System.EventHandler(this.txtPasswordEnter);
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			this.txtPassword.Leave += new System.EventHandler(this.txtPasswordLeave);
			// 
			// txtUsername
			// 
			this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txtUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
			this.txtUsername.HintText = "";
			this.txtUsername.isPassword = false;
			this.txtUsername.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
			this.txtUsername.LineIdleColor = System.Drawing.Color.Gray;
			this.txtUsername.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
			this.txtUsername.LineThickness = 3;
			this.txtUsername.Location = new System.Drawing.Point(285, 233);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsername.MaxLength = 32767;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(417, 40);
			this.txtUsername.TabIndex = 3;
			this.txtUsername.Text = "Username";
			this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtUsername.Enter += new System.EventHandler(this.txtUserEnter);
			this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
			this.txtUsername.Leave += new System.EventHandler(this.txtUserLeave);
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLogin.Location = new System.Drawing.Point(405, 375);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(176, 60);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Log In";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = global::Sofer_Exceptional.Properties.Resources.GoogleProfilePicture;
			this.pictureBox1.Location = new System.Drawing.Point(388, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(215, 165);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pnlLoginTop
			// 
			this.pnlLoginTop.BackColor = System.Drawing.Color.CornflowerBlue;
			this.pnlLoginTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlLoginTop.Location = new System.Drawing.Point(0, 0);
			this.pnlLoginTop.Name = "pnlLoginTop";
			this.pnlLoginTop.Size = new System.Drawing.Size(1184, 242);
			this.pnlLoginTop.TabIndex = 0;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 651);
			this.Controls.Add(this.pnlLogin);
			this.Controls.Add(this.pnlLoginTop);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlLogin.ResumeLayout(false);
			this.pnlLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlLogin;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pnlLoginTop;
		private System.Windows.Forms.Button btnLogin;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Label txtLogin;
		private System.Windows.Forms.Label btnNewUser;
	}
}

