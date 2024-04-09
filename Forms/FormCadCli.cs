using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SisEnterprise_2._0.Forms
{
    public partial class FormCadCli : Form
    {
        //Controla ID em buffer
        int ClienteId = 0;
        public FormCadCli()
        {
            InitializeComponent();

            //Carrega foto placeholder
            Image imagemCarregada = Image.FromFile(Path.Combine(Application.StartupPath, "Logo", "placeholder.jpg"));
            pictureBoxFoto.Image = imagemCarregada;
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta o tamanho para caber no PictureBox
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar esses dados ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (ClienteId != 0)
            {
                bool returnFunction = SaveCliente(ClienteId);
                if (returnFunction) {MessageBox.Show("Cliente salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);}
                else{MessageBox.Show("Não foi possível salvar, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            } 
            else
            {
                bool returnFunction = InsertCliente();
                if (returnFunction) {MessageBox.Show("Cliente adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else {MessageBox.Show("Não foi possível adiconar cliente, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            ClearData();
            SetDataInGridView();
        }
        private bool InsertCliente()
        {
            using (var db = new ModelContext())
            {
                var cliente = new Cadastro_Cliente();
                if (cliente != null)
                {
                    cliente.razao_social = maskedTextBoxRazao.Text;
                    cliente.nome_cliente = maskedTextBoxNome.Text;
                    cliente.cnpj = maskedTextBoxCNPJ.Text;
                    cliente.estado = maskedTextBoxEstado.Text;
                    cliente.pais = maskedTextBoxPais.Text;
                    cliente.endereco = maskedTextBoxEndereco.Text;
                    cliente.bairro = maskedTextBoxBairro.Text;
                    cliente.cep = maskedTextBoxCep.Text;
                    cliente.cidade = maskedTextBoxCidade.Text;
                    cliente.email = maskedTextBoxEmail.Text;
                    cliente.tipo = "1";
                    cliente.comentario = richTextBoxComentario.Text;
                    cliente.data_cadastro = DateTime.Now;
                    db.Cadastro_Cliente.Add(cliente);
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
        private bool SaveCliente(int Id)
        {
            using (var db = new ModelContext())
            {
                var cliente = db.Cadastro_Cliente.FirstOrDefault(x => x.id_cliente == Id);
                if (cliente != null)
                {
                    cliente.razao_social = maskedTextBoxRazao.Text;
                    cliente.nome_cliente = maskedTextBoxNome.Text;
                    cliente.cnpj = maskedTextBoxCNPJ.Text;
                    cliente.estado = maskedTextBoxEstado.Text;
                    cliente.pais = maskedTextBoxPais.Text;
                    cliente.endereco = maskedTextBoxEndereco.Text;
                    cliente.bairro = maskedTextBoxBairro.Text;
                    cliente.cep = maskedTextBoxCep.Text;
                    cliente.cidade = maskedTextBoxCidade.Text;
                    cliente.email = maskedTextBoxEmail.Text;
                    cliente.comentario = richTextBoxComentario.Text;
                    cliente.data_alteracao = DateTime.Now;

                    int valor = checkBox1.Checked ? 1 : 0;
                    cliente.tipo = checkBox1.Checked ? "1" : "0";

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

        private bool DeleteCliente(int Id)
        {
            using (var db = new ModelContext())
            {
                var cliente = db.Cadastro_Cliente.FirstOrDefault(x => x.id_cliente == Id);
                if (cliente != null)
                {
                    db.Cadastro_Cliente.Remove(cliente);
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

        private void FormCadCli_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sisenterpriseDataSet.Cadastro_Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_ClienteTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Cliente);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            ClearData();
            ClienteId = Convert.ToInt32(dataGridView.CurrentRow.Cells["idclienteDataGridViewTextBoxColumn"].Value);
            if (dataGridView.CurrentCell.RowIndex != -1 && ClienteId > 0)
            {
                using (var db = new ModelContext())
                {
                    var cliente = new Cadastro_Cliente();
                    cliente = db.Cadastro_Cliente.Where(x => x.id_cliente == ClienteId).FirstOrDefault();

                    maskedTextBoxCodigo.Text = cliente.id_cliente.ToString();
                    maskedTextBoxRazao.Text = cliente.razao_social;
                    maskedTextBoxNome.Text = cliente.nome_cliente;
                    maskedTextBoxCNPJ.Text = cliente.cnpj;
                    maskedTextBoxEstado.Text = cliente.estado;
                    maskedTextBoxPais.Text = cliente.pais;
                    maskedTextBoxEndereco.Text = cliente.endereco;
                    maskedTextBoxBairro.Text = cliente.bairro;
                    maskedTextBoxCidade.Text = cliente.cidade;
                    maskedTextBoxEmail.Text = cliente.email;
                    maskedTextBoxCep.Text = cliente.cep;
                    richTextBoxComentario.Text = cliente.comentario;
                    maskedTextBoxDataCad.Text = cliente.data_cadastro.ToString();
                    maskedTextBoxDataAlt.Text = cliente.data_alteracao.ToString();

                    cliente.tipo = checkBox1.Checked ? "1" : "0"; bool valor = (cliente.tipo == "1") ? true : false;
                    checkBox1.Checked = valor;
                }
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

            ClienteId = 0;
        }

        private void SetDataInGridView()
        {
            using (var db = new ModelContext())
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = db.Cadastro_Cliente.ToList<Cadastro_Cliente>();
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

             if (ClienteId != 0)
            {
                bool returnFunction = DeleteCliente(ClienteId);
                if (returnFunction) {MessageBox.Show("Cliente excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);} 
                else {MessageBox.Show("Não foi possível excluir, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else
            {
                MessageBox.Show("Não foi possível excluir, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearData();
            SetDataInGridView();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            ClearData();
            SetDataInGridView();
        }
    }
}
