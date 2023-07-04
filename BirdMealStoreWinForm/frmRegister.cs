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
	public partial class frmRegister : Form
	{
		public frmRegister()
		{
			InitializeComponent();
		}

		private void btnRegistCancel_Click(object sender, EventArgs e) => Close();

		private void btnRegistReset_Click(object sender, EventArgs e)
		{
			txtRegistAddress.Text = string.Empty;
			txtRegistName.Text = string.Empty;
			txtRegistBirthday.Text = string.Empty;
			txtRegistEmail.Text = string.Empty;
			txtRegistPhone.Text = string.Empty;
			txtRegistPasswordConfi.Text = string.Empty;
			txtRegistPassword.Text = string.Empty;
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{

		}
	}
}
