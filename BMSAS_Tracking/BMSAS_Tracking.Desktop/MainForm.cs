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
	public partial class MainForm : Form
	{
		private int counter = 0;
		private Timer timer;
		public MainForm()
		{
			InitializeComponent();
			timer = new Timer() {
				Enabled = true,
				Interval = 5000
			};

			timer.Tick += new EventHandler(SaveScreen);
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

			}
			catch (Exception)
			{
				richTextBox1.Text += "You ran out of Memory at " + DateTime.Now + "\n";
			}
		}
	}
}
