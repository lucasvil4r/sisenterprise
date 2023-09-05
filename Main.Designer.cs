namespace SisEnterprise
{
	partial class Main
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.RH = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastroDeFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.marcaçãoDeFaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fISCALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lOGISTICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vENDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fINANCEIROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cONTABILIDADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RH,
            this.fISCALToolStripMenuItem,
            this.lOGISTICAToolStripMenuItem,
            this.vENDASToolStripMenuItem,
            this.fINANCEIROToolStripMenuItem,
            this.cONTABILIDADEToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.MdiWindowListItem = this.RH;
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1056, 24);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "menuStrip";
			// 
			// RH
			// 
			this.RH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.cadastroDeFuncionarioToolStripMenuItem,
            this.toolStripMenuItem5,
            this.marcaçãoDeFaltaToolStripMenuItem});
			this.RH.Name = "RH";
			this.RH.Size = new System.Drawing.Size(35, 20);
			this.RH.Text = "RH";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(203, 22);
			this.toolStripMenuItem3.Text = "Cálculo de Férias";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(203, 22);
			this.toolStripMenuItem4.Text = "Cálculo de 13°";
			// 
			// cadastroDeFuncionarioToolStripMenuItem
			// 
			this.cadastroDeFuncionarioToolStripMenuItem.Name = "cadastroDeFuncionarioToolStripMenuItem";
			this.cadastroDeFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.cadastroDeFuncionarioToolStripMenuItem.Text = "Cadastro de Funcionario";
			this.cadastroDeFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFuncionarioToolStripMenuItem_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(203, 22);
			this.toolStripMenuItem5.Text = "Marcação de Ponto";
			// 
			// marcaçãoDeFaltaToolStripMenuItem
			// 
			this.marcaçãoDeFaltaToolStripMenuItem.Name = "marcaçãoDeFaltaToolStripMenuItem";
			this.marcaçãoDeFaltaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.marcaçãoDeFaltaToolStripMenuItem.Text = "Marcação de Falta";
			// 
			// fISCALToolStripMenuItem
			// 
			this.fISCALToolStripMenuItem.Name = "fISCALToolStripMenuItem";
			this.fISCALToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.fISCALToolStripMenuItem.Text = "FISCAL";
			// 
			// lOGISTICAToolStripMenuItem
			// 
			this.lOGISTICAToolStripMenuItem.Name = "lOGISTICAToolStripMenuItem";
			this.lOGISTICAToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.lOGISTICAToolStripMenuItem.Text = "LOGISTICA";
			// 
			// vENDASToolStripMenuItem
			// 
			this.vENDASToolStripMenuItem.Name = "vENDASToolStripMenuItem";
			this.vENDASToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.vENDASToolStripMenuItem.Text = "VENDAS";
			// 
			// fINANCEIROToolStripMenuItem
			// 
			this.fINANCEIROToolStripMenuItem.Name = "fINANCEIROToolStripMenuItem";
			this.fINANCEIROToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.fINANCEIROToolStripMenuItem.Text = "FINANCEIRO";
			// 
			// cONTABILIDADEToolStripMenuItem
			// 
			this.cONTABILIDADEToolStripMenuItem.Name = "cONTABILIDADEToolStripMenuItem";
			this.cONTABILIDADEToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
			this.cONTABILIDADEToolStripMenuItem.Text = "CONTABILIDADE";
			// 
			// Main
			// 
			this.ClientSize = new System.Drawing.Size(1056, 625);
			this.Controls.Add(this.menuStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "Main";
			this.Text = "Enterprise Resource Planning";
			this.Load += new System.EventHandler(this.Main_Load_1);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem rHToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cADASTROFUNCIONAToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculoDeFériasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cálculoDe13ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cálculoDeFériasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem marcaçãoDePontoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dEPTFISCALToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dEPTFINANCEIROToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem RH;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem marcaçãoDeFaltaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fISCALToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lOGISTICAToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vENDASToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fINANCEIROToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cONTABILIDADEToolStripMenuItem;
	}
}