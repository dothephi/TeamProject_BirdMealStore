namespace BirdMealStoreWinForm
{
	partial class frmLogin
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
			lbWellcome = new System.Windows.Forms.Label();
			lbPassword = new System.Windows.Forms.Label();
			lbEmail = new System.Windows.Forms.Label();
			txtEmail = new System.Windows.Forms.TextBox();
			txtPassword = new System.Windows.Forms.TextBox();
			btnReset = new System.Windows.Forms.Button();
			btnLogin = new System.Windows.Forms.Button();
			lbRegister = new System.Windows.Forms.LinkLabel();
			SuspendLayout();
			// 
			// lbWellcome
			// 
			lbWellcome.AutoSize = true;
			lbWellcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			lbWellcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			lbWellcome.Location = new System.Drawing.Point(201, 41);
			lbWellcome.Name = "lbWellcome";
			lbWellcome.Size = new System.Drawing.Size(148, 40);
			lbWellcome.TabIndex = 0;
			lbWellcome.Text = "Wellcome";
			// 
			// lbPassword
			// 
			lbPassword.AutoSize = true;
			lbPassword.Location = new System.Drawing.Point(61, 189);
			lbPassword.Name = "lbPassword";
			lbPassword.Size = new System.Drawing.Size(70, 20);
			lbPassword.TabIndex = 1;
			lbPassword.Text = "Password";
			// 
			// lbEmail
			// 
			lbEmail.AutoSize = true;
			lbEmail.Location = new System.Drawing.Point(61, 123);
			lbEmail.Name = "lbEmail";
			lbEmail.Size = new System.Drawing.Size(46, 20);
			lbEmail.TabIndex = 2;
			lbEmail.Text = "Email";
			// 
			// txtEmail
			// 
			txtEmail.Location = new System.Drawing.Point(171, 120);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new System.Drawing.Size(303, 27);
			txtEmail.TabIndex = 3;
			// 
			// txtPassword
			// 
			txtPassword.Location = new System.Drawing.Point(171, 186);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new System.Drawing.Size(303, 27);
			txtPassword.TabIndex = 4;
			// 
			// btnReset
			// 
			btnReset.Location = new System.Drawing.Point(380, 242);
			btnReset.Name = "btnReset";
			btnReset.Size = new System.Drawing.Size(94, 29);
			btnReset.TabIndex = 5;
			btnReset.Text = "Reset";
			btnReset.UseVisualStyleBackColor = true;
			btnReset.Click += btnReset_Click;
			// 
			// btnLogin
			// 
			btnLogin.Location = new System.Drawing.Point(171, 242);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new System.Drawing.Size(94, 29);
			btnLogin.TabIndex = 6;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// lbRegister
			// 
			lbRegister.AutoSize = true;
			lbRegister.Location = new System.Drawing.Point(61, 289);
			lbRegister.Name = "lbRegister";
			lbRegister.Size = new System.Drawing.Size(100, 20);
			lbRegister.TabIndex = 7;
			lbRegister.TabStop = true;
			lbRegister.Text = "Register here!";
			lbRegister.LinkClicked += lbRegister_LinkClicked;
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(539, 328);
			Controls.Add(lbRegister);
			Controls.Add(btnLogin);
			Controls.Add(btnReset);
			Controls.Add(txtPassword);
			Controls.Add(txtEmail);
			Controls.Add(lbEmail);
			Controls.Add(lbPassword);
			Controls.Add(lbWellcome);
			Name = "frmLogin";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Login Page";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label lbWellcome;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.LinkLabel lbRegister;
	}
}