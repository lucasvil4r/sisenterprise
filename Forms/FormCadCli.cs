using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisEnterprise_2._0.Forms
{
    public partial class FormCadCli : Form
    {
        public FormCadCli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new ModelContext())
            {
                var cliente = new Cadastro_Cliente();
                if (cliente != null)
                {
                    cliente.razao_social = textBoxRazao.Text;
                    db.Cadastro_Cliente.Add(cliente);
                    db.SaveChanges();
                    MessageBox.Show("Funcionário adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Não foi possível atualizar, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
