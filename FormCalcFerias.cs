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
	public partial class FormCalcFerias : Form
	{
		public FormCalcFerias()
		{
			InitializeComponent();
		}

		private void FormCalcFerias_Load(object sender, EventArgs e)
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
			string fotoPlaceholder = Path.Combine(pastaImages, "placeholder.png");
			if (File.Exists(fotoPlaceholder))
			{
				Image imagemCarregada = Image.FromFile(fotoPlaceholder);
				pictureBoxFoto.Image = imagemCarregada;
				pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta o tamanho para caber no PictureBox
			}
		}
	}
}
