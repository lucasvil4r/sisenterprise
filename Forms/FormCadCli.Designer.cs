namespace SisEnterprise_2._0.Forms
{
    partial class FormCadCli
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaosocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoempresaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataalteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisenterpriseDataSet = new SisEnterprise_2._0.sisenterpriseDataSet();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxRazao = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxNome = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTextBoxCidade = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxBairro = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTextBoxEndereco = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEstado = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxPais = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataAlt = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonImportFoto = new System.Windows.Forms.Button();
            this.richTextBoxComentario = new System.Windows.Forms.RichTextBox();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCriarProposta = new System.Windows.Forms.Button();
            this.cadastro_ClienteTableAdapter = new SisEnterprise_2._0.sisenterpriseDataSetTableAdapters.Cadastro_ClienteTableAdapter();
            this.maskedTextBoxDataCad = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisenterpriseDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.maskedTextBoxDataAlt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.maskedTextBoxDataCad);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.richTextBoxComentario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 487);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Cliente";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.idvendedorDataGridViewTextBoxColumn,
            this.razaosocialDataGridViewTextBoxColumn,
            this.nomeclienteDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.logoempresaDataGridViewImageColumn,
            this.datacadastroDataGridViewTextBoxColumn,
            this.dataalteracaoDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.cadastroClienteBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(26, 335);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(663, 127);
            this.dataGridView.TabIndex = 32;
            this.dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idvendedorDataGridViewTextBoxColumn
            // 
            this.idvendedorDataGridViewTextBoxColumn.DataPropertyName = "id_vendedor";
            this.idvendedorDataGridViewTextBoxColumn.HeaderText = "id_vendedor";
            this.idvendedorDataGridViewTextBoxColumn.Name = "idvendedorDataGridViewTextBoxColumn";
            this.idvendedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // razaosocialDataGridViewTextBoxColumn
            // 
            this.razaosocialDataGridViewTextBoxColumn.DataPropertyName = "razao_social";
            this.razaosocialDataGridViewTextBoxColumn.HeaderText = "razao_social";
            this.razaosocialDataGridViewTextBoxColumn.Name = "razaosocialDataGridViewTextBoxColumn";
            // 
            // nomeclienteDataGridViewTextBoxColumn
            // 
            this.nomeclienteDataGridViewTextBoxColumn.DataPropertyName = "nome_cliente";
            this.nomeclienteDataGridViewTextBoxColumn.HeaderText = "nome_cliente";
            this.nomeclienteDataGridViewTextBoxColumn.Name = "nomeclienteDataGridViewTextBoxColumn";
            this.nomeclienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.Visible = false;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.Visible = false;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.Visible = false;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.Visible = false;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // logoempresaDataGridViewImageColumn
            // 
            this.logoempresaDataGridViewImageColumn.DataPropertyName = "logo_empresa";
            this.logoempresaDataGridViewImageColumn.HeaderText = "logo_empresa";
            this.logoempresaDataGridViewImageColumn.Name = "logoempresaDataGridViewImageColumn";
            this.logoempresaDataGridViewImageColumn.Visible = false;
            // 
            // datacadastroDataGridViewTextBoxColumn
            // 
            this.datacadastroDataGridViewTextBoxColumn.DataPropertyName = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.HeaderText = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.Name = "datacadastroDataGridViewTextBoxColumn";
            this.datacadastroDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataalteracaoDataGridViewTextBoxColumn
            // 
            this.dataalteracaoDataGridViewTextBoxColumn.DataPropertyName = "data_alteracao";
            this.dataalteracaoDataGridViewTextBoxColumn.HeaderText = "data_alteracao";
            this.dataalteracaoDataGridViewTextBoxColumn.Name = "dataalteracaoDataGridViewTextBoxColumn";
            this.dataalteracaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cadastroClienteBindingSource
            // 
            this.cadastroClienteBindingSource.DataMember = "Cadastro_Cliente";
            this.cadastroClienteBindingSource.DataSource = this.sisenterpriseDataSet;
            // 
            // sisenterpriseDataSet
            // 
            this.sisenterpriseDataSet.DataSetName = "sisenterpriseDataSet";
            this.sisenterpriseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxAtivo);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.maskedTextBoxRazao);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.maskedTextBoxCNPJ);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.maskedTextBoxNome);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.maskedTextBoxEmail);
            this.groupBox4.Controls.Add(this.maskedTextBoxCodigo);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(26, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 247);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados Empresa ";
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Location = new System.Drawing.Point(198, 42);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAtivo.TabIndex = 10;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(143, 380);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(58, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "ATIVO";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxRazao
            // 
            this.maskedTextBoxRazao.AccessibleDescription = "";
            this.maskedTextBoxRazao.AccessibleName = "";
            this.maskedTextBoxRazao.Location = new System.Drawing.Point(96, 81);
            this.maskedTextBoxRazao.Name = "maskedTextBoxRazao";
            this.maskedTextBoxRazao.Size = new System.Drawing.Size(245, 20);
            this.maskedTextBoxRazao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Razão Social:";
            // 
            // maskedTextBoxCNPJ
            // 
            this.maskedTextBoxCNPJ.AccessibleDescription = "";
            this.maskedTextBoxCNPJ.AccessibleName = "";
            this.maskedTextBoxCNPJ.Location = new System.Drawing.Point(96, 160);
            this.maskedTextBoxCNPJ.Mask = "99.999.999/9999-9";
            this.maskedTextBoxCNPJ.Name = "maskedTextBoxCNPJ";
            this.maskedTextBoxCNPJ.Size = new System.Drawing.Size(245, 20);
            this.maskedTextBoxCNPJ.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CNPJ:";
            // 
            // maskedTextBoxNome
            // 
            this.maskedTextBoxNome.AccessibleDescription = "";
            this.maskedTextBoxNome.AccessibleName = "";
            this.maskedTextBoxNome.Location = new System.Drawing.Point(96, 123);
            this.maskedTextBoxNome.Name = "maskedTextBoxNome";
            this.maskedTextBoxNome.Size = new System.Drawing.Size(245, 20);
            this.maskedTextBoxNome.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome Cliente:";
            // 
            // maskedTextBoxEmail
            // 
            this.maskedTextBoxEmail.AccessibleDescription = "";
            this.maskedTextBoxEmail.AccessibleName = "";
            this.maskedTextBoxEmail.Location = new System.Drawing.Point(96, 202);
            this.maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            this.maskedTextBoxEmail.Size = new System.Drawing.Size(245, 20);
            this.maskedTextBoxEmail.TabIndex = 5;
            // 
            // maskedTextBoxCodigo
            // 
            this.maskedTextBoxCodigo.AccessibleDescription = "";
            this.maskedTextBoxCodigo.AccessibleName = "";
            this.maskedTextBoxCodigo.Location = new System.Drawing.Point(96, 39);
            this.maskedTextBoxCodigo.Name = "maskedTextBoxCodigo";
            this.maskedTextBoxCodigo.Size = new System.Drawing.Size(84, 20);
            this.maskedTextBoxCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo Interno:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(709, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Comentario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.maskedTextBoxCidade);
            this.groupBox2.Controls.Add(this.maskedTextBoxBairro);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.maskedTextBoxEndereco);
            this.groupBox2.Controls.Add(this.maskedTextBoxEstado);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.maskedTextBoxPais);
            this.groupBox2.Controls.Add(this.maskedTextBoxCep);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(399, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 247);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(143, 380);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "ATIVO";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Bairro:";
            // 
            // maskedTextBoxCidade
            // 
            this.maskedTextBoxCidade.AccessibleDescription = "";
            this.maskedTextBoxCidade.AccessibleName = "";
            this.maskedTextBoxCidade.Location = new System.Drawing.Point(75, 71);
            this.maskedTextBoxCidade.Name = "maskedTextBoxCidade";
            this.maskedTextBoxCidade.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBoxCidade.TabIndex = 7;
            // 
            // maskedTextBoxBairro
            // 
            this.maskedTextBoxBairro.AccessibleDescription = "";
            this.maskedTextBoxBairro.AccessibleName = "";
            this.maskedTextBoxBairro.Location = new System.Drawing.Point(75, 107);
            this.maskedTextBoxBairro.Name = "maskedTextBoxBairro";
            this.maskedTextBoxBairro.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBoxBairro.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Cidade:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Endereço:";
            // 
            // maskedTextBoxEndereco
            // 
            this.maskedTextBoxEndereco.AccessibleDescription = "";
            this.maskedTextBoxEndereco.AccessibleName = "";
            this.maskedTextBoxEndereco.Location = new System.Drawing.Point(75, 36);
            this.maskedTextBoxEndereco.Name = "maskedTextBoxEndereco";
            this.maskedTextBoxEndereco.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBoxEndereco.TabIndex = 6;
            // 
            // maskedTextBoxEstado
            // 
            this.maskedTextBoxEstado.AccessibleDescription = "";
            this.maskedTextBoxEstado.AccessibleName = "";
            this.maskedTextBoxEstado.Location = new System.Drawing.Point(75, 143);
            this.maskedTextBoxEstado.Name = "maskedTextBoxEstado";
            this.maskedTextBoxEstado.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBoxEstado.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "CEP:";
            // 
            // maskedTextBoxPais
            // 
            this.maskedTextBoxPais.AccessibleDescription = "";
            this.maskedTextBoxPais.AccessibleName = "";
            this.maskedTextBoxPais.Location = new System.Drawing.Point(75, 178);
            this.maskedTextBoxPais.Name = "maskedTextBoxPais";
            this.maskedTextBoxPais.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBoxPais.TabIndex = 10;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.AccessibleDescription = "";
            this.maskedTextBoxCep.AccessibleName = "";
            this.maskedTextBoxCep.Location = new System.Drawing.Point(75, 214);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBoxCep.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "País:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estado:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(701, 284);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Data Alteração:";
            // 
            // maskedTextBoxDataAlt
            // 
            this.maskedTextBoxDataAlt.AccessibleDescription = "";
            this.maskedTextBoxDataAlt.AccessibleName = "";
            this.maskedTextBoxDataAlt.Location = new System.Drawing.Point(785, 284);
            this.maskedTextBoxDataAlt.Name = "maskedTextBoxDataAlt";
            this.maskedTextBoxDataAlt.Size = new System.Drawing.Size(112, 20);
            this.maskedTextBoxDataAlt.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxFoto);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.buttonImportFoto);
            this.groupBox3.Location = new System.Drawing.Point(712, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 205);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logo Empresa";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(14, 25);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(163, 141);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 0;
            this.pictureBoxFoto.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(143, 380);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "ATIVO";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonImportFoto
            // 
            this.buttonImportFoto.Location = new System.Drawing.Point(48, 173);
            this.buttonImportFoto.Name = "buttonImportFoto";
            this.buttonImportFoto.Size = new System.Drawing.Size(90, 26);
            this.buttonImportFoto.TabIndex = 0;
            this.buttonImportFoto.Text = "Importar Foto:";
            this.buttonImportFoto.UseVisualStyleBackColor = true;
            // 
            // richTextBoxComentario
            // 
            this.richTextBoxComentario.Location = new System.Drawing.Point(712, 335);
            this.richTextBoxComentario.Name = "richTextBoxComentario";
            this.richTextBoxComentario.Size = new System.Drawing.Size(185, 127);
            this.richTextBoxComentario.TabIndex = 2;
            this.richTextBoxComentario.Text = "";
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(488, 515);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(105, 31);
            this.buttonDeletar.TabIndex = 5;
            this.buttonDeletar.Text = "Excluir";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(362, 515);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(105, 31);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(610, 515);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(105, 31);
            this.buttonLimpar.TabIndex = 7;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCriarProposta
            // 
            this.buttonCriarProposta.Location = new System.Drawing.Point(236, 515);
            this.buttonCriarProposta.Name = "buttonCriarProposta";
            this.buttonCriarProposta.Size = new System.Drawing.Size(105, 31);
            this.buttonCriarProposta.TabIndex = 9;
            this.buttonCriarProposta.Text = "Criar proposta";
            this.buttonCriarProposta.UseVisualStyleBackColor = true;
            // 
            // cadastro_ClienteTableAdapter
            // 
            this.cadastro_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBoxDataCad
            // 
            this.maskedTextBoxDataCad.AccessibleDescription = "";
            this.maskedTextBoxDataCad.AccessibleName = "";
            this.maskedTextBoxDataCad.Location = new System.Drawing.Point(785, 252);
            this.maskedTextBoxDataCad.Name = "maskedTextBoxDataCad";
            this.maskedTextBoxDataCad.Size = new System.Drawing.Size(112, 20);
            this.maskedTextBoxDataCad.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(701, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Data Cadastro:";
            // 
            // FormCadCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 560);
            this.Controls.Add(this.buttonCriarProposta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonDeletar);
            this.Name = "FormCadCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.FormCadCli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisenterpriseDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCriarProposta;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRazao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxComentario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCNPJ;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonImportFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBairro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndereco;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataAlt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.DataGridView dataGridView;
        private sisenterpriseDataSet sisenterpriseDataSet;
        private System.Windows.Forms.BindingSource cadastroClienteBindingSource;
        private sisenterpriseDataSetTableAdapters.Cadastro_ClienteTableAdapter cadastro_ClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaosocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn logoempresaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataalteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataCad;
    }
}