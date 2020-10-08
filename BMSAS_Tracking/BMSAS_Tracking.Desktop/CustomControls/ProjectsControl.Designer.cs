namespace BMSAS_Tracking.Desktop.CustomControls
{
	partial class ProjectsControl
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
			this.Btn_Title = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Btn_Title
			// 
			this.Btn_Title.FlatAppearance.BorderSize = 0;
			this.Btn_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Title.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Title.Location = new System.Drawing.Point(3, 0);
			this.Btn_Title.Name = "Btn_Title";
			this.Btn_Title.Size = new System.Drawing.Size(201, 40);
			this.Btn_Title.TabIndex = 5;
			this.Btn_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Btn_Title.UseVisualStyleBackColor = true;
			this.Btn_Title.Click += new System.EventHandler(this.Btn_Title_Click);
			// 
			// ProjectsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.Controls.Add(this.Btn_Title);
			this.Name = "ProjectsControl";
			this.Size = new System.Drawing.Size(207, 46);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Btn_Title;
	}
}
