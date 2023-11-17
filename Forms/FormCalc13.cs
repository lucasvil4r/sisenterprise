using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            // TODO: This line of code loads data into the 'sisenterpriseDataSet.Cadastro_Departamento' table. You can move, or remove it, as needed.
            this.cadastro_DepartamentoTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Departamento);
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
					ComboBoxDept.SelectedValue = funcionario.id_departamento;
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
                    numericQtdDependentes.Text = funcionario.qtd_dependentes.ToString();
				}
			}
		}
		private void ClearData()
		{
			textBoxNome.Text = string.Empty;
			textBoxCPF.Text = string.Empty;
			textBoxSalario.Text = string.Empty;
			textBoxEmail.Text = string.Empty;
			textBoxTelefone.Text = string.Empty;

			string pastaImages = Path.Combine(Application.StartupPath, "Resource");
			string fotoPlaceholder = Path.Combine(pastaImages, "placeholder.jpg");
			if (File.Exists(fotoPlaceholder))
			{
				Image imagemCarregada = Image.FromFile(fotoPlaceholder);
				pictureBoxFoto.Image = imagemCarregada;
				pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta o tamanho para caber no PictureBox
			}

            numericQtdDependentes.Text = string.Empty;
			FuncId = 0;

            // Limpa a grid antes de carregar os dados.
            // Colunas: Eventos | Alíquota | Proventos | Descontos
            dataGridViewResult.Rows.Clear();
            object[] row1 = { "Valor bruto do 13º", "", "", "" };
            object[] row2 = { "INSS", "", "", "" };
            object[] row3 = { "IRRF", "", "", "" };
            object[] row4 = { "Totais", "", "", "" };
            object[] row5 = { "Valor líquido a receber", "", "", "" };
            dataGridViewResult.Rows.Add(row1);
            dataGridViewResult.Rows.Add(row2);
            dataGridViewResult.Rows.Add(row3);
            dataGridViewResult.Rows.Add(row4);
            dataGridViewResult.Rows.Add(row5);
        }

		private void buttonLimpar_Click(object sender, EventArgs e)
		{
            this.ClearData();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (FuncId == 0)
            {
                MessageBox.Show("Nenhum funcionario foi selecionado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Coleta os dados dos forms
            int dependentes = Convert.ToInt32(numericQtdDependentes.Text);
            double salarioBruto = Convert.ToDouble(textBoxSalario.Text);
            int mesesTrabalhados = Convert.ToInt32(numericMesesTrabalhados.Text);

            //Proventos
            double salarioMensal = salarioBruto / 12;
            double salario13 = salarioMensal * mesesTrabalhados;

            //Descontos
            double descontoINSS = CalcularINSS(salario13);
            double descontoIRRF = CalcularIRRF(salario13, dependentes, descontoINSS);

            //Totais
            double totalDesconto = descontoINSS + descontoIRRF;
            double totalProvento = salarioBruto;

            //Alíquota
            double aliquotaINSS = (descontoINSS / totalProvento) * 100;
            double aliquotaIRRF = (descontoIRRF / totalProvento) * 100;

            //Valor líquido a receber
            double valorLiquidoReceber = totalProvento - totalDesconto;

            if (comboBoxParcela.Text == "Primeira")
            {
                aliquotaINSS = 0;
                aliquotaIRRF = 0;
                totalDesconto = 0;
                totalProvento = salario13 / 2;
                valorLiquidoReceber = totalProvento;
                salario13 = salario13 / 2;
            }
            if (comboBoxParcela.Text == "Segunda")
            {
                salario13 = salario13 / 2;
                totalProvento = totalProvento / 2;
                valorLiquidoReceber = totalProvento - totalDesconto;
            }

            //Formata para % para ser exibida na grid
            var PaliquotaINSS = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:F}%", aliquotaINSS);
            var PaliquotaIRRF = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:F}%", aliquotaIRRF);

            //Formata para R$ para ser exibida na grid
            var Rsalario13 = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", salario13);
            var RtotalDesconto = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", totalDesconto);
            var RtotalProvento = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", totalProvento);
            var RvalorLiquidoReceber = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valorLiquidoReceber);
            var RdescontoINSS = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", descontoINSS);
            var RdescontoIRRF = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", descontoIRRF);

            // Limpa a grid antes de carregar os dados.
            // Colunas: Eventos | Alíquota | Proventos | Descontos
            dataGridViewResult.Rows.Clear();
            object[] row1 = { "Valor bruto do 13º"      , ""            , Rsalario13            , "" };
            object[] row2 = { "INSS"                    , PaliquotaINSS , ""                    , RdescontoINSS };
            object[] row3 = { "IRRF"                    , PaliquotaIRRF , ""                    , RdescontoIRRF };
            object[] row4 = { "Totais"                  , ""            , RtotalProvento        , RtotalDesconto };
            object[] row5 = { "Valor líquido a receber" , ""            , RvalorLiquidoReceber  , "" };
            dataGridViewResult.Rows.Add(row1);
            dataGridViewResult.Rows.Add(row2);
            dataGridViewResult.Rows.Add(row3);
            dataGridViewResult.Rows.Add(row4);
            dataGridViewResult.Rows.Add(row5);
        }
        private static double CalcularINSS(double salarioBruto)
        {
            double descontoINSS = 0;

            // Definição das faixas e alíquotas do INSS para 2023
            double faixa1 = 1320.00;
            double faixa2 = 2571.29;
            double faixa3 = 3856.94;
            double faixa4 = 7507.49;

            double aliquota1 = 0.075;
            double aliquota2 = 0.09;
            double aliquota3 = 0.12;
            double aliquota4 = 0.14;

            // Limites superiores das faixas para cálculo
            double tetoFaixa1 = 1320.00;
            double tetoFaixa2 = 2571.29;
            double tetoFaixa3 = 3856.94;

            // Cálculo do desconto do INSS de acordo com as faixas e alíquotas
            if (salarioBruto <= faixa1)
            {
                descontoINSS = salarioBruto * aliquota1;
            }
            else if (salarioBruto <= faixa2)
            {
                descontoINSS = tetoFaixa1 * aliquota1 + (salarioBruto - tetoFaixa1) * aliquota2;
            }
            else if (salarioBruto <= faixa3)
            {
                descontoINSS = tetoFaixa1 * aliquota1 + (tetoFaixa2 - tetoFaixa1) * aliquota2 + (salarioBruto - tetoFaixa2) * aliquota3;
            }
            else if (salarioBruto <= faixa4)
            {
                descontoINSS = tetoFaixa1 * aliquota1 + (tetoFaixa2 - tetoFaixa1) * aliquota2 + (tetoFaixa3 - tetoFaixa2) * aliquota3 + (salarioBruto - tetoFaixa3) * aliquota4;
            }
            else
            {
                // Se o salário ultrapassar a última faixa, o desconto do INSS será sobre o teto da última faixa
                descontoINSS = tetoFaixa1 * aliquota1 + (tetoFaixa2 - tetoFaixa1) * aliquota2 + (tetoFaixa3 - tetoFaixa2) * aliquota3 + (faixa4 - tetoFaixa3) * aliquota4;
            }

            return descontoINSS;
        }
        private static double CalcularIRRF(double salarioBruto, int numeroDependentes, double descontoINSS)
        {
            double descontoIRRF = 0;
            double totalDeducaoDependente = 0;

            // Definição das faixas e alíquotas do IRRF (valores de exemplo)
            double faixa1 = 2112.00;
            double faixa2 = 2826.65;
            double faixa3 = 3751.05;
            double faixa4 = 4664.68;

            double aliquota1 = 0.075;
            double aliquota2 = 0.15;
            double aliquota3 = 0.225;
            double aliquota4 = 0.275;

            double deduzirfaixa1 = 0.00;
            double deduzirfaixa2 = 158.40;
            double deduzirfaixa3 = 370.40;
            double deduzirfaixa4 = 651.73;
            double deduzirfaixa5 = 884.96;

            // Valor de dedução por dependente (valor de exemplo)
            totalDeducaoDependente = CalcularTotalDeducaoDepedente(salarioBruto, numeroDependentes);

            // Cálculo do IRRF considerando dedução de dependentes
            double baseCalculo = salarioBruto - (descontoINSS + totalDeducaoDependente);

            if (baseCalculo <= faixa1)
            {
                descontoIRRF = 0;
            }
            else if (baseCalculo <= faixa2)
            {
                descontoIRRF = (baseCalculo * aliquota1) - deduzirfaixa2;
            }
            else if (baseCalculo <= faixa3)
            {
                descontoIRRF = (baseCalculo * aliquota2) - deduzirfaixa3;
            }
            else if (baseCalculo <= faixa4)
            {
                descontoIRRF = (baseCalculo * aliquota3) - deduzirfaixa4;
            }
            else
            {
                descontoIRRF = (baseCalculo * aliquota4) - deduzirfaixa5;
            }

            return descontoIRRF;
        }
        private static double CalcularTotalDeducaoDepedente(double salario, int dependentes)
        {
            double totalDeducaoDependente = 0;
            return totalDeducaoDependente = 189.59 * dependentes;
        }
    }
}
