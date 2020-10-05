namespace BMSAS_Tracking.Desktop
{
	partial class LoginForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.Txt_Email = new System.Windows.Forms.TextBox();
			this.Btn_SignIn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Txt_Password = new System.Windows.Forms.TextBox();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(365, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sign in to BMSAS Tracking";
			// 
			// Txt_Email
			// 
			this.Txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_Email.Location = new System.Drawing.Point(41, 190);
			this.Txt_Email.Name = "Txt_Email";
			this.Txt_Email.Size = new System.Drawing.Size(359, 26);
			this.Txt_Email.TabIndex = 1;
			this.Txt_Email.Text = "tayyabdost@gmail.com";
			// 
			// Btn_SignIn
			// 
			this.Btn_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_SignIn.Location = new System.Drawing.Point(234, 309);
			this.Btn_SignIn.Name = "Btn_SignIn";
			this.Btn_SignIn.Size = new System.Drawing.Size(100, 35);
			this.Btn_SignIn.TabIndex = 2;
			this.Btn_SignIn.Text = "Sign In";
			this.Btn_SignIn.UseVisualStyleBackColor = true;
			this.Btn_SignIn.Click += new System.EventHandler(this.Btn_SignIn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(37, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(37, 229);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password";
			// 
			// Txt_Password
			// 
			this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_Password.Location = new System.Drawing.Point(41, 252);
			this.Txt_Password.Name = "Txt_Password";
			this.Txt_Password.PasswordChar = '*';
			this.Txt_Password.Size = new System.Drawing.Size(359, 26);
			this.Txt_Password.TabIndex = 4;
			this.Txt_Password.Text = "tayyabdost@gmail.com";
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Cancel.Location = new System.Drawing.Point(107, 309);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(100, 35);
			this.Btn_Cancel.TabIndex = 6;
			this.Btn_Cancel.Text = "Cancel";
			this.Btn_Cancel.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox1.Image = global::BMSAS_Tracking.Desktop.Properties.Resources.logo_bmsastech;
			this.pictureBox1.Location = new System.Drawing.Point(121, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(187, 90);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 358);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Btn_Cancel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Txt_Password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Btn_SignIn);
			this.Controls.Add(this.Txt_Email);
			this.Controls.Add(this.label1);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Form";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Txt_Email;
		private System.Windows.Forms.Button Btn_SignIn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Txt_Password;
		private System.Windows.Forms.Button Btn_Cancel;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

