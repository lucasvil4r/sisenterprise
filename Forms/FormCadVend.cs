using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SisEnterprise_2._0.Forms
{
    public partial class FormCadVend : Form
    {
        //Controla ID em buffer
        int VendId = 0;
        public FormCadVend()
        {
            InitializeComponent();
        }

        private void FormCadVend_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sisenterpriseDataSet.Cadastro_Vendedor'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_VendedorTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Vendedor);

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxNome.Text.Trim() == "")
            {
                MessageBox.Show("Nome Obrigatorio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja salvar esses dados ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (VendId != 0)
            {
                bool returnFunction = SaveVendedor(VendId);
                if (returnFunction) { MessageBox.Show("Vendedor salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Não foi possível salvar, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                bool returnFunction = InsertVendedor();
                if (returnFunction) { MessageBox.Show("Vendedor adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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

            if (VendId != 0)
            {
                bool returnFunction = DeleteVendedor(VendId);
                if (returnFunction) { MessageBox.Show("Vendedor excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Não foi possível excluir, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Não foi possível excluir, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearData();
            SetDataInGridView();
        }

        private bool InsertVendedor()
        {
            using (var db = new ModelContext())
            {
                var vendedor = new Cadastro_Vendedor();
                if (vendedor != null)
                {
                    vendedor.nome_vendedor = maskedTextBoxNome.Text;
                    vendedor.cpf = maskedTextBoxCPF.Text;
                    vendedor.email_vendedor = maskedTextBoxEmail.Text;
                    vendedor.empresa = maskedTextBoxEmpresa.Text;
                    vendedor.telvendedor = maskedTextBoxTelefone.Text;
                    db.Cadastro_Vendedor.Add(vendedor);

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

        private bool SaveVendedor(int Id)
        {
            using (var db = new ModelContext())
            {
                var vendedor = db.Cadastro_Vendedor.FirstOrDefault(x => x.id_vendedor == Id);
                if (vendedor != null)
                {
                    vendedor.nome_vendedor = maskedTextBoxNome.Text;
                    vendedor.cpf = maskedTextBoxCPF.Text;
                    vendedor.email_vendedor = maskedTextBoxEmail.Text;
                    vendedor.empresa = maskedTextBoxEmpresa.Text;
                    vendedor.telvendedor = maskedTextBoxTelefone.Text;

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

        private bool DeleteVendedor(int Id)
        {
            using (var db = new ModelContext())
            {
                var vendedor = db.Cadastro_Vendedor.FirstOrDefault(x => x.id_vendedor == Id);
                if (vendedor != null)
                {
                    db.Cadastro_Vendedor.Remove(vendedor);
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
            maskedTextBoxNome.Text = string.Empty;
            maskedTextBoxCPF.Text = string.Empty;
            maskedTextBoxEmail.Text = string.Empty;
            maskedTextBoxEmpresa.Text = string.Empty;
            maskedTextBoxTelefone.Text = string.Empty;

            VendId = 0;
        }

        private void SetDataInGridView()
        {
            using (var db = new ModelContext())
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = db.Cadastro_Vendedor.ToList<Cadastro_Vendedor>();
            }
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            ClearData();
            VendId = Convert.ToInt32(dataGridView.CurrentRow.Cells["idvendedorDataGridViewTextBoxColumn"].Value);
            if (dataGridView.CurrentCell.RowIndex != -1 && VendId > 0)
            {
                using (var db = new ModelContext())
                {
                    var vendedor = new Cadastro_Vendedor();
                    vendedor = db.Cadastro_Vendedor.Where(x => x.id_vendedor == VendId).FirstOrDefault();

                    maskedTextBoxCodigo.Text = vendedor.id_vendedor.ToString();
                    maskedTextBoxNome.Text = vendedor.nome_vendedor.ToString();
                    maskedTextBoxCPF.Text = vendedor.cpf.ToString();
                    maskedTextBoxEmail.Text = vendedor.email_vendedor.ToString();
                    maskedTextBoxEmpresa.Text = vendedor.empresa.ToString();
                    maskedTextBoxTelefone.Text = vendedor.telvendedor.ToString();
                }
            }
        }
    }
}
