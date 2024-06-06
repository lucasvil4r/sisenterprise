using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SisEnterprise_2._0.Forms
{
    public partial class FormCadProd : Form
    {
        //Controla ID em buffer
        int ProdId = 0;
        public FormCadProd()
        {
            InitializeComponent();
        }

        private void FormCadProd_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sisenterpriseDataSet.Cadastro_Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_FornecedoresTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Fornecedores);
            // TODO: esta linha de código carrega dados na tabela 'sisenterpriseDataSet.Cadastro_Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_ProdutosTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Produtos);

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxDescricao.Text == "")
            {
                MessageBox.Show("Descrição Obrigatorio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja salvar esses dados ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (ProdId != 0)
            {
                bool returnFunction = SaveProduto(ProdId);
                if (returnFunction) { MessageBox.Show("Produto salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Não foi possível salvar, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                bool returnFunction = InsertProduto();
                if (returnFunction) { MessageBox.Show("Produto adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Não foi possível adiconar produto, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            ClearData();
            SetDataInGridView();
        }

        private bool InsertProduto()
        {
            using (var db = new ModelContext())
            {
                var produto = new Cadastro_Produtos();
                if (produto != null)
                {
                    //produto.id_fornecedor = maskedTextBoxFabr.Text;
                    produto.descricao = maskedTextBoxDescricao.Text;
                    produto.ncm = maskedTextBoxNCM.Text;
                    produto.icms = decimal.Parse(maskedTextBoxICMS.Text);
                    produto.preco = decimal.Parse(maskedTextBoxPreco.Text);
                    produto.desconto = decimal.Parse(maskedTextBoxDesconto.Text);
                    produto.obs = richTextBoxComentario.Text;
                    produto.data_cadastro = DateTime.Now;
                    produto.status = "1";
                    produto.id_fornecedor = (int)ComboBoxFornecedor.SelectedValue;
                    db.Cadastro_Produtos.Add(produto);

                    try
                    {
                        db.SaveChanges();
                        return true;
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var entityValidationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in entityValidationErrors.ValidationErrors)
                            {
                                MessageBox.Show($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        return false;
                    }
                }
                else { return false; }
            }
        }

        private bool SaveProduto(int Id)
        {
            using (var db = new ModelContext())
            {
                var produto = db.Cadastro_Produtos.FirstOrDefault(x => x.id_produto == Id);
                if (produto != null)
                {
                    produto.descricao = maskedTextBoxDescricao.Text;
                    produto.status = checkBox1.Checked ? "1" : "0";
                    produto.ncm = maskedTextBoxNCM.Text;
                    produto.icms = decimal.Parse(maskedTextBoxICMS.Text);
                    produto.preco = decimal.Parse(maskedTextBoxPreco.Text);
                    produto.desconto = decimal.Parse(maskedTextBoxDesconto.Text);
                    produto.obs = richTextBoxComentario.Text;
                    produto.data_alteracao = DateTime.Now;

                    try
                    {
                        db.SaveChanges();
                        return true;
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var entityValidationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in entityValidationErrors.ValidationErrors)
                            {
                                MessageBox.Show($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        return false;
                    }
                }
                else { return false; }
            }
        }

        private bool DeleteProduto(int Id)
        {
            using (var db = new ModelContext())
            {
                var produto = db.Cadastro_Produtos.FirstOrDefault(x => x.id_produto == Id);
                if (produto != null)
                {
                    db.Cadastro_Produtos.Remove(produto);
                    try
                    {
                        db.SaveChanges();
                        return true;
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var entityValidationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in entityValidationErrors.ValidationErrors)
                            {
                                MessageBox.Show($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        return false;
                    }
                }
                else { return false; }
            }
        }

        private void ClearData()
        {
            maskedTextBoxCodigo.Text = string.Empty;
            maskedTextBoxDescricao.Text = string.Empty;
            maskedTextBoxNCM.Text = string.Empty;
            maskedTextBoxICMS.Text = string.Empty;
            maskedTextBoxPreco.Text = string.Empty;
            maskedTextBoxDesconto.Text = string.Empty;
            richTextBoxComentario.Text = string.Empty;
            maskedTextBoxDtCad.Text = string.Empty;
            maskedTextBoxDtAlt.Text = string.Empty;

            ProdId = 0;
        }

        private void SetDataInGridView()
        {
            using (var db = new ModelContext())
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = db.Cadastro_Produtos.ToList<Cadastro_Produtos>();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (ProdId != 0)
            {
                bool returnFunction = DeleteProduto(ProdId);
                if (returnFunction) { MessageBox.Show("Produto excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Não foi possível excluir, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Não foi possível excluir, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearData();
            SetDataInGridView();
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            ClearData();
            SetDataInGridView();
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            ClearData();
            ProdId = Convert.ToInt32(dataGridView.CurrentRow.Cells["idprodutoDataGridViewTextBoxColumn"].Value);
            if (dataGridView.CurrentCell.RowIndex != -1 && ProdId > 0)
            {
                using (var db = new ModelContext())
                {
                    var produto = new Cadastro_Produtos();
                    produto = db.Cadastro_Produtos.Where(x => x.id_produto == ProdId).FirstOrDefault();

                    maskedTextBoxCodigo.Text = produto.id_produto.ToString();
                    maskedTextBoxDescricao.Text = produto.descricao.ToString();
                    maskedTextBoxNCM.Text = produto.ncm.ToString();
                    maskedTextBoxICMS.Text = produto.icms.ToString();
                    maskedTextBoxPreco.Text = produto.preco.ToString();
                    maskedTextBoxDesconto.Text = produto.desconto.ToString();
                    richTextBoxComentario.Text = produto.obs.ToString();
                    maskedTextBoxDtCad.Text = produto.data_cadastro.ToString();
                    maskedTextBoxDtAlt.Text = produto.data_alteracao.ToString();
                    ComboBoxFornecedor.SelectedValue = produto.id_fornecedor;

                    bool valor = (produto.status == "1") ? true : false;
                    checkBox1.Checked = valor;  
                }
            }
        }
    }
}
