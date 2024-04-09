using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisEnterprise_2._0.Forms
{
    public partial class FormCadFornec : Form
    {
        //Controla ID em buffer
        int FornecedorId = 0;

        public FormCadFornec()
        {
            InitializeComponent();

            //Carrega foto placeholder
            Image imagemCarregada = Image.FromFile(Path.Combine(Application.StartupPath, "Logo", "placeholder.jpg"));
            pictureBoxFoto.Image = imagemCarregada;
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta o tamanho para caber no PictureBox
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar esses dados ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (FornecedorId != 0)
            {
                bool returnFunction = SaveFornecedor(FornecedorId);
                if (returnFunction) { MessageBox.Show("Fornecedor salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Não foi possível salvar, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                bool returnFunction = InsertFornecedor();
                if (returnFunction) { MessageBox.Show("Fornecedor adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Não foi possível adiconar fornecedor, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            ClearData();
            SetDataInGridView();
        }
        private bool InsertFornecedor()
        {
            using (var db = new ModelContext())
            {
                var fornecedor = new Cadastro_Fornecedores();
                if (fornecedor != null)
                {
                    fornecedor.razao_social = maskedTextBoxRazao.Text;
                    fornecedor.nome_cliente = maskedTextBoxNome.Text;
                    fornecedor.cnpj = maskedTextBoxCNPJ.Text;
                    fornecedor.estado = maskedTextBoxEstado.Text;
                    fornecedor.pais = maskedTextBoxPais.Text;
                    fornecedor.endereco = maskedTextBoxEndereco.Text;
                    fornecedor.bairro = maskedTextBoxBairro.Text;
                    fornecedor.cep = maskedTextBoxCep.Text;
                    fornecedor.cidade = maskedTextBoxCidade.Text;
                    fornecedor.email = maskedTextBoxEmail.Text;
                    fornecedor.comentario = richTextBoxComentario.Text;
                    fornecedor.data_cadastro = DateTime.Now;
                    fornecedor.tipo = "1";
                    db.Cadastro_Fornecedores.Add(fornecedor);

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
        private bool SaveFornecedor(int Id)
        {
            using (var db = new ModelContext())
            {
                var fornecedor = db.Cadastro_Fornecedores.FirstOrDefault(x => x.id_fornecedor == Id);
                if (fornecedor != null)
                {
                    fornecedor.razao_social = maskedTextBoxRazao.Text;
                    fornecedor.nome_cliente = maskedTextBoxNome.Text;
                    fornecedor.cnpj = maskedTextBoxCNPJ.Text;
                    fornecedor.estado = maskedTextBoxEstado.Text;
                    fornecedor.pais = maskedTextBoxPais.Text;
                    fornecedor.endereco = maskedTextBoxEndereco.Text;
                    fornecedor.bairro = maskedTextBoxBairro.Text;
                    fornecedor.cep = maskedTextBoxCep.Text;
                    fornecedor.cidade = maskedTextBoxCidade.Text;
                    fornecedor.email = maskedTextBoxEmail.Text;
                    fornecedor.comentario = richTextBoxComentario.Text;
                    fornecedor.data_alteracao = DateTime.Now;

                    int valor = checkBox1.Checked ? 1 : 0;
                    fornecedor.tipo = checkBox1.Checked ? "1" : "0";

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
        private bool DeleteFornecedor(int Id)
        {
            using (var db = new ModelContext())
            {
                var fornecedor = db.Cadastro_Fornecedores.FirstOrDefault(x => x.id_fornecedor == Id);
                if (fornecedor != null)
                {
                    db.Cadastro_Fornecedores.Remove(fornecedor);
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
            maskedTextBoxRazao.Text = string.Empty;
            maskedTextBoxNome.Text = string.Empty;
            maskedTextBoxCNPJ.Text = string.Empty;
            maskedTextBoxEstado.Text = string.Empty;
            maskedTextBoxPais.Text = string.Empty;
            maskedTextBoxEndereco.Text = string.Empty;
            maskedTextBoxBairro.Text = string.Empty;
            maskedTextBoxCidade.Text = string.Empty;
            maskedTextBoxCep.Text = string.Empty;
            maskedTextBoxEmail.Text = string.Empty;
            richTextBoxComentario.Text = string.Empty;
            maskedTextBoxDataCad.Text = string.Empty;
            maskedTextBoxDataAlt.Text = string.Empty;
            checkBox1.Checked = false;

            FornecedorId = 0;
        }

        private void SetDataInGridView()
        {
            using (var db = new ModelContext())
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = db.Cadastro_Fornecedores.ToList<Cadastro_Fornecedores>();
            }
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

            if (FornecedorId != 0)
            {
                bool returnFunction = DeleteFornecedor(FornecedorId);
                if (returnFunction) { MessageBox.Show("Cliente excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Não foi possível excluir, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Não foi possível excluir, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearData();
            SetDataInGridView();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            ClearData();
            FornecedorId = Convert.ToInt32(dataGridView.CurrentRow.Cells["idfornecedorDataGridViewTextBoxColumn"].Value);
            if (dataGridView.CurrentCell.RowIndex != -1 && FornecedorId > 0)
            {
                using (var db = new ModelContext())
                {
                    var fornecedor = new Cadastro_Fornecedores();
                    fornecedor = db.Cadastro_Fornecedores.Where(x => x.id_fornecedor == FornecedorId).FirstOrDefault();

                    maskedTextBoxCodigo.Text = fornecedor.id_fornecedor.ToString();
                    maskedTextBoxRazao.Text = fornecedor.razao_social;
                    maskedTextBoxNome.Text = fornecedor.nome_cliente;
                    maskedTextBoxCNPJ.Text = fornecedor.cnpj;
                    maskedTextBoxEstado.Text = fornecedor.estado;
                    maskedTextBoxPais.Text = fornecedor.pais;
                    maskedTextBoxEndereco.Text = fornecedor.endereco;
                    maskedTextBoxBairro.Text = fornecedor.bairro;
                    maskedTextBoxCidade.Text = fornecedor.cidade;
                    maskedTextBoxEmail.Text = fornecedor.email;
                    maskedTextBoxCep.Text = fornecedor.cep;
                    richTextBoxComentario.Text = fornecedor.comentario;
                    maskedTextBoxDataCad.Text = fornecedor.data_cadastro.ToString();
                    maskedTextBoxDataAlt.Text = fornecedor.data_alteracao.ToString();

                    bool valor = (fornecedor.tipo == "1") ? true : false;
                    checkBox1.Checked = valor;
                }
            }
        }

        private void FormCadFornec_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sisenterpriseDataSet.Cadastro_Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_FornecedoresTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Fornecedores);

        }
    }
}
