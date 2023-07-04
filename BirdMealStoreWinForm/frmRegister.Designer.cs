namespace BirdMealStoreWinForm
{
	partial class frmRegister
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
			lbRegistEmail = new System.Windows.Forms.Label();
			lbRegistName = new System.Windows.Forms.Label();
			lbRegistPassword = new System.Windows.Forms.Label();
			lbRegistBirthday = new System.Windows.Forms.Label();
			lbRegistAddress = new System.Windows.Forms.Label();
			lbRegistPhone = new System.Windows.Forms.Label();
			txtRegistEmail = new System.Windows.Forms.TextBox();
			txtRegistAddress = new System.Windows.Forms.TextBox();
			txtRegistName = new System.Windows.Forms.TextBox();
			txtRegistPassword = new System.Windows.Forms.TextBox();
			txtRegistPhone = new System.Windows.Forms.TextBox();
			txtRegistBirthday = new System.Windows.Forms.DateTimePicker();
			txtRegistPasswordConfi = new System.Windows.Forms.TextBox();
			lbRegistPasswordConfi = new System.Windows.Forms.Label();
			btnRegister = new System.Windows.Forms.Button();
			btnRegistReset = new System.Windows.Forms.Button();
			btnRegistCancel = new System.Windows.Forms.Button();
			lbInfor = new System.Windows.Forms.Label();
			SuspendLayout();
			// 
			// lbRegistEmail
			// 
			lbRegistEmail.AutoSize = true;
			lbRegistEmail.Location = new System.Drawing.Point(62, 96);
			lbRegistEmail.Name = "lbRegistEmail";
			lbRegistEmail.Size = new System.Drawing.Size(46, 20);
			lbRegistEmail.TabIndex = 0;
			lbRegistEmail.Text = "Email";
			// 
			// lbRegistName
			// 
			lbRegistName.AutoSize = true;
			lbRegistName.Location = new System.Drawing.Point(62, 250);
			lbRegistName.Name = "lbRegistName";
			lbRegistName.Size = new System.Drawing.Size(49, 20);
			lbRegistName.TabIndex = 1;
			lbRegistName.Text = "Name";
			// 
			// lbRegistPassword
			// 
			lbRegistPassword.AutoSize = true;
			lbRegistPassword.Location = new System.Drawing.Point(62, 145);
			lbRegistPassword.Name = "lbRegistPassword";
			lbRegistPassword.Size = new System.Drawing.Size(70, 20);
			lbRegistPassword.TabIndex = 2;
			lbRegistPassword.Text = "Password";
			// 
			// lbRegistBirthday
			// 
			lbRegistBirthday.AutoSize = true;
			lbRegistBirthday.Location = new System.Drawing.Point(62, 357);
			lbRegistBirthday.Name = "lbRegistBirthday";
			lbRegistBirthday.Size = new System.Drawing.Size(64, 20);
			lbRegistBirthday.TabIndex = 3;
			lbRegistBirthday.Text = "Birthday";
			// 
			// lbRegistAddress
			// 
			lbRegistAddress.AutoSize = true;
			lbRegistAddress.Location = new System.Drawing.Point(62, 305);
			lbRegistAddress.Name = "lbRegistAddress";
			lbRegistAddress.Size = new System.Drawing.Size(62, 20);
			lbRegistAddress.TabIndex = 4;
			lbRegistAddress.Text = "Address";
			// 
			// lbRegistPhone
			// 
			lbRegistPhone.AutoSize = true;
			lbRegistPhone.Location = new System.Drawing.Point(62, 413);
			lbRegistPhone.Name = "lbRegistPhone";
			lbRegistPhone.Size = new System.Drawing.Size(50, 20);
			lbRegistPhone.TabIndex = 5;
			lbRegistPhone.Text = "Phone";
			// 
			// txtRegistEmail
			// 
			txtRegistEmail.Location = new System.Drawing.Point(208, 93);
			txtRegistEmail.Name = "txtRegistEmail";
			txtRegistEmail.Size = new System.Drawing.Size(250, 27);
			txtRegistEmail.TabIndex = 6;
			// 
			// txtRegistAddress
			// 
			txtRegistAddress.Location = new System.Drawing.Point(208, 302);
			txtRegistAddress.Name = "txtRegistAddress";
			txtRegistAddress.Size = new System.Drawing.Size(250, 27);
			txtRegistAddress.TabIndex = 7;
			// 
			// txtRegistName
			// 
			txtRegistName.Location = new System.Drawing.Point(208, 247);
			txtRegistName.Name = "txtRegistName";
			txtRegistName.Size = new System.Drawing.Size(250, 27);
			txtRegistName.TabIndex = 8;
			// 
			// txtRegistPassword
			// 
			txtRegistPassword.Location = new System.Drawing.Point(208, 142);
			txtRegistPassword.Name = "txtRegistPassword";
			txtRegistPassword.Size = new System.Drawing.Size(250, 27);
			txtRegistPassword.TabIndex = 9;
			// 
			// txtRegistPhone
			// 
			txtRegistPhone.Location = new System.Drawing.Point(208, 410);
			txtRegistPhone.Name = "txtRegistPhone";
			txtRegistPhone.Size = new System.Drawing.Size(250, 27);
			txtRegistPhone.TabIndex = 10;
			// 
			// txtRegistBirthday
			// 
			txtRegistBirthday.Location = new System.Drawing.Point(208, 352);
			txtRegistBirthday.Name = "txtRegistBirthday";
			txtRegistBirthday.Size = new System.Drawing.Size(250, 27);
			txtRegistBirthday.TabIndex = 11;
			// 
			// txtRegistPasswordConfi
			// 
			txtRegistPasswordConfi.Location = new System.Drawing.Point(208, 197);
			txtRegistPasswordConfi.Name = "txtRegistPasswordConfi";
			txtRegistPasswordConfi.Size = new System.Drawing.Size(250, 27);
			txtRegistPasswordConfi.TabIndex = 13;
			// 
			// lbRegistPasswordConfi
			// 
			lbRegistPasswordConfi.AutoSize = true;
			lbRegistPasswordConfi.Location = new System.Drawing.Point(62, 200);
			lbRegistPasswordConfi.Name = "lbRegistPasswordConfi";
			lbRegistPasswordConfi.Size = new System.Drawing.Size(127, 20);
			lbRegistPasswordConfi.TabIndex = 12;
			lbRegistPasswordConfi.Text = "Password Confirm";
			// 
			// btnRegister
			// 
			btnRegister.Location = new System.Drawing.Point(62, 460);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new System.Drawing.Size(94, 29);
			btnRegister.TabIndex = 14;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// btnRegistReset
			// 
			btnRegistReset.Location = new System.Drawing.Point(230, 460);
			btnRegistReset.Name = "btnRegistReset";
			btnRegistReset.Size = new System.Drawing.Size(94, 29);
			btnRegistReset.TabIndex = 15;
			btnRegistReset.Text = "Reset";
			btnRegistReset.UseVisualStyleBackColor = true;
			btnRegistReset.Click += btnRegistReset_Click;
			// 
			// btnRegistCancel
			// 
			btnRegistCancel.Location = new System.Drawing.Point(400, 460);
			btnRegistCancel.Name = "btnRegistCancel";
			btnRegistCancel.Size = new System.Drawing.Size(94, 29);
			btnRegistCancel.TabIndex = 16;
			btnRegistCancel.Text = "Cancel";
			btnRegistCancel.UseVisualStyleBackColor = true;
			btnRegistCancel.Click += btnRegistCancel_Click;
			// 
			// lbInfor
			// 
			lbInfor.AutoSize = true;
			lbInfor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			lbInfor.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			lbInfor.Location = new System.Drawing.Point(208, 27);
			lbInfor.Name = "lbInfor";
			lbInfor.Size = new System.Drawing.Size(178, 40);
			lbInfor.TabIndex = 17;
			lbInfor.Text = "Information";
			// 
			// frmRegister
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(550, 518);
			Controls.Add(lbInfor);
			Controls.Add(btnRegistCancel);
			Controls.Add(btnRegistReset);
			Controls.Add(btnRegister);
			Controls.Add(txtRegistPasswordConfi);
			Controls.Add(lbRegistPasswordConfi);
			Controls.Add(txtRegistBirthday);
			Controls.Add(txtRegistPhone);
			Controls.Add(txtRegistPassword);
			Controls.Add(txtRegistName);
			Controls.Add(txtRegistAddress);
			Controls.Add(txtRegistEmail);
			Controls.Add(lbRegistPhone);
			Controls.Add(lbRegistAddress);
			Controls.Add(lbRegistBirthday);
			Controls.Add(lbRegistPassword);
			Controls.Add(lbRegistName);
			Controls.Add(lbRegistEmail);
			Name = "frmRegister";
			Text = "Register Page";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label lbRegistEmail;
		private System.Windows.Forms.Label lbRegistName;
		private System.Windows.Forms.Label lbRegistPassword;
		private System.Windows.Forms.Label lbRegistBirthday;
		private System.Windows.Forms.Label lbRegistAddress;
		private System.Windows.Forms.Label lbRegistPhone;
		private System.Windows.Forms.TextBox txtRegistEmail;
		private System.Windows.Forms.TextBox txtRegistAddress;
		private System.Windows.Forms.TextBox txtRegistName;
		private System.Windows.Forms.TextBox txtRegistPassword;
		private System.Windows.Forms.TextBox txtRegistPhone;
		private System.Windows.Forms.DateTimePicker txtRegistBirthday;
		private System.Windows.Forms.TextBox txtRegistPasswordConfi;
		private System.Windows.Forms.Label lbRegistPasswordConfi;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnRegistReset;
		private System.Windows.Forms.Button btnRegistCancel;
		private System.Windows.Forms.Label lbInfor;
	}
}