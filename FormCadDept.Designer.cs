namespace SisEnterprise_2._0
{
	partial class FormCadDept
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iddepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroDepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisenterpriseDataSet = new SisEnterprise_2._0.sisenterpriseDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxGerente = new System.Windows.Forms.TextBox();
            this.textBoxSupervisor = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDept = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.cadastro_DepartamentoTableAdapter = new SisEnterprise_2._0.sisenterpriseDataSetTableAdapters.Cadastro_DepartamentoTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDepartamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisenterpriseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(64, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 245);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Departamentos";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddepartamentoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.gerenteDataGridViewTextBoxColumn,
            this.supervisorDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.cadastroDepartamentoBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(35, 30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(607, 191);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseClick);
            // 
            // iddepartamentoDataGridViewTextBoxColumn
            // 
            this.iddepartamentoDataGridViewTextBoxColumn.DataPropertyName = "id_departamento";
            this.iddepartamentoDataGridViewTextBoxColumn.HeaderText = "id_departamento";
            this.iddepartamentoDataGridViewTextBoxColumn.Name = "iddepartamentoDataGridViewTextBoxColumn";
            this.iddepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // gerenteDataGridViewTextBoxColumn
            // 
            this.gerenteDataGridViewTextBoxColumn.DataPropertyName = "gerente";
            this.gerenteDataGridViewTextBoxColumn.HeaderText = "gerente";
            this.gerenteDataGridViewTextBoxColumn.Name = "gerenteDataGridViewTextBoxColumn";
            // 
            // supervisorDataGridViewTextBoxColumn
            // 
            this.supervisorDataGridViewTextBoxColumn.DataPropertyName = "supervisor";
            this.supervisorDataGridViewTextBoxColumn.HeaderText = "supervisor";
            this.supervisorDataGridViewTextBoxColumn.Name = "supervisorDataGridViewTextBoxColumn";
            // 
            // cadastroDepartamentoBindingSource
            // 
            this.cadastroDepartamentoBindingSource.DataMember = "Cadastro_Departamento";
            this.cadastroDepartamentoBindingSource.DataSource = this.sisenterpriseDataSet;
            // 
            // sisenterpriseDataSet
            // 
            this.sisenterpriseDataSet.DataSetName = "sisenterpriseDataSet";
            this.sisenterpriseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdicionar);
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.buttonDeletar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxGerente);
            this.groupBox1.Controls.Add(this.textBoxSupervisor);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxDept);
            this.groupBox1.Location = new System.Drawing.Point(64, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 221);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Departamento";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(454, 77);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(105, 31);
            this.buttonAdicionar.TabIndex = 19;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(454, 40);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(105, 31);
            this.buttonLimpar.TabIndex = 19;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(454, 114);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(105, 31);
            this.buttonSalvar.TabIndex = 17;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(454, 151);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(105, 31);
            this.buttonDeletar.TabIndex = 18;
            this.buttonDeletar.Text = "Excluir";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Supervisor:";
            // 
            // textBoxGerente
            // 
            this.textBoxGerente.Location = new System.Drawing.Point(115, 83);
            this.textBoxGerente.Name = "textBoxGerente";
            this.textBoxGerente.Size = new System.Drawing.Size(181, 20);
            this.textBoxGerente.TabIndex = 6;
            // 
            // textBoxSupervisor
            // 
            this.textBoxSupervisor.Location = new System.Drawing.Point(115, 157);
            this.textBoxSupervisor.Name = "textBoxSupervisor";
            this.textBoxSupervisor.Size = new System.Drawing.Size(181, 20);
            this.textBoxSupervisor.TabIndex = 3;
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(115, 48);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(181, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Departamento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gerente:";
            // 
            // textBoxDept
            // 
            this.textBoxDept.Location = new System.Drawing.Point(115, 119);
            this.textBoxDept.Name = "textBoxDept";
            this.textBoxDept.Size = new System.Drawing.Size(181, 20);
            this.textBoxDept.TabIndex = 9;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.AllowDrop = true;
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(64, 28);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(672, 39);
            this.textBoxTitle.TabIndex = 18;
            this.textBoxTitle.Text = "CADASTRO DE DEPARTAMENTOS";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cadastro_DepartamentoTableAdapter
            // 
            this.cadastro_DepartamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FormCadDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 618);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(817, 657);
            this.MinimumSize = new System.Drawing.Size(817, 657);
            this.Name = "FormCadDept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Departamento";
            this.Load += new System.EventHandler(this.FormCadDept_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDepartamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisenterpriseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonSalvar;
		private System.Windows.Forms.Button buttonDeletar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxGerente;
		private System.Windows.Forms.TextBox textBoxSupervisor;
		private System.Windows.Forms.TextBox textBoxId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxDept;
		internal System.Windows.Forms.TextBox textBoxTitle;
		private sisenterpriseDataSet sisenterpriseDataSet;
		private System.Windows.Forms.BindingSource cadastroDepartamentoBindingSource;
		private sisenterpriseDataSetTableAdapters.Cadastro_DepartamentoTableAdapter cadastro_DepartamentoTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn iddepartamentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gerenteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn supervisorDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button buttonLimpar;
		private System.Windows.Forms.Button buttonAdicionar;
	}
}