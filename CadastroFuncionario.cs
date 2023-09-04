using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisEnterprise
{
	public partial class CadastroFuncionario : Form
	{
		private int childFormNumber = 0;

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
			var funcionario = new Funcionario();
			funcionario.Nome = textBoxNome.Text;
			funcionario.Cargo = textBoxCargo.Text;
			funcionario.Salario = decimal.Parse(textBoxSalario.Text);
			funcionario.Ativo = true;
			funcionario.CPF = textBoxCPF.Text;
			funcionario.NomeMeio = textBoxNomeMeio.Text;
			funcionario.Telefone = textBoxTelefone.Text;
			funcionario.DataAdmissao = DateTime.Parse(textBoxDataAdmissao.Text);
			funcionario.Endereco = textBoxEndereco.Text;
			funcionario.SobreNome = textBoxSobreNome.Text;
			funcionario.DataNascimento = DateTime.Parse(textBoxNascimento.Text);
			funcionario.Email = textBoxEmail.Text;
			funcionario.RG = textBoxRg.Text;
			funcionario.DataAlteracao = DateTime.Now;

			var db = new RHContext();
			db.Funcionarios.Add(funcionario);
			db.SaveChanges();
		}

		private void TextBoxAtivo_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBoxSalario_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{

		}
	}
}
