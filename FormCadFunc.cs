using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisEnterprise_2._0
{
	public partial class FormCadFunc : Form
	{
		public FormCadFunc()
		{
			InitializeComponent();
		}

		private void FormCadFunc_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'sisenterpriseDataSet.Cadastro_Funcionario' table. You can move, or remove it, as needed.
			this.cadastro_FuncionarioTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Funcionario);

		}
	}
}
