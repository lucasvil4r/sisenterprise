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
		private RHContext dbContext;

		public CadastroFuncionario()
		{
			InitializeComponent();

			dbContext = new RHContext();
			dataGridView.DataSource = dbContext.Funcionarios.AsNoTracking().ToList();
			dataGridView.CellClick += dataGridView_CellClick;
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
			// TODO: This line of code loads data into the 'sisenterpriseDataSet1.Funcionarios' table. You can move, or remove it, as needed.
			this.funcionariosTableAdapter.Fill(this.sisenterpriseDataSet1.Funcionarios);
		}

		// Método para limpar os campos de entrada de dados
		private void ClearData()
		{
			textBoxNome.Clear();
			textBoxCargo.Clear(); ;
			textBoxSalario.Clear();
			textBoxDataAdmissao.Clear();
			textBoxCPF.Clear();
			textBoxNomeMeio.Clear();
			textBoxTelefone.Clear();
			textBoxDataAdmissao.Clear();
			textBoxEndereco.Clear();
			textBoxSobreNome.Clear();
			textBoxDataNascimento.Clear();
			textBoxEmail.Clear();
			textBoxRg.Clear();
		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{

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
			Boolean RetornoInsert = InsertFuncionario();
			if (RetornoInsert)
			{
				refreshGridAndTextBox();
				MessageBox.Show("Funcionario cadastrado com sucesso");
			} 
			else
			{
				MessageBox.Show("Erro ao cadastrado com sucesso");
			}
		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{
			Boolean RetornoExcluido = ExcluirRegistroPorID(int.Parse(textBoxId.Text));

			if (RetornoExcluido)
			{
				// Atualize sua interface do usuário, se necessário
				refreshGridAndTextBox();
				MessageBox.Show("Registro excluído com sucesso!");
			}
			else
			{
				MessageBox.Show("Falha ao excluir o registro!");
			}
		}
		public bool ExcluirRegistroPorID(int idParaExcluir)
		{
			try
			{
				using (var context = new RHContext())
				{
					var funcionario = context.Funcionarios.FirstOrDefault(e => e.Id == idParaExcluir);
					if (funcionario != null)
					{
						context.Funcionarios.Remove(funcionario);
						context.SaveChanges();
						return true; // Exclusão bem-sucedida
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro ao excluir registro: " + ex.Message);
			}

			return false; // Exclusão falhou
		}

		public bool AtualizarRegistrosBanco(int idParaAtualizar)
		{
			using (var context = new RHContext())
			{
				var funcionario = context.Funcionarios.FirstOrDefault(e => e.Id == idParaAtualizar);
				if (funcionario != null)
				{
					funcionario.Nome = textBoxNome.Text;
					funcionario.Cargo = textBoxCargo.Text;
					funcionario.Salario = decimal.Parse(textBoxSalario.Text);
					funcionario.CPF = textBoxCPF.Text;
					funcionario.Matricula = Int32.Parse(textBoxMatricula.Text);
					funcionario.NomeMeio = textBoxNomeMeio.Text;
					funcionario.Telefone = textBoxTelefone.Text;
					funcionario.DataAdmissao = DateTime.Parse(textBoxDataAdmissao.Text);
					funcionario.Endereco = textBoxEndereco.Text;
					funcionario.SobreNome = textBoxSobreNome.Text;
					funcionario.DataNascimento = DateTime.Parse(textBoxDataNascimento.Text);
					funcionario.Email = textBoxEmail.Text;
					funcionario.RG = textBoxRg.Text;
					funcionario.DataAlteracao = DateTime.Now;
					context.SaveChanges();
					context.Entry(funcionario).Reload();
					return true;
				}
				else { return false; }
			}
		}
		public bool AtualizarTextBox(int idParaAtualizar)
		{
			using (var context = new RHContext())
			{
				Funcionario funcionario = dbContext.Funcionarios.Find(idParaAtualizar);
				dbContext.Entry(funcionario).State = EntityState.Detached;
				if (funcionario != null)
				{
					textBoxId.Text = funcionario.Id.ToString();
					textBoxNome.Text = funcionario.Nome;
					textBoxCargo.Text = funcionario.Cargo;
					textBoxSalario.Text = funcionario.Salario.ToString();
					textBoxCPF.Text = funcionario.CPF;
					textBoxMatricula.Text = funcionario.Matricula.ToString();
					textBoxNomeMeio.Text = funcionario.NomeMeio;
					textBoxTelefone.Text = funcionario.Telefone;
					textBoxDataAdmissao.Text = funcionario.DataAdmissao.ToString(); ;
					textBoxEndereco.Text = funcionario.Endereco;
					textBoxSobreNome.Text = funcionario.SobreNome;
					textBoxDataNascimento.Text = funcionario.DataNascimento.ToString(); ;
					textBoxEmail.Text = funcionario.Email;

					// Create and initialize a CheckBox.   
					CheckBox checkBoxAtivo = new CheckBox();
					checkBoxAtivo.Checked = funcionario.Ativo;
					return true;
				}
				else { return false; }
			}
		}
		public bool InsertFuncionario()
		{
			using (var context = new RHContext())
			{
				var funcionario = new Funcionario();
				funcionario.Nome = textBoxNome.Text;
				funcionario.Cargo = textBoxCargo.Text;
				funcionario.Salario = decimal.Parse(textBoxSalario.Text);
				funcionario.CPF = textBoxCPF.Text;
				funcionario.Matricula = Int32.Parse(textBoxMatricula.Text);
				funcionario.NomeMeio = textBoxNomeMeio.Text;
				funcionario.Telefone = textBoxTelefone.Text;
				funcionario.DataAdmissao = DateTime.Parse(textBoxDataAdmissao.Text);
				funcionario.Endereco = textBoxEndereco.Text;
				funcionario.SobreNome = textBoxSobreNome.Text;
				funcionario.DataNascimento = DateTime.Parse(textBoxDataNascimento.Text);
				funcionario.Email = textBoxEmail.Text;
				funcionario.RG = textBoxRg.Text;
				funcionario.DataAlteracao = DateTime.Now;

				CheckBox checkBoxAtivo = new CheckBox();
				funcionario.Ativo = checkBoxAtivo.Checked;

				dbContext.Funcionarios.Add(funcionario);
				dbContext.SaveChanges();
				return true;
			}
		}

		private void saveToolStripButton1_Click(object sender, EventArgs e)
		{
			// Chame o código para atualizar os registros no banco de dados
			Boolean RetornoUpdate = AtualizarRegistrosBanco(int.Parse(textBoxId.Text));

			if (RetornoUpdate)
			{
				// Atualize sua interface do usuário, se necessário
				refreshGridAndTextBox();
				MessageBox.Show("Registro atualizado com sucesso!");
			}
			else
			{
				MessageBox.Show("Falha ao atulizar o registro!");
			}
		}

		private void refreshGridAndTextBox()
		{
			//Recarrega Grid
			ClearData();
			dataGridView.DataSource = "";
			dataGridView.DataSource = dbContext.Funcionarios.AsNoTracking().ToList();
			dataGridView.Refresh();

		}

		private void dataGridView_DoubleClick(object sender, EventArgs e)
		{

		}

		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndexId = 0; // Índice da coluna "Id"

			if (e.RowIndex >= 0 && e.ColumnIndex == columnIndexId)
			{
				// Obtém o valor do ID da célula clicada
				Boolean RetornoUpdate = AtualizarTextBox((int)dataGridView.Rows[e.RowIndex].Cells[columnIndexId].Value);
				if (!RetornoUpdate)
				{
					MessageBox.Show("Falha ao atulizar o registro!");
				}
			}
		}

		private void checkBoxAtivo(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}
	}
}
