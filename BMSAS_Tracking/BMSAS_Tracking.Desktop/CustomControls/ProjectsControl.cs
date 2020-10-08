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
	public partial class ProjectsControl : UserControl
	{
		public ProjectsControl()
		{
			InitializeComponent();
		}

		#region Properties
		private string title;

		[Category("Custom")]
		public string Title
		{
			get { return title; }
			set { title = value; Btn_Title.Text = value; }
		}

		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; Btn_Title.Tag = value; }
		}

		#endregion

		private void Btn_Title_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;

			MessageBox.Show(button.Tag.ToString());
		}
	}
}
