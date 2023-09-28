using System;
using System.Windows.Forms;

namespace SisEnterprise
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		//metodo para abrir formulario filho
		private void abreFormFilho(Form form)
		{
			foreach (Form formFilho in this.MdiChildren)
			{
				if (formFilho.GetType() == form.GetType())
				{
					formFilho.Focus();
					return;
				}
			}
			form.MdiParent = this;
			form.Show();
		}

		private void cadastroDeFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.abreFormFilho(new CadastroFuncionario());
		}

		private void Main_Load_1(object sender, EventArgs e)
		{

		}

		private void cadastroDeDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.abreFormFilho(new CadastroDepartamento());
		}
	}
}
