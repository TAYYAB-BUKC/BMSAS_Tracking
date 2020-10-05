using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMSAS_Tracking.Desktop
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void Btn_SignIn_Click(object sender, EventArgs e)
		{
			if (Txt_Email.Text == "tayyabdost@gmail.com" && Txt_Password.Text == "tayyabdost@gmail.com")
			{
				//open Main Window where after every 5 seconds screenshot is captured and saved on Desktop
				this.Hide();
				MainForm mainForm = new MainForm();
				mainForm.Show();
			}
			else
			{
				MessageBox.Show("Invalid Credentials", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}
	}
}
