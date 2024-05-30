using System;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SisEnterprise_2._0.Forms
{
    public partial class FormCadProp : Form
    {
        //Controla ID em buffer
        int PropostaId;

        public FormCadProp()
        {
            InitializeComponent();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar esses dados ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (PropostaId != 0)
            {
                bool returnFunction = SaveProposta(PropostaId);
                if (returnFunction) { MessageBox.Show("Proposta salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Não foi possível salvar, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                bool returnFunction = InsertProposta();
                if (returnFunction) { MessageBox.Show("Proposta adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Não foi possível adiconar vendedor, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            ClearData();
            SetDataInGridView();
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            ClearData();
            SetDataInGridView();
        }

        private void deletetoolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (PropostaId != 0)
            {
                bool returnFunction = DeleteProposta(PropostaId);
                if (returnFunction) { MessageBox.Show("Proposta excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Não foi possível excluir, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Não foi possível excluir, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearData();
            SetDataInGridView();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCodProposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCodCliente_TextChanged(object sender, EventArgs e)
        {
            ChangedCliente();
        }

        private void maskedTextBoxCodVendedor_TextChanged(object sender, EventArgs e)
        {
            ChangedVendedor();
        }

        private void ChangedVendedor()
        {
            int VendedorId;
            if (int.TryParse(maskedTextBoxCodVendedor.Text, out VendedorId))
            {
                // A conversão foi bem-sucedida
                if (VendedorId > 0)
                {
                    using (var db = new ModelContext())
                    {
                        var vendedor = new Cadastro_Vendedor();
                        vendedor = db.Cadastro_Vendedor.Where(x => x.id_vendedor == VendedorId).FirstOrDefault();

                        if (vendedor != null)
                        {
                            textBoxNomeVendedor.Text = vendedor.nome_vendedor.ToString();
                            maskedTextBoxCPFVendedor.Text = vendedor.cpf.ToString();
                            maskedTextBoxEmailVendedor.Text = vendedor.email_vendedor.ToString();
                            maskedTextBoxEmpVendedor.Text = vendedor.empresa.ToString();
                            maskedTextBoxTelefoneVendedor.Text = vendedor.telvendedor.ToString();
                        }
                    }
                }
            }
            else
            {
                textBoxNomeVendedor.Text = string.Empty;
                maskedTextBoxCPFVendedor.Text = string.Empty;
                maskedTextBoxEmailVendedor.Text = string.Empty;
                maskedTextBoxEmpVendedor.Text = string.Empty;
                maskedTextBoxTelefoneVendedor.Text = string.Empty;
            }
        }
        private void ChangedCliente()
        {
            int ClienteId;
            if (int.TryParse(maskedTextBoxCodCliente.Text, out ClienteId))
            {
                // A conversão foi bem-sucedida
                if (ClienteId > 0)
                {
                    using (var db = new ModelContext())
                    {
                        var cliente = new Cadastro_Cliente();
                        cliente = db.Cadastro_Cliente.Where(x => x.id_cliente == ClienteId).FirstOrDefault();

                        if (cliente != null)
                        {
                            maskedTextBoxRazaoSocialCliente.Text = cliente.razao_social;
                            maskedTextBoxNomeCliente.Text = cliente.nome_cliente;
                            maskedTextBoxCNPJCliente.Text = cliente.cnpj;
                            maskedTextBoxEstadoCliente.Text = cliente.estado;
                            maskedTextBoxPaisCliente.Text = cliente.pais;
                            maskedTextBoxEnderecoCliente.Text = cliente.endereco;
                            maskedTextBoxBairroCliente.Text = cliente.bairro;
                            maskedTextBoxCidadeCliente.Text = cliente.cidade;
                            maskedTextBoxEmailCliente.Text = cliente.email;
                            maskedTextBoxCEPCliente.Text = cliente.cep;
                        }
                    }
                }
            } 
            else
            {
                maskedTextBoxRazaoSocialCliente.Text = string.Empty;
                maskedTextBoxNomeCliente.Text = string.Empty;          
                maskedTextBoxCNPJCliente.Text = string.Empty;
                maskedTextBoxEstadoCliente.Text = string.Empty;
                maskedTextBoxPaisCliente.Text = string.Empty;
                maskedTextBoxEnderecoCliente.Text = string.Empty;
                maskedTextBoxBairroCliente.Text = string.Empty;
                maskedTextBoxCidadeCliente.Text = string.Empty;
                maskedTextBoxEmailCliente.Text = string.Empty;
                maskedTextBoxCEPCliente.Text = string.Empty;
            }
        }

        private void FormCadProp_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sisenterpriseDataSet.Item_Proposta'. Você pode movê-la ou removê-la conforme necessário.
            this.item_PropostaTableAdapter.Fill(this.sisenterpriseDataSet.Item_Proposta);
            // TODO: esta linha de código carrega dados na tabela 'sisenterpriseDataSet.Cadastro_Proposta'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_PropostaTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Proposta);
            // TODO: esta linha de código carrega dados na tabela 'sisenterpriseDataSet.Cadastro_Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_ProdutosTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Produtos);
        }

        private void ClearData()
        {
            // Group box prop
            maskedTextBoxCodProposta.Text = string.Empty;
            textBoxProjetoProposta.Text = string.Empty;
            textBoxDolarProposta.Text = string.Empty;
            textBoxProbaProposta.Text = string.Empty;
            textBoxEstFatProposta.Text = string.Empty;
            maskedTextBoxDataValidadeProposta.Text = string.Empty;

            // outher
            maskedTextBoxCodVendedor.Text = string.Empty;
            maskedTextBoxCodCliente.Text = string.Empty;

            PropostaId = 0;

            dataGridViewItmProp.Rows.Clear();

            CalcularTotaisGridItm();
            ChangedCliente();
            ChangedVendedor();
        }

        private void SetDataInGridView()
        {
            using (var db = new ModelContext())
            {
                dataGridViewListaProp.AutoGenerateColumns = false;
                dataGridViewListaProp.DataSource = db.Cadastro_Proposta.ToList<Cadastro_Proposta>();
            }
        }

        private bool InsertProposta()
        {
            using (var db = new ModelContext())
            {
                var proposta = new Cadastro_Proposta();
                if (proposta != null)
                {
                    proposta.projeto = textBoxProjetoProposta.Text;
                    proposta.cotacao_dolar = decimal.Parse(textBoxDolarProposta.Text);
                    proposta.probabilidade = Int32.Parse(textBoxProbaProposta.Text);
                    proposta.estado_faturamento = textBoxEstFatProposta.Text;
                    proposta.validade = DateTime.Now;

                    // outher
                    proposta.id_vendedor = Int32.Parse(maskedTextBoxCodVendedor.Text);
                    proposta.id_cliente = Int32.Parse(maskedTextBoxCodCliente.Text);
                    db.Cadastro_Proposta.Add(proposta);


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

        private bool SaveProposta(int Id)
        {
            using (var db = new ModelContext())
            {
                var proposta = db.Cadastro_Proposta.FirstOrDefault(x => x.id_proposta == Id);
                if (proposta != null)
                {
                    proposta.projeto = textBoxProjetoProposta.Text;
                    proposta.cotacao_dolar = decimal.Parse(textBoxDolarProposta.Text);
                    proposta.probabilidade = Int32.Parse(textBoxProbaProposta.Text);
                    proposta.estado_faturamento = textBoxEstFatProposta.Text;
                    proposta.validade = DateTime.Now;

                    // outher
                    proposta.id_vendedor = Int32.Parse(maskedTextBoxCodVendedor.Text);
                    proposta.id_cliente = Int32.Parse(maskedTextBoxCodCliente.Text);

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

        private bool DeleteProposta(int Id)
        {
            using (var db = new ModelContext())
            {
                var proposta = db.Cadastro_Proposta.FirstOrDefault(x => x.id_proposta == Id);
                if (proposta != null)
                {
                    db.Cadastro_Proposta.Remove(proposta);
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

        private void dataGridViewListaProp_MouseClick(object sender, MouseEventArgs e)
        {
            ClearData();
            PropostaId = Convert.ToInt32(dataGridViewListaProp.CurrentRow.Cells["idpropostaDataGridViewTextBoxColumn"].Value);
            if (dataGridViewListaProp.CurrentCell.RowIndex != -1 && PropostaId > 0)
            {
                using (var db = new ModelContext())
                {
                    var proposta = new Cadastro_Proposta();
                    proposta = db.Cadastro_Proposta.Where(x => x.id_proposta == PropostaId).FirstOrDefault();

                    // Group box prop
                    maskedTextBoxCodProposta.Text = proposta.id_proposta.ToString();
                    textBoxProjetoProposta.Text = proposta.projeto.ToString();
                    textBoxDolarProposta.Text = proposta.cotacao_dolar.ToString();
                    textBoxProbaProposta.Text = proposta.probabilidade.ToString();
                    textBoxEstFatProposta.Text = proposta.estado_faturamento.ToString();
                    maskedTextBoxDataValidadeProposta.Text = proposta.validade.ToString();

                    // outher
                    maskedTextBoxCodVendedor.Text = proposta.id_vendedor.ToString();
                    maskedTextBoxCodCliente.Text = proposta.id_cliente.ToString();

                    ChangedCliente();
                    ChangedVendedor();
                }
            }
        }

        private void dataGridViewItmProp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewItmProp.Columns[e.ColumnIndex].Name == "Codigo")
            {
                // Obtenha o novo valor da célula na coluna "Codigo"
                var ItmGridProdId = dataGridViewItmProp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                int ItmProdId = Convert.ToInt32(ItmGridProdId);
                if (ItmProdId == 0){return; }

                using (var db = new ModelContext())
                {
                    var produto = new Cadastro_Produtos();
                    produto = db.Cadastro_Produtos.Where(x => x.id_produto == ItmProdId).FirstOrDefault();

                    if (produto == null)
                    {
                        MessageBox.Show("Produto não existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                    // Altere os valores de outras células na mesma linha
                    var ColumnIndexDescricao = dataGridViewItmProp.Columns["Descricao"].Index;
                    var ColumnIndexICMS = dataGridViewItmProp.Columns["ICMS"].Index;
                    var ColumnIndexNCM = dataGridViewItmProp.Columns["NCM"].Index;
                    var ColumnIndexPreco = dataGridViewItmProp.Columns["Preco"].Index;
                    var ColumnIndexDesconto = dataGridViewItmProp.Columns["Desconto"].Index;

                    dataGridViewItmProp.Rows[e.RowIndex].Cells[ColumnIndexDescricao].Value = produto.descricao.ToString();
                    dataGridViewItmProp.Rows[e.RowIndex].Cells[ColumnIndexICMS].Value = produto.icms.ToString();
                    dataGridViewItmProp.Rows[e.RowIndex].Cells[ColumnIndexNCM].Value = produto.ncm.ToString();
                    dataGridViewItmProp.Rows[e.RowIndex].Cells[ColumnIndexPreco].Value = produto.preco.ToString();
                    dataGridViewItmProp.Rows[e.RowIndex].Cells[ColumnIndexDesconto].Value = produto.desconto.ToString();
                }
                
                CalcularTotaisGridItm();
            }
        }

        private void CalcularTotaisGridItm()
        {
            double somaTotal = 0;
            double somaDesconto = 0;

            // Percorra todas as linhas do DataGridView
            foreach (DataGridViewRow row in dataGridViewItmProp.Rows)
            {
                if (row.Cells["Preco"].Value != null)
                {
                    double valor;
                    if (double.TryParse(row.Cells["Preco"].Value.ToString(), out valor))
                    {
                        // Some os valores
                        somaTotal += valor;
                    }
                }

                if (row.Cells["Desconto"].Value != null)
                {
                    double valor;
                    if (double.TryParse(row.Cells["Desconto"].Value.ToString(), out valor))
                    {
                        // Some os valores
                        somaDesconto += valor;
                    }
                }
            }

            // Calcula total com desconto
            somaTotal -= somaDesconto;

            // Exiba o resultado na TextBox
            maskedTextTotal.Text = somaTotal.ToString();

            // Exiba o resultado na TextBox
            maskedTextBoxTotalDesconto.Text = somaDesconto.ToString();
        }
    }
}
