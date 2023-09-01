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
	}
}
