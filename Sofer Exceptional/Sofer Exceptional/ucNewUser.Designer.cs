
namespace Sofer_Exceptional
{
	partial class ucNewUser
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
			this.txtSignup = new System.Windows.Forms.Label();
			this.txtPasswordSignup = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txtUsernameSignup = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.btnSignup = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSignup
			// 
			this.txtSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtSignup.AutoSize = true;
			this.txtSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSignup.ForeColor = System.Drawing.Color.DimGray;
			this.txtSignup.Location = new System.Drawing.Point(408, 175);
			this.txtSignup.Name = "txtSignup";
			this.txtSignup.Size = new System.Drawing.Size(167, 31);
			this.txtSignup.TabIndex = 10;
			this.txtSignup.Text = "Creare cont";
			// 
			// txtPasswordSignup
			// 
			this.txtPasswordSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPasswordSignup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txtPasswordSignup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txtPasswordSignup.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPasswordSignup.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPasswordSignup.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtPasswordSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPasswordSignup.HintForeColor = System.Drawing.Color.Empty;
			this.txtPasswordSignup.HintText = "";
			this.txtPasswordSignup.isPassword = true;
			this.txtPasswordSignup.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
			this.txtPasswordSignup.LineIdleColor = System.Drawing.Color.Gray;
			this.txtPasswordSignup.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
			this.txtPasswordSignup.LineThickness = 3;
			this.txtPasswordSignup.Location = new System.Drawing.Point(285, 291);
			this.txtPasswordSignup.Margin = new System.Windows.Forms.Padding(4);
			this.txtPasswordSignup.MaxLength = 32767;
			this.txtPasswordSignup.Name = "txtPasswordSignup";
			this.txtPasswordSignup.Size = new System.Drawing.Size(417, 37);
			this.txtPasswordSignup.TabIndex = 9;
			this.txtPasswordSignup.Text = "Password";
			this.txtPasswordSignup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPasswordSignup.Enter += new System.EventHandler(this.txtPasswordEnter);
			this.txtPasswordSignup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			this.txtPasswordSignup.Leave += new System.EventHandler(this.txtPasswordLeave);
			// 
			// txtUsernameSignup
			// 
			this.txtUsernameSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUsernameSignup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txtUsernameSignup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txtUsernameSignup.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtUsernameSignup.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUsernameSignup.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtUsernameSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtUsernameSignup.HintForeColor = System.Drawing.Color.Empty;
			this.txtUsernameSignup.HintText = "";
			this.txtUsernameSignup.isPassword = false;
			this.txtUsernameSignup.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
			this.txtUsernameSignup.LineIdleColor = System.Drawing.Color.Gray;
			this.txtUsernameSignup.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
			this.txtUsernameSignup.LineThickness = 3;
			this.txtUsernameSignup.Location = new System.Drawing.Point(285, 233);
			this.txtUsernameSignup.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsernameSignup.MaxLength = 32767;
			this.txtUsernameSignup.Name = "txtUsernameSignup";
			this.txtUsernameSignup.Size = new System.Drawing.Size(417, 40);
			this.txtUsernameSignup.TabIndex = 8;
			this.txtUsernameSignup.Text = "Username";
			this.txtUsernameSignup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtUsernameSignup.Enter += new System.EventHandler(this.txtUserEnter);
			this.txtUsernameSignup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
			this.txtUsernameSignup.Leave += new System.EventHandler(this.txtUserLeave);
			// 
			// btnSignup
			// 
			this.btnSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSignup.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnSignup.FlatAppearance.BorderSize = 0;
			this.btnSignup.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSignup.Location = new System.Drawing.Point(405, 375);
			this.btnSignup.Name = "btnSignup";
			this.btnSignup.Size = new System.Drawing.Size(176, 60);
			this.btnSignup.TabIndex = 7;
			this.btnSignup.Text = "Sign Up";
			this.btnSignup.UseVisualStyleBackColor = false;
			this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = global::Sofer_Exceptional.Properties.Resources.GoogleProfilePicture;
			this.pictureBox1.Location = new System.Drawing.Point(388, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(215, 165);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// ucNewUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.txtSignup);
			this.Controls.Add(this.txtPasswordSignup);
			this.Controls.Add(this.txtUsernameSignup);
			this.Controls.Add(this.btnSignup);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ucNewUser";
			this.Size = new System.Drawing.Size(1011, 504);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label txtSignup;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtPasswordSignup;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsernameSignup;
		private System.Windows.Forms.Button btnSignup;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
