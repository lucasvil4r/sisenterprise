using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisEnterprise_2._0
{
	public partial class FormCalc13 : Form
	{
		//Controla ID em buffer
		int FuncId = 0;
		public FormCalc13()
		{
			InitializeComponent();
		}

		private void FormCalc13_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'sisenterpriseDataSet.Cadastro_Funcionario' table. You can move, or remove it, as needed.
			this.cadastro_FuncionarioTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Funcionario);

			// Adicione linhas à grade
			object[] row1 = { "Salário / Férias" };
			object[] row2 = { "1/3 férias" };
			object[] row3 = { "INSS" };
			object[] row4 = { "IRRF" };
			object[] row5 = { "Totais" };
			object[] row6 = { "Valor líquido a receber" };
			dataGridViewResult.Rows.Add(row1);
			dataGridViewResult.Rows.Add(row2);
			dataGridViewResult.Rows.Add(row3);
			dataGridViewResult.Rows.Add(row4);
			dataGridViewResult.Rows.Add(row5);
			dataGridViewResult.Rows.Add(row6);

			string pastaImages = Path.Combine(Application.StartupPath, "Resource");
			string fotoPlaceholder = Path.Combine(pastaImages, "placeholder.jpg");
			if (File.Exists(fotoPlaceholder))
			{
				Image imagemCarregada = Image.FromFile(fotoPlaceholder);
				pictureBoxFoto.Image = imagemCarregada;
				pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta o tamanho para caber no PictureBox
			}
		}

		private void dataGridView_MouseClick(object sender, MouseEventArgs e)
		{
			FuncId = Convert.ToInt32(dataGridView.CurrentRow.Cells["idfuncionarioDataGridViewTextBoxColumn"].Value);
			if (dataGridView.CurrentCell.RowIndex != -1 && FuncId > 0)
			{
				using (var db = new ModelContext())
				{
					var funcionario = new Cadastro_Funcionario();
					funcionario = db.Cadastro_Funcionario.Where(x => x.id_funcionario == FuncId).FirstOrDefault();

					textBoxNome.Text = funcionario.nome;
					textBoxCPF.Text = funcionario.cpf.ToString();
					textBoxEmail.Text = funcionario.data_nascimento.ToString();
					textBoxSalario.Text = funcionario.salario.ToString();
					textBoxEmail.Text = funcionario.email;
					textBoxDept.Text = funcionario.id_departamento.ToString();
					textBoxTelefone.Text = funcionario.telefone.ToString();
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
				}
			}
		}
		private void ClearData()
		{
			textBoxNome.Text = string.Empty;
			textBoxCPF.Text = string.Empty;
			textBoxSalario.Text = string.Empty;
			textBoxEmail.Text = string.Empty;
			textBoxDept.Text = string.Empty;
			textBoxTelefone.Text = string.Empty;

			string pastaImages = Path.Combine(Application.StartupPath, "Resource");
			string fotoPlaceholder = Path.Combine(pastaImages, "placeholder.jpg");
			if (File.Exists(fotoPlaceholder))
			{
				Image imagemCarregada = Image.FromFile(fotoPlaceholder);
				pictureBoxFoto.Image = imagemCarregada;
				pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta o tamanho para caber no PictureBox
			}

			textBoxQtdDependentes.Text = string.Empty;
			FuncId = 0;
		}

		private void buttonLimpar_Click(object sender, EventArgs e)
		{

		}
	}
}
