using System;
using System.CodeDom.Compiler;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;

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
			// TODO: This line of code loads data into the 'sisenterpriseDataSet.Cadastro_Departamento' table. You can move, or remove it, as needed.
			this.cadastro_DepartamentoTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Departamento);
			// TODO: This line of code loads data into the 'sisenterpriseDataSet.Cadastro_Funcionario' table. You can move, or remove it, as needed.
			this.cadastro_FuncionarioTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Funcionario);

			// Insere imagem placeholder.
			string pastaImages = Path.Combine(Application.StartupPath, "Resource");
			string fotoPlaceholder = Path.Combine(pastaImages, "placeholder.jpg");
			if (File.Exists(fotoPlaceholder))
			{
				Image imagemCarregada = Image.FromFile(fotoPlaceholder);
				pictureBoxFoto.Image = imagemCarregada;
				pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta o tamanho para caber no PictureBox
			}

			// Verifica se o diretório existe; caso contrário, cria-o.
			string directoryPath = Path.Combine(Application.StartupPath, "Documento");
			if (!Directory.Exists(directoryPath))
			{
				Directory.CreateDirectory(directoryPath);
			}
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
			ComboBoxDept.Text = string.Empty;
			textBoxTelefone.Text = string.Empty;
			textBoxDataAdmissao.Text = string.Empty;
			textBoxDataAlteracao.Text = string.Empty;
			textBoxDataCadastro.Text = string.Empty;

			//Carrega foto placeholder
			Image imagemCarregada = Image.FromFile(Path.Combine(Application.StartupPath, "Resource", "placeholder.jpg"));
			pictureBoxFoto.Image = imagemCarregada;
			pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta o tamanho para caber no PictureBox

			// Limpa a grid antes de carregar os dados.
			dataGridViewFiles.Rows.Clear();

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
					funcionario.id_departamento = (int)ComboBoxDept.SelectedValue;
					funcionario.telefone = textBoxTelefone.Text;
					//funcionario.data_admissao = DateTime.Parse(textBoxDataAdmissao.Text);
					funcionario.data_alteracao = DateTime.Now;
					//funcionario.data_cadastro = DateTime.Parse(textBoxDataAdmissao.Text);
					//funcionario.path_foto3x4 = Int32.Parse(textBoxMatricula.Text);
					funcionario.qtd_dependentes = Int32.Parse(textBoxQtdDependentes.Text);
					funcionario.qtd_horas_trabalhadas = decimal.Parse(textBoxQtdHorasTrab.Text);
					db.SaveChanges();
					MessageBox.Show("Funcionário atualizar com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else { MessageBox.Show("Não foi possível atualizar, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }

				ClearData();
				SetDataInGridView();
			}
		}

		private void buttonDeletar_Click(object sender, EventArgs e)
		{
			if (FuncId != 0)
			{
				if (MessageBox.Show("Deseja deletar ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					using (var db = new ModelContext())
					{
						var funcionario = new Cadastro_Funcionario();
						funcionario = db.Cadastro_Funcionario.Where(x => x.id_funcionario == FuncId).FirstOrDefault();
						db.Cadastro_Funcionario.Remove(funcionario);
						db.SaveChanges();
					}

					ClearData();
					SetDataInGridView();
					MessageBox.Show("Registro deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else { MessageBox.Show("Não foi possível excluir, tente novamente", "Errp", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
					funcionario.id_departamento = (int)ComboBoxDept.SelectedValue;
					funcionario.telefone = textBoxTelefone.Text;
					funcionario.data_admissao = DateTime.Now;
					funcionario.data_alteracao = DateTime.Now;
					funcionario.data_cadastro = DateTime.Now;
					funcionario.qtd_dependentes = Int32.Parse(textBoxQtdDependentes.Text);
					funcionario.qtd_horas_trabalhadas = decimal.Parse(textBoxQtdHorasTrab.Text);
					db.Cadastro_Funcionario.Add(funcionario);
					db.SaveChanges();
					MessageBox.Show("Funcionário adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else { MessageBox.Show("Não foi possível atualizar, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }

				ClearData();
				SetDataInGridView();
			}
		}

		private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.dataGridView_MouseClick();
		}

		private void dataGridView_MouseClick()
		{
			ClearData();
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
					ComboBoxDept.SelectedValue = funcionario.id_departamento;
					textBoxTelefone.Text = funcionario.telefone.ToString();
					textBoxDataAdmissao.Text = funcionario.data_admissao.ToString();
					textBoxDataAlteracao.Text = funcionario.data_alteracao.ToString();
					textBoxDataCadastro.Text = funcionario.data_cadastro.ToString();
					// Exiba a imagem no PictureBox
					string pastaImages = Path.Combine(Application.StartupPath, "Resource");
					if (funcionario.path_foto3x4 != null)
					{
						string fotoFunc = Path.Combine(pastaImages, (funcionario.path_foto3x4.ToString()));
						if (File.Exists(fotoFunc))
						{
							Image imagemCarregada = Image.FromFile(fotoFunc);
							pictureBoxFoto.Image = imagemCarregada;
							pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta o tamanho para caber no PictureBox
						}
					} 
					else
					{
						string fotoPlaceholder = Path.Combine(pastaImages, "placeholder.jpg");
						if (File.Exists(fotoPlaceholder))
						{
							Image imagemCarregada = Image.FromFile(fotoPlaceholder);
							pictureBoxFoto.Image = imagemCarregada;
							pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta o tamanho para caber no PictureBox
						}
					}
					textBoxQtdDependentes.Text = funcionario.qtd_dependentes.ToString();
					textBoxQtdHorasTrab.Text = funcionario.qtd_horas_trabalhadas.ToString();

					// Carrega os arquivos do diretório para o DataGridView.
					if (Directory.Exists(Path.Combine(Application.StartupPath, "Documento", ("func_" + FuncId.ToString()))))
					{
						// Obtém a lista de arquivos no diretório.
						string[] files = Directory.GetFiles(Path.Combine(Application.StartupPath, "Documento", ("func_" + FuncId.ToString())));

						// Adiciona os arquivos à grid.
						foreach (string file in files)
						{
							string fileName = Path.GetFileName(file);
							dataGridViewFiles.Rows.Add(fileName);
						}
					}
				}
			}
		}

		private void buttonImportFoto_MouseClick(object sender, MouseEventArgs e)
		{
			if (FuncId == 0) {
				MessageBox.Show("Nenhum funcionario foi selecionado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return; 
			}

			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Imagens JPEG|*.jpg;*.jpeg";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string caminhoDaImagem = openFileDialog.FileName;
				string novoNomeDoArquivo = "func_" + (FuncId.ToString()) + ".jpg";
				string pastaImages = Path.Combine(Application.StartupPath, "Resource");
				string caminhoDestino = Path.Combine(pastaImages, novoNomeDoArquivo);

				// Crie a pasta "Resources" se ela não existir
				if (!Directory.Exists(pastaImages)) {Directory.CreateDirectory(pastaImages);}

				string fotoPlaceholder = Path.Combine(pastaImages, "placeholder.jpg");
				if (File.Exists(fotoPlaceholder))
				{
					Image imagemCarregada = Image.FromFile(fotoPlaceholder);
					pictureBoxFoto.Image = imagemCarregada;
					pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta o tamanho para caber no PictureBox
				}

				// Copiar a foto nova
				File.Copy(caminhoDaImagem, caminhoDestino, true);

				using (var db = new ModelContext())
				{
					var funcionario = db.Cadastro_Funcionario.FirstOrDefault(x => x.id_funcionario == FuncId);
					if (funcionario != null)
					{
						funcionario.data_alteracao = DateTime.Now;
						funcionario.path_foto3x4 = novoNomeDoArquivo.ToString();
						db.SaveChanges();
					}
					else { MessageBox.Show("Não foi possível importar a foto, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
				}

				ClearData();
				SetDataInGridView();
				MessageBox.Show("Imagem importada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void buttonLimpar_Click(object sender, EventArgs e)
		{
			ClearData();
			SetDataInGridView();
		}

		private void dataGridViewFiles_MouseClick(object sender, MouseEventArgs e)
		{

		}

		private void buttonImportaDocs_Click(object sender, EventArgs e)
		{
			if (FuncId == 0)
			{
				MessageBox.Show("Nenhum funcionario foi selecionado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				string diretoryUser = Path.Combine(Application.StartupPath, "Documento", ("func_" + FuncId.ToString()));
				if (!Directory.Exists(diretoryUser))
					Directory.CreateDirectory(diretoryUser);

				openFileDialog.Multiselect = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{

					foreach (string sourceFilePath in openFileDialog.FileNames)
					{
						string destinationFilePath = Path.Combine(Application.StartupPath, "Documento", ("func_" + FuncId.ToString()), Path.GetFileName(sourceFilePath));

						File.Copy(sourceFilePath, destinationFilePath, true); // true para permitir a substituição se o arquivo já existir.
					}

					MessageBox.Show("Arquivos importados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			ClearData();
			SetDataInGridView();
		}

		private void dataGridViewFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				string selectedFileName = dataGridViewFiles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
				string filePath = Path.Combine(Application.StartupPath, "Documento", ("func_" + FuncId.ToString()), selectedFileName);
				System.Diagnostics.Process.Start(filePath);
			}
		}

		private void dataGridViewFiles_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				// Confirmação antes de excluir.
				DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir o(s) arquivo(s) selecionado(s)?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					foreach (DataGridViewCell cell in dataGridViewFiles.SelectedCells)
					{
						int rowIndex = cell.RowIndex;
						string selectedFileName = dataGridViewFiles.Rows[rowIndex].Cells[0].Value.ToString();
						string filePath = Path.Combine(Application.StartupPath, "Documento", ("func_" + FuncId.ToString()), selectedFileName);

						if (File.Exists(filePath))
						{
							File.Delete(filePath);
						}
					}
				}
				ClearData();
			}
		}
	}
}
