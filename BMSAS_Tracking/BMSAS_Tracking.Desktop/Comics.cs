using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace BMSAS_Tracking.Desktop
{
	public partial class Comics : Form
	{
		public Comics()
		{
			InitializeComponent();
			LoadComic();
		}

		private void LoadComic(int id = 0)
		{
			//ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;
			if (id == 0)
			{
				using (WebClient webClient = new WebClient())
				{
					//webClient.BaseAddress = "https://xkcd.com/info.0.json";
					//Uri uri = new Uri("https://localhost:44308/api/Employee");
					//var url = "https://xkcd.com/info.0.json";
					var json = webClient.DownloadString("https://jsonplaceholder.typicode.com/todos/4");
					var result = JsonConvert.DeserializeObject<RandomData>(json);
					Txt_Title.Text = result.title;
					Txt_Completed.Text = result.completed.ToString();
				}
			}
			else
			{
				using (WebClient webClient = new WebClient())
				{
					//webClient.BaseAddress = "https://xkcd.com/info.0.json";
					//Uri uri = new Uri("https://localhost:44308/api/Employee");
					var url = "https://jsonplaceholder.typicode.com/todos/"+id;
					var json = webClient.DownloadString(url);
					var result = JsonConvert.DeserializeObject<RandomData>(json);
					Txt_Title.Text = result.title;
					Txt_Completed.Text = result.completed.ToString();

				}
			}
		}

		private void Btn_LoadComic_Click(object sender, EventArgs e)
		{
			LoadComic(Convert.ToInt32(Txt_ID.Text));
		}
	}
}
