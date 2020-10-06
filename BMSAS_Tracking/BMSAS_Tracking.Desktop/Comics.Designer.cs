namespace BMSAS_Tracking.Desktop
{
	partial class Comics
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
			this.label3 = new System.Windows.Forms.Label();
			this.Txt_ID = new System.Windows.Forms.TextBox();
			this.Btn_LoadComic = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Txt_Title = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Txt_Completed = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "ID No.";
			// 
			// Txt_ID
			// 
			this.Txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_ID.Location = new System.Drawing.Point(72, 16);
			this.Txt_ID.Name = "Txt_ID";
			this.Txt_ID.Size = new System.Drawing.Size(170, 26);
			this.Txt_ID.TabIndex = 7;
			// 
			// Btn_LoadComic
			// 
			this.Btn_LoadComic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_LoadComic.Location = new System.Drawing.Point(262, 12);
			this.Btn_LoadComic.Name = "Btn_LoadComic";
			this.Btn_LoadComic.Size = new System.Drawing.Size(122, 35);
			this.Btn_LoadComic.TabIndex = 6;
			this.Btn_LoadComic.Text = "Load Data";
			this.Btn_LoadComic.UseVisualStyleBackColor = true;
			this.Btn_LoadComic.Click += new System.EventHandler(this.Btn_LoadComic_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(50, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Title";
			// 
			// Txt_Title
			// 
			this.Txt_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_Title.Location = new System.Drawing.Point(105, 68);
			this.Txt_Title.Name = "Txt_Title";
			this.Txt_Title.ReadOnly = true;
			this.Txt_Title.Size = new System.Drawing.Size(541, 26);
			this.Txt_Title.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 20);
			this.label2.TabIndex = 13;
			this.label2.Text = "Completed";
			// 
			// Txt_Completed
			// 
			this.Txt_Completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_Completed.Location = new System.Drawing.Point(105, 113);
			this.Txt_Completed.Name = "Txt_Completed";
			this.Txt_Completed.ReadOnly = true;
			this.Txt_Completed.Size = new System.Drawing.Size(541, 26);
			this.Txt_Completed.TabIndex = 12;
			// 
			// Comics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 164);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Txt_Completed);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Txt_Title);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Txt_ID);
			this.Controls.Add(this.Btn_LoadComic);
			this.Name = "Comics";
			this.Text = "Comics";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Txt_ID;
		private System.Windows.Forms.Button Btn_LoadComic;
		private System.Windows.Forms.PictureBox PB_Comic;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Txt_Title;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Txt_Completed;
	}
}