using BMSAS_Tracking.Desktop.Classes;
using BMSAS_Tracking.Desktop.CustomControls;
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

namespace BMSAS_Tracking.Desktop
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
			//LoadProjects();
			LoadTasks();

		}

		private void LoadTasks()
		{
			TaskControl[] taskControl = new TaskControl[20];
			flowLayoutPanel1.Controls.Clear();

			for (int i = 0; i < taskControl.Length; i++)
			{
				taskControl[i] = new TaskControl();
				taskControl[i].name = "Lorum Ipsum is the worldwide dummy text in industry";
				taskControl[i].Time = i+" Days";
				taskControl[i].Size = new Size(294, 90);
				flowLayoutPanel1.Controls.Add(taskControl[i]);

			}
		}

		private void LoadProjects()
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.BaseAddress = "http://localhost:63509/api/Project";
				//var url = "http://localhost:63509/api/Project?id=" + LoggedInEmployee.employee.Id;
				var url = "http://localhost:63509/api/Project?id=1";
				var json = webClient.DownloadString(url);
				var response = JsonConvert.DeserializeObject<List<Project>>(json);
				if (response.Count == 0)
				{
					ProjectsControl projectsControl = new ProjectsControl();
					projectsControl.Title = "No Projects Found";
					projectsControl.Id = 0;
					projectsControl.Location = new Point(10, 10);
					projectsControl.Size = new Size(30, 40);
					Panel_Projects.Controls.Add(projectsControl);
				}
				else
				{
					int cx = 2, cy = 11, lx = 0, ly = 55;
					foreach (var project in response)
					{
						//Button button = new Button();
						//button.Text = project.Name;
						//button.Tag = project.Id;
						//button.FlatStyle = FlatStyle.Flat;
						//button.FlatAppearance.BorderSize = 0;
						////button.Font = new Font("Century Gothic, 9.75pt");
						//button.ForeColor = Color.FromArgb(62, 120, 138);
						//button.BackColor = Color.FromArgb(41, 44, 51);
						//button.Location = new Point(cx, cy);
						//button.Size = new Size(201, 40);

						ProjectsControl button = new ProjectsControl();
						button.Title = project.Name;
						button.Id = project.Id;
						//button.FlatStyle = FlatStyle.Flat;
						//button.FlatAppearance.BorderSize = 0;
						//button.Font = new Font("Century Gothic, 9.75pt");
						button.ForeColor = Color.FromArgb(62, 120, 138);
						button.BackColor = Color.FromArgb(41, 44, 51);
						button.Location = new Point(cx, cy);
						button.Size = new Size(201, 40);
						cy += 45;
						
						Panel_Projects.Controls.Add(button);
						//Panel panel = new Panel();
						//panel.BackColor = Color.White;
						//panel.Location = new Point(lx, ly);
						//panel.Size = new Size(220, 1);
						//Panel_Projects.Controls.Add(panel);
						//ly += 50;

					}
				}
			}

        }

		private void GetProjects(object sender, EventArgs e)
		{
			Button button = sender as Button;

			MessageBox.Show(button.Tag.ToString());

		}
	}
}
