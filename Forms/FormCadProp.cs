using System;
using System.IO;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;


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
            if (textBoxProjetoProposta.Text.Trim() == "")
            {
                MessageBox.Show("Projeto Obrigatorio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (maskedTextBoxCodVendedor.Text.Trim() == "")
            {
                MessageBox.Show("Vendedor Obrigatorio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (maskedTextBoxCodCliente.Text.Trim() == "")
            {
                MessageBox.Show("Cliente Obrigatorio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja salvar esses dados ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (PropostaId != 0)
            {
                bool returnFunction = SaveProposta(PropostaId);
                this.SaveItemProposta(PropostaId);
                if (returnFunction) { MessageBox.Show("Proposta salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Não foi possível salvar, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                int idProp = InsertProposta();
                this.SaveItemProposta(idProp);
                if (idProp != 0) { MessageBox.Show("Proposta adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
            if (PropostaId == 0)
            {
                MessageBox.Show("Nenhuma proposta foi selecionado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Process.Start(CreatePropostaHtml());
        }

        private string CreatePropostaHtml()
        {
            // Carregue o conteúdo do arquivo HTML (substitua pelo seu caminho de arquivo real)
            string htmlTemplate = Path.Combine(Application.StartupPath, "Teamplate", "snippets.html");
            htmlTemplate = File.ReadAllText(htmlTemplate);

            // Cria caminho TEMP do user
            string userTemp = Path.GetTempPath();

            StringBuilder itensPropostaHtml = new StringBuilder();

            // Insira os novos dados
            foreach (DataGridViewRow row in dataGridViewItmProp.Rows)
            {
                if (row.Cells["Codigo"].Value != null)
                {
                    string descricao = row.Cells["Descricao"].Value.ToString();
                    string preco = row.Cells["Preco"].Value.ToString();
                    string desconto = row.Cells["Desconto"].Value.ToString();
                    itensPropostaHtml.Append("<tr>\r\n<td class=\"item\">\r\n<div class=\"d-flex align-items-start\">\r\n<div>\r\n" + descricao + "\r\n<div class=\"text-uppercase new\"><span class=\"fas fa-star\"></span>new</div>\r\n</div>\r\n</div>\r\n</td>\r\n<td class=\"font-weight-bold\">R$" + desconto + "</td>\r\n<td class=\"d-flex flex-column font-weight-bold\">R$" + preco + "</td>\r\n</tr>");
                }
            }

            // Substitua as palavras-chave no templateente.Text);
            string htmlPreenchido = htmlTemplate
                .Replace("{{nomeCliente}}", maskedTextBoxRazaoSocialCliente.Text)
                .Replace("{{cnpjCliente}}", maskedTextBoxCNPJCliente.Text)
                .Replace("{{emailCliente}}", maskedTextBoxEmailCliente.Text)

                .Replace("{{projeto}}", textBoxProjetoProposta.Text)
                .Replace("{{validade}}", maskedTextBoxDataValidadeProposta.Text)
                .Replace("{{emailVendedor}}", maskedTextBoxEmailVendedor.Text)

                .Replace("{{totalPedido}}", maskedTextTotal.Text)
                .Replace("{{totalDesconto}}", maskedTextBoxTotalDesconto.Text)
                .Replace("{{Itens}}", itensPropostaHtml.ToString());

            userTemp = Path.Combine(userTemp, "orcamento.html");
            File.WriteAllText(userTemp, htmlPreenchido);

            return userTemp;
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

        private int InsertProposta()
        {
            using (var db = new ModelContext())
            {
                var proposta = new Cadastro_Proposta();
                if (proposta != null)
                {
                    try
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

                        db.SaveChanges();
                        return db.Cadastro_Proposta.OrderByDescending(pi => pi.id_proposta).Select(pi => pi.id_proposta).FirstOrDefault(); ;
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
                        return 0;
                    }
                }
                else { return 0; }
            }
        }

        private void SaveItemProposta(int Id)
        {
            using (var db = new ModelContext())
            {
                // Remova os registros existentes com o ID fornecido
                var itensParaRemover = db.Item_Proposta.Where(e => e.id_proposta == Id);
                db.Item_Proposta.RemoveRange(itensParaRemover);

                // Insira os novos dados
                foreach (DataGridViewRow row in dataGridViewItmProp.Rows)
                {
                    if (row.Cells["Codigo"].Value != null)
                    {
                        string codigo = row.Cells["Codigo"].Value.ToString();

                        var novoItem = new Item_Proposta
                        {
                            id_proposta = Id,
                            id_produto = int.Parse(codigo)
                        };

                        db.Item_Proposta.Add(novoItem);
                    }
                }

                try
                {
                    db.SaveChanges();
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
                }
            }
        }

        private bool SaveProposta(int Id)
        {
            using (var db = new ModelContext())
            {
                var proposta = db.Cadastro_Proposta.FirstOrDefault(x => x.id_proposta == Id);
                if (proposta != null)
                {
                    // Salva cabeçalho
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
                    ChangedItemProposta(proposta.id_proposta);
                }
            }
        }

        private void ChangedItemProposta(int Id)
        {
            using (var db = new ModelContext())
            {
                var dados = db.Item_Proposta.Where(e => e.id_proposta == Id).ToList();

                // Percorra a lista e adicione os valores à coluna "Código" da dataGridViewItmProp
                foreach (var item in dados)
                {
                    int rowIndex = dataGridViewItmProp.Rows.Add(); // Adicione uma nova linha
                    dataGridViewItmProp.Rows[rowIndex].Cells["Codigo"].Value = item.id_produto; // Defina o valor da célula
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
                if (ItmProdId == 0){return;}

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

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
