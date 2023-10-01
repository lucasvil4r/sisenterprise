using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisEnterprise
{
	public partial class CadastroDepartamento : Form
	{
		public CadastroDepartamento()
		{
			InitializeComponent();
		}

		private void saveToolStripButton1_Click(object sender, EventArgs e)
		{

		}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroDepartamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sisenterpriseDataSet1.Cadastro_Departamento'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_DepartamentoTableAdapter.Fill(this.sisenterpriseDataSet1.Cadastro_Departamento);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
