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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.textBoxNome = new System.Windows.Forms.TextBox();
			this.textBoxCPF = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.textBoxSalario = new System.Windows.Forms.TextBox();
			this.textBoxCargo = new System.Windows.Forms.TextBox();
			this.textBoxTelefone = new System.Windows.Forms.TextBox();
			this.textBoxEndereco = new System.Windows.Forms.TextBox();
			this.textBoxDataAdmissao = new System.Windows.Forms.TextBox();
			this.textBoxAtivo = new System.Windows.Forms.TextBox();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxMatricula = new System.Windows.Forms.TextBox();
			this.textBoxRg = new System.Windows.Forms.TextBox();
			this.textBoxNascimento = new System.Windows.Forms.TextBox();
			this.textBoxNomeMeio = new System.Windows.Forms.TextBox();
			this.textBoxSobreNome = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(990, 25);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.Text = "ToolStrip";
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 534);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(990, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "StatusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel.Text = "Status";
			// 
			// textBoxNome
			// 
			this.textBoxNome.Location = new System.Drawing.Point(102, 117);
			this.textBoxNome.Name = "textBoxNome";
			this.textBoxNome.Size = new System.Drawing.Size(181, 20);
			this.textBoxNome.TabIndex = 4;
			this.textBoxNome.Text = "Lucas";
			// 
			// textBoxCPF
			// 
			this.textBoxCPF.Location = new System.Drawing.Point(403, 74);
			this.textBoxCPF.Name = "textBoxCPF";
			this.textBoxCPF.Size = new System.Drawing.Size(181, 20);
			this.textBoxCPF.TabIndex = 5;
			this.textBoxCPF.Text = "50323721885";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(746, 198);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(181, 20);
			this.textBoxEmail.TabIndex = 6;
			this.textBoxEmail.Text = "lucas@hotmail.com";
			// 
			// textBoxSalario
			// 
			this.textBoxSalario.Location = new System.Drawing.Point(102, 195);
			this.textBoxSalario.Name = "textBoxSalario";
			this.textBoxSalario.Size = new System.Drawing.Size(181, 20);
			this.textBoxSalario.TabIndex = 7;
			this.textBoxSalario.Text = "100";
			this.textBoxSalario.TextChanged += new System.EventHandler(this.textBoxSalario_TextChanged);
			// 
			// textBoxCargo
			// 
			this.textBoxCargo.Location = new System.Drawing.Point(102, 155);
			this.textBoxCargo.Name = "textBoxCargo";
			this.textBoxCargo.Size = new System.Drawing.Size(181, 20);
			this.textBoxCargo.TabIndex = 8;
			this.textBoxCargo.Text = "Junior";
			// 
			// textBoxTelefone
			// 
			this.textBoxTelefone.Location = new System.Drawing.Point(403, 157);
			this.textBoxTelefone.Name = "textBoxTelefone";
			this.textBoxTelefone.Size = new System.Drawing.Size(181, 20);
			this.textBoxTelefone.TabIndex = 9;
			this.textBoxTelefone.Text = "11971084699";
			// 
			// textBoxEndereco
			// 
			this.textBoxEndereco.Location = new System.Drawing.Point(403, 239);
			this.textBoxEndereco.Name = "textBoxEndereco";
			this.textBoxEndereco.Size = new System.Drawing.Size(181, 20);
			this.textBoxEndereco.TabIndex = 9;
			this.textBoxEndereco.Text = "São Paulo";
			// 
			// textBoxDataAdmissao
			// 
			this.textBoxDataAdmissao.Location = new System.Drawing.Point(403, 198);
			this.textBoxDataAdmissao.Name = "textBoxDataAdmissao";
			this.textBoxDataAdmissao.Size = new System.Drawing.Size(181, 20);
			this.textBoxDataAdmissao.TabIndex = 9;
			this.textBoxDataAdmissao.Text = "30/10/2020";
			// 
			// textBoxAtivo
			// 
			this.textBoxAtivo.AccessibleName = "";
			this.textBoxAtivo.Location = new System.Drawing.Point(102, 237);
			this.textBoxAtivo.Name = "textBoxAtivo";
			this.textBoxAtivo.Size = new System.Drawing.Size(181, 20);
			this.textBoxAtivo.TabIndex = 9;
			this.textBoxAtivo.Text = "1";
			this.textBoxAtivo.TextChanged += new System.EventHandler(this.TextBoxAtivo_TextChanged);
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(102, 75);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(181, 20);
			this.textBoxId.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(367, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "CPF:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(54, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "NOME:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(696, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "EMAIL:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(49, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "CARGO:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(337, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "TELEFONE:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(305, 201);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "DATA ADMISSÃO:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(55, 240);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "ATIVO:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(332, 242);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 13);
			this.label9.TabIndex = 10;
			this.label9.Text = "ENDEREÇO:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(39, 198);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 13);
			this.label10.TabIndex = 10;
			this.label10.Text = "SALARIO:";
			// 
			// textBoxMatricula
			// 
			this.textBoxMatricula.Location = new System.Drawing.Point(746, 72);
			this.textBoxMatricula.Name = "textBoxMatricula";
			this.textBoxMatricula.Size = new System.Drawing.Size(181, 20);
			this.textBoxMatricula.TabIndex = 5;
			// 
			// textBoxRg
			// 
			this.textBoxRg.Location = new System.Drawing.Point(746, 237);
			this.textBoxRg.Name = "textBoxRg";
			this.textBoxRg.Size = new System.Drawing.Size(181, 20);
			this.textBoxRg.TabIndex = 6;
			this.textBoxRg.Text = "560248301";
			// 
			// textBoxNascimento
			// 
			this.textBoxNascimento.Location = new System.Drawing.Point(746, 155);
			this.textBoxNascimento.Name = "textBoxNascimento";
			this.textBoxNascimento.Size = new System.Drawing.Size(181, 20);
			this.textBoxNascimento.TabIndex = 9;
			this.textBoxNascimento.Text = "30/10/2001";
			// 
			// textBoxNomeMeio
			// 
			this.textBoxNomeMeio.Location = new System.Drawing.Point(403, 117);
			this.textBoxNomeMeio.Name = "textBoxNomeMeio";
			this.textBoxNomeMeio.Size = new System.Drawing.Size(181, 20);
			this.textBoxNomeMeio.TabIndex = 9;
			this.textBoxNomeMeio.Text = "São Paulo";
			// 
			// textBoxSobreNome
			// 
			this.textBoxSobreNome.Location = new System.Drawing.Point(746, 117);
			this.textBoxSobreNome.Name = "textBoxSobreNome";
			this.textBoxSobreNome.Size = new System.Drawing.Size(181, 20);
			this.textBoxSobreNome.TabIndex = 9;
			this.textBoxSobreNome.Text = "Celestino";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(670, 75);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 13);
			this.label11.TabIndex = 10;
			this.label11.Text = "MATRICULA:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(703, 240);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(26, 13);
			this.label12.TabIndex = 10;
			this.label12.Text = "RG:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(660, 158);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(81, 13);
			this.label13.TabIndex = 10;
			this.label13.Text = "NASCIMENTO:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(658, 120);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(79, 13);
			this.label14.TabIndex = 10;
			this.label14.Text = "SOBRENOME:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(305, 120);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(91, 13);
			this.label15.TabIndex = 10;
			this.label15.Text = "NOME DO MEIO:";
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.CountItem = null;
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 25);
			this.bindingNavigator1.MoveFirstItem = null;
			this.bindingNavigator1.MoveLastItem = null;
			this.bindingNavigator1.MoveNextItem = null;
			this.bindingNavigator1.MovePreviousItem = null;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = null;
			this.bindingNavigator1.Size = new System.Drawing.Size(990, 25);
			this.bindingNavigator1.TabIndex = 11;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Excluir";
			this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(19, 25);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(900, 179);
			this.dataGridView.TabIndex = 12;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(23, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(942, 221);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados Clientes:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView);
			this.groupBox2.Location = new System.Drawing.Point(23, 284);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(942, 229);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Lista de Clientes";
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
			this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.saveToolStripButton.Text = "Save";
			this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
			// 
			// CadastroFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 556);
			this.Controls.Add(this.bindingNavigator1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxAtivo);
			this.Controls.Add(this.textBoxSobreNome);
			this.Controls.Add(this.textBoxDataAdmissao);
			this.Controls.Add(this.textBoxNomeMeio);
			this.Controls.Add(this.textBoxNascimento);
			this.Controls.Add(this.textBoxEndereco);
			this.Controls.Add(this.textBoxTelefone);
			this.Controls.Add(this.textBoxCargo);
			this.Controls.Add(this.textBoxRg);
			this.Controls.Add(this.textBoxSalario);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxMatricula);
			this.Controls.Add(this.textBoxId);
			this.Controls.Add(this.textBoxCPF);
			this.Controls.Add(this.textBoxNome);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "CadastroFuncionario";
			this.Text = "CadastroFuncionario";
			this.Load += new System.EventHandler(this.CadastroFuncionario_Load);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.TextBox textBoxNome;
		private System.Windows.Forms.TextBox textBoxCPF;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.TextBox textBoxSalario;
		private System.Windows.Forms.TextBox textBoxCargo;
		private System.Windows.Forms.TextBox textBoxTelefone;
		private System.Windows.Forms.TextBox textBoxEndereco;
		private System.Windows.Forms.TextBox textBoxDataAdmissao;
		private System.Windows.Forms.TextBox textBoxAtivo;
		private System.Windows.Forms.TextBox textBoxId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxMatricula;
		private System.Windows.Forms.TextBox textBoxRg;
		private System.Windows.Forms.TextBox textBoxNascimento;
		private System.Windows.Forms.TextBox textBoxNomeMeio;
		private System.Windows.Forms.TextBox textBoxSobreNome;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
	}
}



