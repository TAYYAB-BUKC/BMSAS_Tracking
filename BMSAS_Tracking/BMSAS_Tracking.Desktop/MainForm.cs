using MouseKeyboardLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BMSAS_Tracking.Desktop
{
	public partial class MainForm : Form
	{
		private int counter = 0;
		private Timer screenTimer;
        private Timer activityTimer;
        private Timer eachSecondTimer;
        MouseHook mouseHook = new MouseHook();
		KeyboardHook keyboardHook = new KeyboardHook();
		private int keyboardCounter = 0;
		private int mouseCounter = 0;
        private int mainKeyboardCounter = 0;
		private int mainMouseCounter = 0;
        
        public MainForm()
		{
			InitializeComponent();

            screenTimer = new Timer() {
				Enabled = true,
                Interval = GetInterval()
			};

            screenTimer.Tick += new EventHandler(SaveScreen);

            eachSecondTimer = new Timer()
            {
                Enabled = true,
                Interval = 1000
            };

            eachSecondTimer.Tick += new EventHandler(TrackActivityEverySecond);

            activityTimer = new Timer()
            {
                Enabled = true,
                //Interval = 300000 //for 5 Minutes
                Interval = 120000 // for 2 Minutes
                //Interval = 600000 //for 10 Minutes
            };

            activityTimer.Tick += new EventHandler(SaveActivityDetails);

			using (WebClient webClient = new WebClient())
			{
				webClient.BaseAddress = "https://localhost:44308/api/Employee";
				//Uri uri = new Uri("https://localhost:44308/api/Employee");
				var json = webClient.DownloadString("https://localhost:44308/api/Employee");
				var employees = JsonConvert.DeserializeObject<List<Employee>>(json);
				foreach (var emp in employees)
				{
					MessageBox.Show($" { emp.Name } { emp.Position } { emp.Salary }");
				}
			}

			using (WebClient webClient = new WebClient())
			{
				webClient.BaseAddress = "https://localhost:44308/api/Employee";
				//Uri uri = new Uri("https://localhost:44308/api/Employee");

				var newEmployee = new Employee
				{
					Name = "Nabeel",
					Age = 21,
					Position = "WordPress Developer",
					Salary = 15000
				};
				string inputJson = JsonConvert.SerializeObject(newEmployee);
				webClient.Headers["Content-type"] = "application/json";
				webClient.Encoding = Encoding.UTF8;
				string json = webClient.UploadString("Employee", inputJson);
                MessageBox.Show(json);
			}

		}

        private int GetInterval()
		{
            Random random = new Random();
            int next = random.Next(1, 9);

            //RealTime
            //switch (next)
            //{
            //             case 1:
            //                 return 60000;
            //             case 2:
            //                 return 120000;
            //             case 3:
            //                 return 180000;
            //             case 4:
            //                 return 240000;
            //             case 5:
            //                 return 300000;
            //             case 6:
            //                 return 360000;
            //             case 7:
            //                 return 420000;
            //             case 8:
            //                 return 480000;
            //             default:
            //                 return 540000;
            //       }

            //Testing
            switch (next)
            {
                case 1:
                    return 6000;
                case 2:
                    return 12000;
                case 3:
                    return 18000;
                case 4:
                    return 24000;
                case 5:
                    return 30000;
                case 6:
                    return 36000;
                case 7:
                    return 42000;
                case 8:
                    return 48000;
                default:
                    return 54000;
            }
        }

        private void SaveScreen(object sender, EventArgs e)
		{
			//Testing 
			//richTextBox1.Text += "Running" + DateTime.Now + "\n";
			//label1.Text = "Timer's Count: " + (++counter);

			try
			{
				//save screen to Desktop
				Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
				Graphics graphics = Graphics.FromImage(bitmap);
				graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

				string guid = $"{ Guid.NewGuid() }.png";
				bitmap.Save(guid);
				richTextBox1.Text += $"{ guid } saved at " + DateTime.Now + "\n";
				label1.Text = "Pic's Count: " + (++counter);
                screenTimer.Interval = GetInterval();
                //MessageBox.Show("KeyBoard: " + mainKeyboardCounter + "\nMouse: " + mainMouseCounter);
			}
			catch (Exception)
			{
				richTextBox1.Text += "You ran out of Memory at " + DateTime.Now + "\n";
			}
		}

        private void TrackActivityEverySecond(object sender, EventArgs e)
        {
			//label1.Text = DateTime.Now.ToLongTimeString();
			listView3.Items.Insert(0,
				new ListViewItem(
					new string[]{
						"Keyboard",
						keyboardCounter.ToString()
					}));

			listView3.Items.Insert(0,
			   new ListViewItem(
				   new string[]{
						"Mouse",
						mouseCounter.ToString()
				   }));

			if (keyboardCounter > 0)
			{
                mainKeyboardCounter++;
            }
            if (mouseCounter > 0)
            {
                mainMouseCounter++;
			}
            
            keyboardCounter = 0;
            mouseCounter = 0;

        }

        private void SaveActivityDetails(object sender, EventArgs e)
         {
            //MessageBox.Show("SaveActivityDetails: \nKeyBoard: " + mainKeyboardCounter + "\nMouse: " + mainMouseCounter);
            if (mainKeyboardCounter > 0)
			{
                richTextBox1.Text += "KeyBoard Activity: " + ((mainKeyboardCounter * 100) / 600) + "%";
            }
			else
			{
                richTextBox1.Text += "KeyBoard Activity: 0%";
            }
            if (mainMouseCounter > 0)
            {
                richTextBox1.Text += "Mouse Activity: " + ((mainMouseCounter * 100) / 600) + "%";
            }
            else
            {
                richTextBox1.Text += "Mouse Activity: 0%";
            }

            mainKeyboardCounter = 0;
            mainMouseCounter = 0;

        }


        void keyboardHook_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyboardCounter++;
            AddKeyboardEvent(
                "KeyPress",
                "",
                e.KeyChar.ToString(),
                "",
                "",
                ""
                );

        }

        void keyboardHook_KeyUp(object sender, KeyEventArgs e)
        {
            keyboardCounter++;
            AddKeyboardEvent(
                "KeyUp",
                e.KeyCode.ToString(),
                "",
                e.Shift.ToString(),
                e.Alt.ToString(),
                e.Control.ToString()
                );

        }

        void keyboardHook_KeyDown(object sender, KeyEventArgs e)
        {

            keyboardCounter++;
            AddKeyboardEvent(
                "KeyDown",
                e.KeyCode.ToString(),
                "",
                e.Shift.ToString(),
                e.Alt.ToString(),
                e.Control.ToString()
                );

        }

        void mouseHook_MouseWheel(object sender, MouseEventArgs e)
        {
            mouseCounter++;
            AddMouseEvent(
                "MouseWheel",
                "",
                "",
                "",
                e.Delta.ToString()
                );

        }

        void mouseHook_MouseUp(object sender, MouseEventArgs e)
        {

            mouseCounter++;

            AddMouseEvent(
                "MouseUp",
                e.Button.ToString(),
                e.X.ToString(),
                e.Y.ToString(),
                ""
                );

        }

        void mouseHook_MouseDown(object sender, MouseEventArgs e)
        {
            mouseCounter++;

            AddMouseEvent(
                "MouseDown",
                e.Button.ToString(),
                e.X.ToString(),
                e.Y.ToString(),
                ""
                );
        }

        void mouseHook_MouseMove(object sender, MouseEventArgs e)
        {
            mouseCounter++;
			AddMouseEvent(
				"MouseMove",
				"",
				"",
				"",
				e.Delta.ToString()
				);
			SetXYLabel(e.X, e.Y);

        }

        void SetXYLabel(int x, int y)
        {
            curXYLabel.Text = String.Format("Current Mouse Point: X={0}, y={1}", x, y);
        }

        void AddMouseEvent(string eventType, string button, string x, string y, string delta)
        {

			listView1.Items.Insert(0,
				new ListViewItem(
					new string[]{
						eventType,
						button,
						x,
						y,
						delta
					}));

		}

        void AddKeyboardEvent(string eventType, string keyCode, string keyChar, string shift, string alt, string control)
        {

			listView2.Items.Insert(0,
				 new ListViewItem(
					 new string[]{
						eventType,
						keyCode,
						keyChar,
						shift,
						alt,
						control
				}));

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
            mouseHook.MouseMove += new MouseEventHandler(mouseHook_MouseMove);
            mouseHook.MouseDown += new MouseEventHandler(mouseHook_MouseDown);
            mouseHook.MouseUp += new MouseEventHandler(mouseHook_MouseUp);
            mouseHook.MouseWheel += new MouseEventHandler(mouseHook_MouseWheel);

            keyboardHook.KeyDown += new KeyEventHandler(keyboardHook_KeyDown);
            keyboardHook.KeyUp += new KeyEventHandler(keyboardHook_KeyUp);
            keyboardHook.KeyPress += new KeyPressEventHandler(keyboardHook_KeyPress);

            mouseHook.Start();
            keyboardHook.Start();
            //SetXYLabel(MouseSimulator.X, MouseSimulator.Y);
        }
    }
}
