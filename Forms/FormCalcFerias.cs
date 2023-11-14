using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SisEnterprise_2._0
{
	public partial class FormCalcFerias : Form
	{
		//Controla ID em buffer
		int FuncId = 0;
		public FormCalcFerias()
		{
			InitializeComponent();
		}

		private void FormCalcFerias_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'sisenterpriseDataSet.Cadastro_Departamento' table. You can move, or remove it, as needed.
			this.cadastro_DepartamentoTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Departamento);
			// TODO: This line of code loads data into the 'sisenterpriseDataSet.Cadastro_Funcionario' table. You can move, or remove it, as needed.
			this.cadastro_FuncionarioTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Funcionario);

			// Adicione linhas à grade
			object[] row1 = { "Salário / Férias" };
			object[] row2 = { "1/3 férias" };
            object[] row3 = { "Abono pecuniário", "", "", "" };
            object[] row4 = { "1/3 Abono pecuniário", "", "", "" };
            object[] row5 = { "INSS" };
			object[] row6 = { "IRRF" };
			object[] row7 = { "Totais" };
			object[] row8 = { "Valor líquido a receber" };
			dataGridViewResult.Rows.Add(row1);
			dataGridViewResult.Rows.Add(row2);
			dataGridViewResult.Rows.Add(row3);
			dataGridViewResult.Rows.Add(row4);
			dataGridViewResult.Rows.Add(row5);
			dataGridViewResult.Rows.Add(row6);
            dataGridViewResult.Rows.Add(row7);
            dataGridViewResult.Rows.Add(row8);

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
            this.ClearData();
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
			ComboBoxDept.Text = string.Empty;
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

            // Limpa a grid antes de carregar os dados.
            // Colunas: Eventos | Alíquota | Proventos | Descontos
            dataGridViewResult.Rows.Clear();
            object[] row1 = { "Salário / Férias", "", "", "" };
            object[] row2 = { "1/3 férias", "", "", "" };
            object[] row3 = { "Abono pecuniário", "", "", "" };
            object[] row4 = { "1/3 Abono pecuniário", "", "", "" };
            object[] row5 = { "INSS", "", "", "" };
            object[] row6 = { "IRRF", "", "", "" };
            object[] row7 = { "Totais", "", "", "" };
            object[] row8 = { "Valor líquido a receber", "", "", "" };
            dataGridViewResult.Rows.Add(row1);
            dataGridViewResult.Rows.Add(row2);
            dataGridViewResult.Rows.Add(row3);
            dataGridViewResult.Rows.Add(row4);
            dataGridViewResult.Rows.Add(row5);
            dataGridViewResult.Rows.Add(row6);
            dataGridViewResult.Rows.Add(row7);
            dataGridViewResult.Rows.Add(row8);
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

            //Proventos
            double salarioBruto = Convert.ToDouble(textBoxSalario.Text);
			double salarioTerco = salarioBruto / 3;
            double abonopecuTerco = salarioTerco / 3;

            //Descontos
            double descontoINSS = CalcularINSS(salarioBruto);
            double descontoIRRF = CalcularIRRF(salarioBruto);

            //Alíquota
            double aliquotaINSS = ((descontoINSS / salarioBruto) * 100);
            double aliquotaIRRF = ((descontoIRRF / salarioBruto) * 100);

            //Totais
            double totalDesconto = descontoINSS;

            //Valor líquido a receber
            double valorLiquidoReceber = ((salarioBruto + salarioTerco) - (descontoINSS));

			//Formata para R$ para ser exibida na grid
			var RsalarioBruto = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", salarioBruto);
            var RsalarioTerco = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", salarioTerco);
            var RtotalDesconto = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", totalDesconto);
            var RvalorLiquidoReceber = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valorLiquidoReceber);
            var RdescontoINSS = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", descontoINSS);
            var RdescontoIRRF = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", descontoIRRF);
            var RabonopecuTerco = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", abonopecuTerco);

            // Limpa a grid antes de carregar os dados.
            dataGridViewResult.Rows.Clear();
            // Colunas: Eventos | Alíquota | Proventos | Descontos
            object[] row1 = { "Salário / Férias"		, ""							 , RsalarioBruto				, "" };
            object[] row2 = { "1/3 férias"				, ""							 , RsalarioTerco				, "" };
            object[] row3 = { "Abono pecuniário"        , ""                             , RsalarioTerco                , "" };
            object[] row4 = { "1/3 Abono pecuniário"    , ""                             , RabonopecuTerco              , "" };
            object[] row5 = { "INSS"					, aliquotaINSS.ToString("F")	 , ""							, RdescontoINSS };
            object[] row6 = { "IRRF"					, aliquotaIRRF.ToString("F")	 , ""							, RdescontoIRRF };
            object[] row7 = { "Totais"					, ""							 , ""							, RtotalDesconto };
            object[] row8 = { "Valor líquido a receber"	, ""							 , RvalorLiquidoReceber			, "" };
            dataGridViewResult.Rows.Add(row1);
            dataGridViewResult.Rows.Add(row2);
            dataGridViewResult.Rows.Add(row3);
            dataGridViewResult.Rows.Add(row4);
            dataGridViewResult.Rows.Add(row5);
            dataGridViewResult.Rows.Add(row6);
            dataGridViewResult.Rows.Add(row7);
            dataGridViewResult.Rows.Add(row8);
        }

        private static double CalcularINSS(double salarioBruto)
        {
            int faixaSalarial = 0;
            double faixaDescontoRetroativo = 0;

            //Descobre faixa salarial
            if (salarioBruto <= 1320.00)								{ faixaSalarial = 1;}
            else if (salarioBruto >= 1320.01 && salarioBruto <= 2571.29){ faixaSalarial = 2;}
            else if (salarioBruto >= 2571.30 && salarioBruto <= 3856.94){ faixaSalarial = 3;}
		    else if (salarioBruto >= 3856.95 && salarioBruto <= 7507.49){ faixaSalarial = 4;}
            else														{ faixaSalarial = 5;}

			//Calcula retroativo
            if (salarioBruto >= 1320.00 || faixaSalarial == 1) { faixaDescontoRetroativo += faixaSalarial == 1 ? (salarioBruto - 1320.01) * 0.075 : 1320.00 * 0.075; }				// Alíquota de 7.5%
			if (salarioBruto >= 1320.01 || faixaSalarial == 2) { faixaDescontoRetroativo += faixaSalarial == 2 ? (salarioBruto - 1320.01) * 0.09  : (2571.30 - 1320.01) * 0.09; }	// Alíquota de 9%
			if (salarioBruto >= 2571.30 || faixaSalarial == 3) { faixaDescontoRetroativo += faixaSalarial == 3 ? (salarioBruto - 2571.30) * 0.12  :	(3856.95 - 2571.30) * 0.12; }	// Alíquota de 12%
			if (salarioBruto >= 3856.95 || faixaSalarial == 4) { faixaDescontoRetroativo += faixaSalarial == 4 ? (salarioBruto - 3856.95) * 0.14  :	(7507.49 - 3856.95) * 0.14; }	// Alíquota de 14%

            return faixaDescontoRetroativo;
        }
        private static double CalcularIRRF(double salario)
        {
            double desconto = 0;

            if (salario <= 1903.98)
            {
                desconto = 7.50;
            }
            else if (salario <= 2826.65)
            {
                desconto = 9.00;
            }
            else if (salario <= 3751.05)
            {
                desconto = 12.00;
            }
            else if (salario <= 4664.68)
            {
                desconto = 14.00;
            }
            else
            {
                // Caso o salário ultrapasse todas as faixas, o desconto é o máximo de 14%
                desconto = 14.00;
            }

            return 0;
        }
        private static decimal CalcularDeducaoDepedente(int quantidadeDependente)
        {
            // Atualmente, o valor de dedução no cálculo do IRRF é de R$ 2.275,08 por dependente, sendo o valor mensal de R$ 189,59.
            decimal deducao = 189.59m;
			deducao = 189.59m * quantidadeDependente;

            return deducao;
        }
    }
}
