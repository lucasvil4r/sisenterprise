namespace SisEnterprise_2._0.Forms
{
    partial class FormCadProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadProd));
            this.Produto = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxDescricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxDtCad = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxDtAlt = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxICMS = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxNCM = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxDesconto = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxPreco = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBoxComentario = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icmsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataalteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisenterpriseDataSet = new SisEnterprise_2._0.sisenterpriseDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deletetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cadastro_ProdutosTableAdapter = new SisEnterprise_2._0.sisenterpriseDataSetTableAdapters.Cadastro_ProdutosTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboBoxDept = new System.Windows.Forms.ComboBox();
            this.Produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisenterpriseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Produto
            // 
            this.Produto.Controls.Add(this.label10);
            this.Produto.Controls.Add(this.ComboBoxDept);
            this.Produto.Controls.Add(this.maskedTextBoxDescricao);
            this.Produto.Controls.Add(this.label8);
            this.Produto.Controls.Add(this.maskedTextBoxDtCad);
            this.Produto.Controls.Add(this.label9);
            this.Produto.Controls.Add(this.maskedTextBoxDtAlt);
            this.Produto.Controls.Add(this.label6);
            this.Produto.Controls.Add(this.maskedTextBoxICMS);
            this.Produto.Controls.Add(this.label7);
            this.Produto.Controls.Add(this.maskedTextBoxNCM);
            this.Produto.Controls.Add(this.label5);
            this.Produto.Controls.Add(this.maskedTextBoxDesconto);
            this.Produto.Controls.Add(this.label4);
            this.Produto.Controls.Add(this.maskedTextBoxPreco);
            this.Produto.Controls.Add(this.checkBox1);
            this.Produto.Controls.Add(this.label12);
            this.Produto.Controls.Add(this.richTextBoxComentario);
            this.Produto.Controls.Add(this.label2);
            this.Produto.Controls.Add(this.label1);
            this.Produto.Controls.Add(this.maskedTextBoxCodigo);
            this.Produto.Location = new System.Drawing.Point(21, 12);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(498, 284);
            this.Produto.TabIndex = 0;
            this.Produto.TabStop = false;
            this.Produto.Text = "Produto";
            // 
            // maskedTextBoxDescricao
            // 
            this.maskedTextBoxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskedTextBoxDescricao.Location = new System.Drawing.Point(76, 81);
            this.maskedTextBoxDescricao.Name = "maskedTextBoxDescricao";
            this.maskedTextBoxDescricao.Size = new System.Drawing.Size(403, 20);
            this.maskedTextBoxDescricao.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Dt Cadastro:";
            // 
            // maskedTextBoxDtCad
            // 
            this.maskedTextBoxDtCad.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxDtCad.Enabled = false;
            this.maskedTextBoxDtCad.Location = new System.Drawing.Point(404, 120);
            this.maskedTextBoxDtCad.Mask = "00/00/0000";
            this.maskedTextBoxDtCad.Name = "maskedTextBoxDtCad";
            this.maskedTextBoxDtCad.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxDtCad.TabIndex = 45;
            this.maskedTextBoxDtCad.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxDtCad.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Dt Alteração:";
            // 
            // maskedTextBoxDtAlt
            // 
            this.maskedTextBoxDtAlt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxDtAlt.Enabled = false;
            this.maskedTextBoxDtAlt.Location = new System.Drawing.Point(404, 160);
            this.maskedTextBoxDtAlt.Mask = "00/00/0000";
            this.maskedTextBoxDtAlt.Name = "maskedTextBoxDtAlt";
            this.maskedTextBoxDtAlt.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxDtAlt.TabIndex = 43;
            this.maskedTextBoxDtAlt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxDtAlt.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "ICMS:";
            // 
            // maskedTextBoxICMS
            // 
            this.maskedTextBoxICMS.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxICMS.Location = new System.Drawing.Point(245, 119);
            this.maskedTextBoxICMS.Mask = "99,99%";
            this.maskedTextBoxICMS.Name = "maskedTextBoxICMS";
            this.maskedTextBoxICMS.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxICMS.TabIndex = 3;
            this.maskedTextBoxICMS.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "NCM:";
            // 
            // maskedTextBoxNCM
            // 
            this.maskedTextBoxNCM.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxNCM.Location = new System.Drawing.Point(76, 119);
            this.maskedTextBoxNCM.Mask = "00000000";
            this.maskedTextBoxNCM.Name = "maskedTextBoxNCM";
            this.maskedTextBoxNCM.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBoxNCM.TabIndex = 2;
            this.maskedTextBoxNCM.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Desconto:";
            // 
            // maskedTextBoxDesconto
            // 
            this.maskedTextBoxDesconto.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxDesconto.Location = new System.Drawing.Point(245, 159);
            this.maskedTextBoxDesconto.Mask = "99,99%";
            this.maskedTextBoxDesconto.Name = "maskedTextBoxDesconto";
            this.maskedTextBoxDesconto.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxDesconto.TabIndex = 5;
            this.maskedTextBoxDesconto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Preço:";
            // 
            // maskedTextBoxPreco
            // 
            this.maskedTextBoxPreco.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxPreco.Location = new System.Drawing.Point(76, 159);
            this.maskedTextBoxPreco.Name = "maskedTextBoxPreco";
            this.maskedTextBoxPreco.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxPreco.TabIndex = 4;
            this.maskedTextBoxPreco.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(162, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Comentario:";
            // 
            // richTextBoxComentario
            // 
            this.richTextBoxComentario.Location = new System.Drawing.Point(76, 212);
            this.richTextBoxComentario.Name = "richTextBoxComentario";
            this.richTextBoxComentario.Size = new System.Drawing.Size(403, 46);
            this.richTextBoxComentario.TabIndex = 6;
            this.richTextBoxComentario.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // maskedTextBoxCodigo
            // 
            this.maskedTextBoxCodigo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxCodigo.Enabled = false;
            this.maskedTextBoxCodigo.Location = new System.Drawing.Point(76, 33);
            this.maskedTextBoxCodigo.Name = "maskedTextBoxCodigo";
            this.maskedTextBoxCodigo.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxCodigo.TabIndex = 0;
            this.maskedTextBoxCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodutoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.ncmDataGridViewTextBoxColumn,
            this.icmsDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn,
            this.dataalteracaoDataGridViewTextBoxColumn,
            this.idfornecedorDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.cadastroProdutosBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(18, 31);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(461, 138);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseClick);
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            this.obsDataGridViewTextBoxColumn.DataPropertyName = "obs";
            this.obsDataGridViewTextBoxColumn.HeaderText = "obs";
            this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            this.obsDataGridViewTextBoxColumn.Visible = false;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.Visible = false;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "desconto";
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            this.descontoDataGridViewTextBoxColumn.Visible = false;
            // 
            // ncmDataGridViewTextBoxColumn
            // 
            this.ncmDataGridViewTextBoxColumn.DataPropertyName = "ncm";
            this.ncmDataGridViewTextBoxColumn.HeaderText = "ncm";
            this.ncmDataGridViewTextBoxColumn.Name = "ncmDataGridViewTextBoxColumn";
            this.ncmDataGridViewTextBoxColumn.Visible = false;
            // 
            // icmsDataGridViewTextBoxColumn
            // 
            this.icmsDataGridViewTextBoxColumn.DataPropertyName = "icms";
            this.icmsDataGridViewTextBoxColumn.HeaderText = "icms";
            this.icmsDataGridViewTextBoxColumn.Name = "icmsDataGridViewTextBoxColumn";
            this.icmsDataGridViewTextBoxColumn.Visible = false;
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
            // idfornecedorDataGridViewTextBoxColumn
            // 
            this.idfornecedorDataGridViewTextBoxColumn.DataPropertyName = "id_fornecedor";
            this.idfornecedorDataGridViewTextBoxColumn.HeaderText = "id_fornecedor";
            this.idfornecedorDataGridViewTextBoxColumn.Name = "idfornecedorDataGridViewTextBoxColumn";
            this.idfornecedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // cadastroProdutosBindingSource
            // 
            this.cadastroProdutosBindingSource.DataMember = "Cadastro_Produtos";
            this.cadastroProdutosBindingSource.DataSource = this.sisenterpriseDataSet;
            // 
            // sisenterpriseDataSet
            // 
            this.sisenterpriseDataSet.DataSetName = "sisenterpriseDataSet";
            this.sisenterpriseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(21, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Produto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bindingNavigator1);
            this.groupBox2.Location = new System.Drawing.Point(230, 512);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(80, 41);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alterações";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripButton,
            this.novoToolStripButton,
            this.deletetoolStripButton});
            this.bindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(74, 23);
            this.bindingNavigator1.Stretch = true;
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.novoToolStripButton.Text = "&Limpar";
            this.novoToolStripButton.Click += new System.EventHandler(this.novoToolStripButton_Click);
            // 
            // deletetoolStripButton
            // 
            this.deletetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deletetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deletetoolStripButton.Image")));
            this.deletetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletetoolStripButton.Name = "deletetoolStripButton";
            this.deletetoolStripButton.Size = new System.Drawing.Size(23, 20);
            this.deletetoolStripButton.Text = "&Deletar";
            this.deletetoolStripButton.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // cadastro_ProdutosTableAdapter
            // 
            this.cadastro_ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Fabricante:";
            // 
            // ComboBoxDept
            // 
            this.ComboBoxDept.DisplayMember = "nome";
            this.ComboBoxDept.FormattingEnabled = true;
            this.ComboBoxDept.Location = new System.Drawing.Point(352, 33);
            this.ComboBoxDept.Name = "ComboBoxDept";
            this.ComboBoxDept.Size = new System.Drawing.Size(127, 21);
            this.ComboBoxDept.TabIndex = 48;
            this.ComboBoxDept.ValueMember = "id_departamento";
            // 
            // FormCadProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Produto);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(551, 599);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(551, 599);
            this.Name = "FormCadProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.FormCadProd_Load);
            this.Produto.ResumeLayout(false);
            this.Produto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisenterpriseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBoxComentario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPreco;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDtCad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDtAlt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxICMS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNCM;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private sisenterpriseDataSet sisenterpriseDataSet;
        private System.Windows.Forms.BindingSource cadastroProdutosBindingSource;
        private sisenterpriseDataSetTableAdapters.Cadastro_ProdutosTableAdapter cadastro_ProdutosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icmsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataalteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton deletetoolStripButton;
        private System.Windows.Forms.TextBox maskedTextBoxDescricao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ComboBoxDept;
    }
}