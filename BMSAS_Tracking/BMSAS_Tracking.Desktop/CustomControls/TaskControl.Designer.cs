namespace BMSAS_Tracking.Desktop.CustomControls
{
	partial class TaskControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskControl));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Lbl_Name = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Lbl_EstimatedTime = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(42, 47);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Lbl_Name
			// 
			this.Lbl_Name.AutoSize = true;
			this.Lbl_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Name.Location = new System.Drawing.Point(47, 3);
			this.Lbl_Name.Name = "Lbl_Name";
			this.Lbl_Name.Size = new System.Drawing.Size(219, 20);
			this.Lbl_Name.TabIndex = 1;
			this.Lbl_Name.Text = "Lorem Ispum is a dummy Text";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(50, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Estimated Time: ";
			// 
			// Lbl_EstimatedTime
			// 
			this.Lbl_EstimatedTime.AutoSize = true;
			this.Lbl_EstimatedTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Lbl_EstimatedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_EstimatedTime.Location = new System.Drawing.Point(172, 29);
			this.Lbl_EstimatedTime.Name = "Lbl_EstimatedTime";
			this.Lbl_EstimatedTime.Size = new System.Drawing.Size(0, 20);
			this.Lbl_EstimatedTime.TabIndex = 3;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.WindowText;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 50);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 1);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// TaskControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.Lbl_EstimatedTime);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Lbl_Name);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.Name = "TaskControl";
			this.Size = new System.Drawing.Size(580, 53);
			this.MouseEnter += new System.EventHandler(this.TaskControl_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.TaskControl_MouseLeave);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label Lbl_Name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Lbl_EstimatedTime;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}
