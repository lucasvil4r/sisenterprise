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
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}

		private void ShowFormChild(Form form)
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

		private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			string SelectForm = e.Node.Text.ToString();

			switch (SelectForm)
			{
				case "Cadastro de Funcionário":
					ShowFormChild(new FormCadFunc());
					break;
				case "Cadastro de Departamento":
					ShowFormChild(new FormCadDept());
					break;
			}

		}
	}
}
