using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SisEnterprise_2._0.Forms
{
    public partial class FormCadProp : Form
    {
        public FormCadProp()
        {
            InitializeComponent();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void deletetoolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCodProposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCodCliente_TextChanged(object sender, EventArgs e)
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
        }

        private void maskedTextBoxCodVendedor_TextChanged(object sender, EventArgs e)
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
        }
    }
}
