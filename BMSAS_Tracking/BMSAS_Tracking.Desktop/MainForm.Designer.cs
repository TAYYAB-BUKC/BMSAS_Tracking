namespace BMSAS_Tracking.Desktop
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listView3 = new System.Windows.Forms.ListView();
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listView2 = new System.Windows.Forms.ListView();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.curXYLabel = new System.Windows.Forms.Label();
			this.Lbl_Welcome = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(13, 538);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(581, 140);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(502, 697);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pic\'s Count:";
			// 
			// listView3
			// 
			this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
			this.listView3.HideSelection = false;
			this.listView3.Location = new System.Drawing.Point(42, 367);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(552, 150);
			this.listView3.TabIndex = 5;
			this.listView3.UseCompatibleStateImageBehavior = false;
			this.listView3.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Event ";
			this.columnHeader7.Width = 159;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Count";
			this.columnHeader8.Width = 100;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listView2);
			this.groupBox2.Location = new System.Drawing.Point(36, 198);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(564, 150);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Keyboard";
			// 
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
			this.listView2.HideSelection = false;
			this.listView2.Location = new System.Drawing.Point(6, 19);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(552, 125);
			this.listView2.TabIndex = 1;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "EventType";
			this.columnHeader6.Width = 80;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "KeyCode";
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "KeyChar";
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Shift";
			this.columnHeader13.Width = 50;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Alt";
			this.columnHeader14.Width = 50;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Control";
			this.columnHeader15.Width = 50;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Controls.Add(this.curXYLabel);
			this.groupBox1.Location = new System.Drawing.Point(36, 42);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(564, 150);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mouse";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(6, 38);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(552, 106);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "EventType";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Button";
			this.columnHeader4.Width = 70;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "X";
			this.columnHeader2.Width = 40;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Y";
			this.columnHeader3.Width = 40;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Delta";
			// 
			// curXYLabel
			// 
			this.curXYLabel.AutoSize = true;
			this.curXYLabel.Location = new System.Drawing.Point(22, 22);
			this.curXYLabel.Name = "curXYLabel";
			this.curXYLabel.Size = new System.Drawing.Size(0, 13);
			this.curXYLabel.TabIndex = 0;
			// 
			// Lbl_Welcome
			// 
			this.Lbl_Welcome.AutoSize = true;
			this.Lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Welcome.Location = new System.Drawing.Point(399, 19);
			this.Lbl_Welcome.Name = "Lbl_Welcome";
			this.Lbl_Welcome.Size = new System.Drawing.Size(75, 20);
			this.Lbl_Welcome.TabIndex = 6;
			this.Lbl_Welcome.Text = "Welcome";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 738);
			this.Controls.Add(this.Lbl_Welcome);
			this.Controls.Add(this.listView3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label curXYLabel;
		private System.Windows.Forms.Label Lbl_Welcome;
	}
}