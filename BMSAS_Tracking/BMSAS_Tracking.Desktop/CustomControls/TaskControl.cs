using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMSAS_Tracking.Desktop.CustomControls
{
	public partial class TaskControl : UserControl
	{
		public TaskControl()
		{
			InitializeComponent();
		}

		#region Properties
		private string _name;

		[Category("Custom")]
		public string name
		{
			get { return _name; }
			set { _name = value; Lbl_Name.Text = value; }
		}

		private string time;

		[Category("Custom")]
		public string Time
		{
			get { return time; }
			set { time = value; Lbl_EstimatedTime.Text = value; }
		}
		#endregion

		private void TaskControl_MouseEnter(object sender, EventArgs e)
		{
			//this.BackColor = Color.FromArgb(62, 120, 138);
		}

		private void TaskControl_MouseLeave(object sender, EventArgs e)
		{
			//this.BackColor = Color.White;
		}
	}
}
