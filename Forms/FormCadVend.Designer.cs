namespace SisEnterprise_2._0.Forms
{
    partial class FormCadVend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadVend));
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cadastroFornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisenterpriseDataSet = new SisEnterprise_2._0.sisenterpriseDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deletetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idvendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomevendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailvendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telvendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroVendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastro_FornecedoresTableAdapter = new SisEnterprise_2._0.sisenterpriseDataSetTableAdapters.Cadastro_FornecedoresTableAdapter();
            this.cadastro_ProdutosTableAdapter = new SisEnterprise_2._0.sisenterpriseDataSetTableAdapters.Cadastro_ProdutosTableAdapter();
            this.maskedTextBoxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxNome = new System.Windows.Forms.TextBox();
            this.Produto = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cadastro_VendedorTableAdapter = new SisEnterprise_2._0.sisenterpriseDataSetTableAdapters.Cadastro_VendedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisenterpriseDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroVendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroProdutosBindingSource)).BeginInit();
            this.Produto.SuspendLayout();
            this.SuspendLayout();
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
            // cadastroFornecedoresBindingSource
            // 
            this.cadastroFornecedoresBindingSource.DataMember = "Cadastro_Fornecedores";
            this.cadastroFornecedoresBindingSource.DataSource = this.sisenterpriseDataSet;
            // 
            // sisenterpriseDataSet
            // 
            this.sisenterpriseDataSet.DataSetName = "sisenterpriseDataSet";
            this.sisenterpriseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bindingNavigator1);
            this.groupBox2.Location = new System.Drawing.Point(121, 457);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(80, 41);
            this.groupBox2.TabIndex = 5;
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
            this.deletetoolStripButton.Click += new System.EventHandler(this.deletetoolStripButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(15, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Vendedores";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvendedorDataGridViewTextBoxColumn,
            this.nomevendedorDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.emailvendedorDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.telvendedorDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.cadastroVendedorBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(23, 26);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(242, 114);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseClick);
            // 
            // idvendedorDataGridViewTextBoxColumn
            // 
            this.idvendedorDataGridViewTextBoxColumn.DataPropertyName = "id_vendedor";
            this.idvendedorDataGridViewTextBoxColumn.HeaderText = "id_vendedor";
            this.idvendedorDataGridViewTextBoxColumn.Name = "idvendedorDataGridViewTextBoxColumn";
            this.idvendedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomevendedorDataGridViewTextBoxColumn
            // 
            this.nomevendedorDataGridViewTextBoxColumn.DataPropertyName = "nome_vendedor";
            this.nomevendedorDataGridViewTextBoxColumn.HeaderText = "nome_vendedor";
            this.nomevendedorDataGridViewTextBoxColumn.Name = "nomevendedorDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailvendedorDataGridViewTextBoxColumn
            // 
            this.emailvendedorDataGridViewTextBoxColumn.DataPropertyName = "email_vendedor";
            this.emailvendedorDataGridViewTextBoxColumn.HeaderText = "email_vendedor";
            this.emailvendedorDataGridViewTextBoxColumn.Name = "emailvendedorDataGridViewTextBoxColumn";
            this.emailvendedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // telvendedorDataGridViewTextBoxColumn
            // 
            this.telvendedorDataGridViewTextBoxColumn.DataPropertyName = "telvendedor";
            this.telvendedorDataGridViewTextBoxColumn.HeaderText = "telvendedor";
            this.telvendedorDataGridViewTextBoxColumn.Name = "telvendedorDataGridViewTextBoxColumn";
            this.telvendedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // cadastroVendedorBindingSource
            // 
            this.cadastroVendedorBindingSource.DataMember = "Cadastro_Vendedor";
            this.cadastroVendedorBindingSource.DataSource = this.sisenterpriseDataSet;
            // 
            // cadastroProdutosBindingSource
            // 
            this.cadastroProdutosBindingSource.DataMember = "Cadastro_Produtos";
            this.cadastroProdutosBindingSource.DataSource = this.sisenterpriseDataSet;
            // 
            // cadastro_FornecedoresTableAdapter
            // 
            this.cadastro_FornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // cadastro_ProdutosTableAdapter
            // 
            this.cadastro_ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBoxCodigo
            // 
            this.maskedTextBoxCodigo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxCodigo.Enabled = false;
            this.maskedTextBoxCodigo.Location = new System.Drawing.Point(75, 28);
            this.maskedTextBoxCodigo.Name = "maskedTextBoxCodigo";
            this.maskedTextBoxCodigo.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxCodigo.TabIndex = 0;
            this.maskedTextBoxCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // maskedTextBoxEmail
            // 
            this.maskedTextBoxEmail.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxEmail.Location = new System.Drawing.Point(75, 149);
            this.maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            this.maskedTextBoxEmail.Size = new System.Drawing.Size(186, 20);
            this.maskedTextBoxEmail.TabIndex = 3;
            this.maskedTextBoxEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "E-mail:";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(75, 109);
            this.maskedTextBoxCPF.Mask = "999.999.999-99";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(186, 20);
            this.maskedTextBoxCPF.TabIndex = 2;
            this.maskedTextBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "CPF:";
            // 
            // maskedTextBoxNome
            // 
            this.maskedTextBoxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskedTextBoxNome.Location = new System.Drawing.Point(75, 68);
            this.maskedTextBoxNome.Name = "maskedTextBoxNome";
            this.maskedTextBoxNome.Size = new System.Drawing.Size(186, 20);
            this.maskedTextBoxNome.TabIndex = 1;
            // 
            // Produto
            // 
            this.Produto.Controls.Add(this.label3);
            this.Produto.Controls.Add(this.maskedTextBoxEmpresa);
            this.Produto.Controls.Add(this.label4);
            this.Produto.Controls.Add(this.maskedTextBoxTelefone);
            this.Produto.Controls.Add(this.maskedTextBoxNome);
            this.Produto.Controls.Add(this.label6);
            this.Produto.Controls.Add(this.maskedTextBoxCPF);
            this.Produto.Controls.Add(this.label5);
            this.Produto.Controls.Add(this.maskedTextBoxEmail);
            this.Produto.Controls.Add(this.label2);
            this.Produto.Controls.Add(this.label1);
            this.Produto.Controls.Add(this.maskedTextBoxCodigo);
            this.Produto.Location = new System.Drawing.Point(12, 12);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(289, 266);
            this.Produto.TabIndex = 3;
            this.Produto.TabStop = false;
            this.Produto.Text = "Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Empresa:";
            // 
            // maskedTextBoxEmpresa
            // 
            this.maskedTextBoxEmpresa.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBoxEmpresa.Location = new System.Drawing.Point(75, 187);
            this.maskedTextBoxEmpresa.Name = "maskedTextBoxEmpresa";
            this.maskedTextBoxEmpresa.Size = new System.Drawing.Size(186, 20);
            this.maskedTextBoxEmpresa.TabIndex = 4;
            this.maskedTextBoxEmpresa.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Telefone:";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(75, 227);
            this.maskedTextBoxTelefone.Mask = "(99) 9 9999-9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(186, 20);
            this.maskedTextBoxTelefone.TabIndex = 5;
            this.maskedTextBoxTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cadastro_VendedorTableAdapter
            // 
            this.cadastro_VendedorTableAdapter.ClearBeforeFill = true;
            // 
            // FormCadVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Produto);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(328, 544);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(328, 544);
            this.Name = "FormCadVend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vendedor";
            this.Load += new System.EventHandler(this.FormCadVend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisenterpriseDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroVendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroProdutosBindingSource)).EndInit();
            this.Produto.ResumeLayout(false);
            this.Produto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.BindingSource cadastroFornecedoresBindingSource;
        private sisenterpriseDataSet sisenterpriseDataSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton deletetoolStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource cadastroProdutosBindingSource;
        private sisenterpriseDataSetTableAdapters.Cadastro_FornecedoresTableAdapter cadastro_FornecedoresTableAdapter;
        private sisenterpriseDataSetTableAdapters.Cadastro_ProdutosTableAdapter cadastro_ProdutosTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maskedTextBoxNome;
        private System.Windows.Forms.GroupBox Produto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource cadastroVendedorBindingSource;
        private sisenterpriseDataSetTableAdapters.Cadastro_VendedorTableAdapter cadastro_VendedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomevendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailvendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telvendedorDataGridViewTextBoxColumn;
    }
}