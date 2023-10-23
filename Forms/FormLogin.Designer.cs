namespace SisEnterprise_2._0
{
	partial class FormLogin
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
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.textBoxUser = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxPass
			// 
			this.textBoxPass.Location = new System.Drawing.Point(90, 121);
			this.textBoxPass.MaximumSize = new System.Drawing.Size(181, 20);
			this.textBoxPass.MinimumSize = new System.Drawing.Size(181, 20);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new System.Drawing.Size(181, 20);
			this.textBoxPass.TabIndex = 12;
			this.textBoxPass.UseSystemPasswordChar = true;
			// 
			// textBoxUser
			// 
			this.textBoxUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxUser.Location = new System.Drawing.Point(90, 81);
			this.textBoxUser.Name = "textBoxUser";
			this.textBoxUser.Size = new System.Drawing.Size(181, 20);
			this.textBoxUser.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Login:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(43, 124);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Senha:";
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(120, 165);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(105, 31);
			this.buttonLogin.TabIndex = 20;
			this.buttonLogin.Text = "Entrar";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.AllowDrop = true;
			this.textBoxTitle.BackColor = System.Drawing.SystemColors.Menu;
			this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTitle.Location = new System.Drawing.Point(26, 22);
			this.textBoxTitle.Multiline = true;
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.ReadOnly = true;
			this.textBoxTitle.Size = new System.Drawing.Size(294, 39);
			this.textBoxTitle.TabIndex = 21;
			this.textBoxTitle.Text = "ACESSO";
			this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 223);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.textBoxPass);
			this.Controls.Add(this.textBoxUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(363, 262);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(363, 262);
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.FormLogin_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxPass;
		private System.Windows.Forms.TextBox textBoxUser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonLogin;
		internal System.Windows.Forms.TextBox textBoxTitle;
	}
}