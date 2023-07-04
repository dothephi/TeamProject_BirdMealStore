using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdMealStoreWinForm
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtEmail.Text = string.Empty;
			txtPassword.Text = string.Empty;
		}

		private void lbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmRegister frmRegister = new frmRegister();
			frmRegister.ShowDialog();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{

		}
	}
}
