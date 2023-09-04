using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisEnterprise
{
	public partial class CadastroFuncionario : Form
	{
		private int childFormNumber = 0;
		private RHContext dbContext;

		public CadastroFuncionario()
		{
			InitializeComponent();
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
			Form childForm = new Form();
			childForm.MdiParent = this;
			childForm.Text = "Window " + childFormNumber++;
			childForm.Show();
		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStrip.Visible = toolBarToolStripMenuItem.Checked;
		}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			statusStrip.Visible = statusBarToolStripMenuItem.Checked;
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void CadastroFuncionario_Load(object sender, EventArgs e)
		{

		}

		// Método para limpar os campos de entrada de dados
		private void LimparCampos()
		{
			textBoxNome.Clear();
			textBoxCPF.Clear();
			textBoxEmail.Clear();
			textBoxSalario.Clear();
			textBoxCargo.Clear();
			textBoxTelefone.Clear();
			textBoxEndereco.Clear();
			textBoxDataAdmissao.Clear();
			textBoxAtivo.Clear();
		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{
			var novoFuncionario = new FuncionarioInterface
			{
				Nome = textBoxNome.Text,
				CPF = textBoxCPF.Text,
				Email = textBoxEmail.Text,
				Salario = decimal.Parse(textBoxSalario.Text),
				Cargo = textBoxCargo.Text,
				Telefone = textBoxTelefone.Text,
				Endereco = textBoxEndereco.Text,
				DataAdmissao = DateTime.Parse(textBoxDataAdmissao.Text),
				DataAlteracao = DateTime.Now,
				Ativo = true
			};

			dbContext.Funcionarios.Add(novoFuncionario);
			dbContext.SaveChanges();
			LimparCampos();
			}

		private void TextBoxAtivo_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
