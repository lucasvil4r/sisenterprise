namespace SisEnterprise
{
	partial class CadastroFuncionario
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
			button1 = new Button();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(321, 323);
			button1.Name = "button1";
			button1.Size = new Size(120, 46);
			button1.TabIndex = 0;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(72, 51);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(210, 23);
			textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(500, 51);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(166, 23);
			textBox2.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 54);
			label1.Name = "label1";
			label1.Size = new Size(43, 15);
			label1.TabIndex = 3;
			label1.Text = "Nome:";
			label1.Click += label1_Click;
			// 
			// CadastroFuncionario
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Name = "CadastroFuncionario";
			Text = "CadastroFuncionario";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label1;
	}
}