using BMSAS_Tracking.Desktop.Classes;
using Newtonsoft.Json;
using System;
using System.Net;
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
			//Without an API
			//if (Txt_Email.Text == "tayyabdost@gmail.com" && Txt_Password.Text == "tayyabdost@gmail.com")
			//{
			//	//open Main Window where after every 5 seconds screenshot is captured and saved on Desktop
			//	this.Hide();
			//	MainForm mainForm = new MainForm();
			//	mainForm.Show();
			//}
			//else
			//{
			//	MessageBox.Show("Invalid Credentials", "Error Message", MessageBox Buttons.OK, MessageBoxIcon.Error);
			//}

			//using an BMSAS_Tracking.API

			using (WebClient webClient = new WebClient())
			{
				webClient.BaseAddress = "http://localhost:63509/api/Login";
				var url = "http://localhost:63509/api/Login?email=" + Txt_Email.Text + "&password=" + Txt_Password.Text;
				var json = webClient.DownloadString(url);
				var response = JsonConvert.DeserializeObject<Employee>(json);
				if (response.Id == 0)
				{
					MessageBox.Show("Invalid Credentials", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					//open Main Window where after every 5 seconds screenshot is captured and saved on Desktop
					LoggedInEmployee.employee = response;
					this.Hide();
					MainForm mainForm = new MainForm();
					mainForm.Show();
				}
			}
		}
	}
}
