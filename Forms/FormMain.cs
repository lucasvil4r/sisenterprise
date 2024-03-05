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
				case "Cadastro de Funcionários":
					ShowFormChild(new FormCadFunc());
					break;
				case "Cadastro de Departamentos":
					ShowFormChild(new FormCadDept());
					break;
				case "Cálculo de Férias":
					ShowFormChild(new FormCalcFerias());
					break;
				case "Cálculo de 13°":
					ShowFormChild(new FormCalc13());
					break;
			}

		}
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            if (menuItem != null)
            {
                if (menuItem.Checked)
                {
                    // Realizar ação quando o item de menu está marcado (checked)
                    treeView.Visible = true;
                }
                else
                {
                    // Realizar outra ação quando o item de menu não está marcado (unchecked)
                    treeView.Visible = false;
                }
            }
        }
    }
}
