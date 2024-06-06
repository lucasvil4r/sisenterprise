namespace SisEnterprise_2._0
{
	partial class FormCalc13
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
            this.qtddependentesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisenterpriseDataSet = new SisEnterprise_2._0.sisenterpriseDataSet();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.eventos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliquota_real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proventos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastro_FuncionarioTableAdapter = new SisEnterprise_2._0.sisenterpriseDataSetTableAdapters.Cadastro_FuncionarioTableAdapter();
            this.idfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataadmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataalteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathfoto3x4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qtdhorastrabalhadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericQtdDependentes = new System.Windows.Forms.NumericUpDown();
            this.numericMesesTrabalhados = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.comboBoxParcela = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComboBoxDept = new System.Windows.Forms.ComboBox();
            this.cadastroDepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cadastro_DepartamentoTableAdapter = new SisEnterprise_2._0.sisenterpriseDataSetTableAdapters.Cadastro_DepartamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sisenterpriseDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQtdDependentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMesesTrabalhados)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDepartamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // qtddependentesDataGridViewTextBoxColumn
            // 
            this.qtddependentesDataGridViewTextBoxColumn.DataPropertyName = "qtd_dependentes";
            this.qtddependentesDataGridViewTextBoxColumn.HeaderText = "qtd_dependentes";
            this.qtddependentesDataGridViewTextBoxColumn.Name = "qtddependentesDataGridViewTextBoxColumn";
            this.qtddependentesDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtddependentesDataGridViewTextBoxColumn.Visible = false;
            // 
            // sisenterpriseDataSet
            // 
            this.sisenterpriseDataSet.DataSetName = "sisenterpriseDataSet";
            this.sisenterpriseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewResult);
            this.groupBox4.Location = new System.Drawing.Point(12, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(790, 261);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado Cálculo";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventos,
            this.aliquota_real,
            this.proventos,
            this.descontos});
            this.dataGridViewResult.Location = new System.Drawing.Point(39, 21);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(714, 217);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // eventos
            // 
            this.eventos.HeaderText = "Eventos";
            this.eventos.Name = "eventos";
            // 
            // aliquota_real
            // 
            this.aliquota_real.HeaderText = "Alíquota Real";
            this.aliquota_real.Name = "aliquota_real";
            // 
            // proventos
            // 
            this.proventos.HeaderText = "Proventos";
            this.proventos.Name = "proventos";
            // 
            // descontos
            // 
            this.descontos.HeaderText = "Descontos";
            this.descontos.Name = "descontos";
            // 
            // cadastro_FuncionarioTableAdapter
            // 
            this.cadastro_FuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // idfuncionarioDataGridViewTextBoxColumn
            // 
            this.idfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "id_funcionario";
            this.idfuncionarioDataGridViewTextBoxColumn.HeaderText = "id_funcionario";
            this.idfuncionarioDataGridViewTextBoxColumn.Name = "idfuncionarioDataGridViewTextBoxColumn";
            this.idfuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfuncionarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Visible = false;
            // 
            // datanascimentoDataGridViewTextBoxColumn
            // 
            this.datanascimentoDataGridViewTextBoxColumn.DataPropertyName = "data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.HeaderText = "data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.Name = "datanascimentoDataGridViewTextBoxColumn";
            this.datanascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datanascimentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Sálario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iddepartamentoDataGridViewTextBoxColumn
            // 
            this.iddepartamentoDataGridViewTextBoxColumn.DataPropertyName = "id_departamento";
            this.iddepartamentoDataGridViewTextBoxColumn.HeaderText = "id_departamento";
            this.iddepartamentoDataGridViewTextBoxColumn.Name = "iddepartamentoDataGridViewTextBoxColumn";
            this.iddepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddepartamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataadmissaoDataGridViewTextBoxColumn
            // 
            this.dataadmissaoDataGridViewTextBoxColumn.DataPropertyName = "data_admissao";
            this.dataadmissaoDataGridViewTextBoxColumn.HeaderText = "data_admissao";
            this.dataadmissaoDataGridViewTextBoxColumn.Name = "dataadmissaoDataGridViewTextBoxColumn";
            this.dataadmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataadmissaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataalteracaoDataGridViewTextBoxColumn
            // 
            this.dataalteracaoDataGridViewTextBoxColumn.DataPropertyName = "data_alteracao";
            this.dataalteracaoDataGridViewTextBoxColumn.HeaderText = "data_alteracao";
            this.dataalteracaoDataGridViewTextBoxColumn.Name = "dataalteracaoDataGridViewTextBoxColumn";
            this.dataalteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataalteracaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // datacadastroDataGridViewTextBoxColumn
            // 
            this.datacadastroDataGridViewTextBoxColumn.DataPropertyName = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.HeaderText = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.Name = "datacadastroDataGridViewTextBoxColumn";
            this.datacadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.datacadastroDataGridViewTextBoxColumn.Visible = false;
            // 
            // pathfoto3x4DataGridViewTextBoxColumn
            // 
            this.pathfoto3x4DataGridViewTextBoxColumn.DataPropertyName = "path_foto3x4";
            this.pathfoto3x4DataGridViewTextBoxColumn.HeaderText = "path_foto3x4";
            this.pathfoto3x4DataGridViewTextBoxColumn.Name = "pathfoto3x4DataGridViewTextBoxColumn";
            this.pathfoto3x4DataGridViewTextBoxColumn.ReadOnly = true;
            this.pathfoto3x4DataGridViewTextBoxColumn.Visible = false;
            // 
            // cadastroFuncionarioBindingSource
            // 
            this.cadastroFuncionarioBindingSource.DataMember = "Cadastro_Funcionario";
            this.cadastroFuncionarioBindingSource.DataSource = this.sisenterpriseDataSet;
            // 
            // qtdhorastrabalhadasDataGridViewTextBoxColumn
            // 
            this.qtdhorastrabalhadasDataGridViewTextBoxColumn.DataPropertyName = "qtd_horas_trabalhadas";
            this.qtdhorastrabalhadasDataGridViewTextBoxColumn.HeaderText = "qtd_horas_trabalhadas";
            this.qtdhorastrabalhadasDataGridViewTextBoxColumn.Name = "qtdhorastrabalhadasDataGridViewTextBoxColumn";
            this.qtdhorastrabalhadasDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtdhorastrabalhadasDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleName = "";
            this.dataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfuncionarioDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.datanascimentoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.iddepartamentoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.dataadmissaoDataGridViewTextBoxColumn,
            this.dataalteracaoDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn,
            this.pathfoto3x4DataGridViewTextBoxColumn,
            this.qtddependentesDataGridViewTextBoxColumn,
            this.qtdhorastrabalhadasDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.cadastroFuncionarioBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(39, 29);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(714, 97);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericQtdDependentes);
            this.groupBox1.Controls.Add(this.numericMesesTrabalhados);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.buttonCalcular);
            this.groupBox1.Controls.Add(this.comboBoxParcela);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxSalario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 216);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores Cálculo";
            // 
            // numericQtdDependentes
            // 
            this.numericQtdDependentes.Enabled = false;
            this.numericQtdDependentes.Location = new System.Drawing.Point(524, 99);
            this.numericQtdDependentes.Name = "numericQtdDependentes";
            this.numericQtdDependentes.Size = new System.Drawing.Size(179, 20);
            this.numericQtdDependentes.TabIndex = 44;
            // 
            // numericMesesTrabalhados
            // 
            this.numericMesesTrabalhados.Location = new System.Drawing.Point(524, 40);
            this.numericMesesTrabalhados.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericMesesTrabalhados.Name = "numericMesesTrabalhados";
            this.numericMesesTrabalhados.Size = new System.Drawing.Size(179, 20);
            this.numericMesesTrabalhados.TabIndex = 43;
            this.numericMesesTrabalhados.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "PARCELA:";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(449, 154);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(105, 31);
            this.buttonLimpar.TabIndex = 7;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(322, 154);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(105, 31);
            this.buttonCalcular.TabIndex = 6;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // comboBoxParcela
            // 
            this.comboBoxParcela.DisplayMember = "nome";
            this.comboBoxParcela.FormattingEnabled = true;
            this.comboBoxParcela.Items.AddRange(new object[] {
            "Única",
            "Primeira",
            "Segunda"});
            this.comboBoxParcela.Location = new System.Drawing.Point(184, 97);
            this.comboBoxParcela.Name = "comboBoxParcela";
            this.comboBoxParcela.Size = new System.Drawing.Size(181, 21);
            this.comboBoxParcela.TabIndex = 4;
            this.comboBoxParcela.Text = "Única";
            this.comboBoxParcela.ValueMember = "id_departamento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(417, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "N° DEPENDENTES:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(393, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "MESES TRABALHADOS:";
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Enabled = false;
            this.textBoxSalario.Location = new System.Drawing.Point(184, 39);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(181, 20);
            this.textBoxSalario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "SALÁRIO BRUTO:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComboBoxDept);
            this.groupBox3.Controls.Add(this.textBoxEmail);
            this.groupBox3.Controls.Add(this.textBoxTelefone);
            this.groupBox3.Controls.Add(this.textBoxCPF);
            this.groupBox3.Controls.Add(this.pictureBoxFoto);
            this.groupBox3.Controls.Add(this.textBoxNome);
            this.groupBox3.Location = new System.Drawing.Point(825, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 632);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Funcionário";
            // 
            // ComboBoxDept
            // 
            this.ComboBoxDept.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cadastroDepartamentoBindingSource, "id_departamento", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.ComboBoxDept.DataSource = this.cadastroDepartamentoBindingSource;
            this.ComboBoxDept.DisplayMember = "nome";
            this.ComboBoxDept.Enabled = false;
            this.ComboBoxDept.FormattingEnabled = true;
            this.ComboBoxDept.Location = new System.Drawing.Point(25, 398);
            this.ComboBoxDept.Name = "ComboBoxDept";
            this.ComboBoxDept.Size = new System.Drawing.Size(181, 21);
            this.ComboBoxDept.TabIndex = 3;
            this.ComboBoxDept.ValueMember = "id_departamento";
            // 
            // cadastroDepartamentoBindingSource
            // 
            this.cadastroDepartamentoBindingSource.DataMember = "Cadastro_Departamento";
            this.cadastroDepartamentoBindingSource.DataSource = this.sisenterpriseDataSet;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(25, 464);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(179, 20);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.TabStop = false;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Enabled = false;
            this.textBoxTelefone.Location = new System.Drawing.Point(25, 330);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(179, 20);
            this.textBoxTelefone.TabIndex = 2;
            this.textBoxTelefone.TabStop = false;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Enabled = false;
            this.textBoxCPF.Location = new System.Drawing.Point(25, 263);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(179, 20);
            this.textBoxCPF.TabIndex = 1;
            this.textBoxCPF.TabStop = false;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(43, 30);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(142, 112);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 0;
            this.pictureBoxFoto.TabStop = false;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Enabled = false;
            this.textBoxNome.Location = new System.Drawing.Point(25, 196);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(179, 20);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 501);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 143);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Funcionarios";
            // 
            // cadastro_DepartamentoTableAdapter
            // 
            this.cadastro_DepartamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FormCalc13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 656);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1079, 695);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1079, 695);
            this.Name = "FormCalc13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálcular 13º";
            this.Load += new System.EventHandler(this.FormCalc13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sisenterpriseDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQtdDependentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMesesTrabalhados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDepartamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridViewTextBoxColumn qtddependentesDataGridViewTextBoxColumn;
		private sisenterpriseDataSet sisenterpriseDataSet;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dataGridViewResult;
		private System.Windows.Forms.DataGridViewTextBoxColumn eventos;
		private System.Windows.Forms.DataGridViewTextBoxColumn aliquota_real;
		private System.Windows.Forms.DataGridViewTextBoxColumn proventos;
		private System.Windows.Forms.DataGridViewTextBoxColumn descontos;
		private sisenterpriseDataSetTableAdapters.Cadastro_FuncionarioTableAdapter cadastro_FuncionarioTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idfuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iddepartamentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataadmissaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataalteracaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pathfoto3x4DataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource cadastroFuncionarioBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn qtdhorastrabalhadasDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonLimpar;
		private System.Windows.Forms.Button buttonCalcular;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxSalario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.TextBox textBoxTelefone;
		private System.Windows.Forms.TextBox textBoxCPF;
		private System.Windows.Forms.PictureBox pictureBoxFoto;
		private System.Windows.Forms.TextBox textBoxNome;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox ComboBoxDept;
		private System.Windows.Forms.BindingSource cadastroDepartamentoBindingSource;
		private sisenterpriseDataSetTableAdapters.Cadastro_DepartamentoTableAdapter cadastro_DepartamentoTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxParcela;
        private System.Windows.Forms.NumericUpDown numericMesesTrabalhados;
        private System.Windows.Forms.NumericUpDown numericQtdDependentes;
    }
}