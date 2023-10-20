using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SisEnterprise_2._0
{
	public partial class FormCadFunc : Form
	{
		//Controla ID em buffer
		int FuncId = 0;
		public FormCadFunc()
		{
			InitializeComponent();
		}

		private void FormCadFunc_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'sisenterpriseDataSet.Cadastro_Funcionario' table. You can move, or remove it, as needed.
			this.cadastro_FuncionarioTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Funcionario);

		}
		private void SetDataInGridView()
		{
			using (var db = new ModelContext())
			{
				dataGridView.AutoGenerateColumns = false;
				dataGridView.DataSource = db.Cadastro_Funcionario.ToList<Cadastro_Funcionario>();
			}
		}

		private void ClearData()
		{
			textBoxId.Text = string.Empty;
			textBoxNome.Text = string.Empty;
			textBoxCPF.Text = string.Empty;
			textBoxEndereco.Text = string.Empty;
			textBoxDataNascimento.Text = string.Empty;
			textBoxSalario.Text = string.Empty;
			textBoxEmail.Text = string.Empty;
			textBoxDept.Text = string.Empty;
			textBoxTelefone.Text = string.Empty;
			textBoxDataAdmissao.Text = string.Empty;
			textBoxDataAlteracao.Text = string.Empty;
			textBoxDataCadastro.Text = string.Empty;
			//textBoxDataAdmissao.Text = funcionario.path_foto3x4.ToString();
			textBoxQtdDependentes.Text = string.Empty;
			textBoxQtdHorasTrab.Text = string.Empty;

			FuncId = 0;
		}

		private void buttonSalvar_Click(object sender, EventArgs e)
		{
			using (var db = new ModelContext())
			{
				var funcionario = db.Cadastro_Funcionario.FirstOrDefault(x => x.id_funcionario == FuncId);
				if (funcionario != null)
				{
					funcionario.nome = textBoxNome.Text;
					funcionario.cpf = textBoxCPF.Text;
					funcionario.endereco = textBoxEndereco.Text;
					funcionario.data_nascimento = DateTime.Parse(textBoxDataNascimento.Text);
					funcionario.salario = decimal.Parse(textBoxSalario.Text);
					funcionario.email = textBoxEmail.Text;
					funcionario.id_departamento = Int32.Parse(textBoxDept.Text);
					funcionario.telefone = textBoxTelefone.Text;
					//funcionario.data_admissao = DateTime.Parse(textBoxDataAdmissao.Text);
					funcionario.data_alteracao = DateTime.Now;
					//funcionario.data_cadastro = DateTime.Parse(textBoxDataAdmissao.Text);
					//funcionario.path_foto3x4 = Int32.Parse(textBoxMatricula.Text);
					funcionario.qtd_dependentes = Int32.Parse(textBoxQtdDependentes.Text);
					funcionario.qtd_horas_trabalhadas = decimal.Parse(textBoxQtdHorasTrab.Text);
					db.SaveChanges();
					MessageBox.Show("Funcionário atualizar com sucesso");
				}
				else { MessageBox.Show("Não foi possível atualizar, tente novamente"); }

				ClearData();
				SetDataInGridView();
			}
		}

		private void buttonDeletar_Click(object sender, EventArgs e)
		{

		}

		private void buttonAdicionar_Click(object sender, EventArgs e)
		{
			using (var db = new ModelContext())
			{
				var funcionario = new Cadastro_Funcionario();
				if (funcionario != null)
				{
					funcionario.nome = textBoxNome.Text;
					funcionario.cpf = textBoxCPF.Text;
					funcionario.endereco = textBoxEndereco.Text;
					funcionario.data_nascimento = DateTime.Parse(textBoxDataNascimento.Text);
					funcionario.salario = decimal.Parse(textBoxSalario.Text);
					funcionario.email = textBoxEmail.Text;
					funcionario.id_departamento = Int32.Parse(textBoxDept.Text);
					funcionario.telefone = textBoxTelefone.Text;
					funcionario.data_admissao = DateTime.Now;
					funcionario.data_alteracao = DateTime.Now;
					funcionario.data_cadastro = DateTime.Now;
					//funcionario.path_foto3x4 = Int32.Parse(textBoxMatricula.Text);
					funcionario.qtd_dependentes = Int32.Parse(textBoxQtdDependentes.Text);
					funcionario.qtd_horas_trabalhadas = decimal.Parse(textBoxQtdHorasTrab.Text);
					db.Cadastro_Funcionario.Add(funcionario);
					db.SaveChanges();
					MessageBox.Show("Funcionário atualizar com sucesso");
				}
				else { MessageBox.Show("Não foi possível atualizar, tente novamente"); }

				ClearData();
				SetDataInGridView();
			}
		}
		private void buttonVerDocs_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.dataGridView_MouseClick();
		}

		private void dataGridView_MouseClick()
		{
			FuncId = Convert.ToInt32(dataGridView.CurrentRow.Cells["idfuncionarioDataGridViewTextBoxColumn"].Value);
			if (dataGridView.CurrentCell.RowIndex != -1 && FuncId > 0)
			{
				using (var db = new ModelContext())
				{
					var funcionario = new Cadastro_Funcionario();
					funcionario = db.Cadastro_Funcionario.Where(x => x.id_funcionario == FuncId).FirstOrDefault();

					textBoxId.Text = funcionario.id_funcionario.ToString();
					textBoxNome.Text = funcionario.nome;
					textBoxCPF.Text = funcionario.cpf.ToString();
					textBoxEndereco.Text = funcionario.endereco;
					textBoxDataNascimento.Text = funcionario.data_nascimento.ToString();
					textBoxSalario.Text = funcionario.salario.ToString();
					textBoxEmail.Text = funcionario.email;
					textBoxDept.Text = funcionario.id_departamento.ToString();
					textBoxTelefone.Text = funcionario.telefone.ToString();
					textBoxDataAdmissao.Text = funcionario.data_admissao.ToString();
					textBoxDataAlteracao.Text = funcionario.data_alteracao.ToString();
					textBoxDataCadastro.Text = funcionario.data_cadastro.ToString();
					//textBoxDataAdmissao.Text = funcionario.path_foto3x4.ToString();
					textBoxQtdDependentes.Text = funcionario.qtd_dependentes.ToString();
					textBoxQtdHorasTrab.Text = funcionario.qtd_horas_trabalhadas.ToString();
				}
			}
		}
	}
}
