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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SisEnterprise_2._0
{
	public partial class FormCadDept : Form
	{
		//Controla ID em buffer
		int DeptId = 0;
		public FormCadDept()
		{
			InitializeComponent();
		}

		private void FormCadDept_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'sisenterpriseDataSet.Cadastro_Departamento' table. You can move, or remove it, as needed.
            this.cadastro_DepartamentoTableAdapter.Fill(this.sisenterpriseDataSet.Cadastro_Departamento);

			ClearData();
			SetDataInGridView();
		}

		private void SetDataInGridView()
		{
			using (var db = new ModelContext())
			{
				dataGridView.AutoGenerateColumns = false;
				dataGridView.DataSource = db.Cadastro_Departamento.ToList<Cadastro_Departamento>();
			}
		}

		private void ClearData()
		{
			textBoxId.Text = textBoxDept.Text = textBoxGerente.Text = textBoxSupervisor.Text = string.Empty;
			DeptId = 0;
		}

		private void buttonSalvar_Click(object sender, EventArgs e)
		{
			using (var db = new ModelContext())
			{
				var departamento = db.Cadastro_Departamento.FirstOrDefault(x => x.id_departamento == DeptId);
				if (departamento != null)
				{
					departamento.nome = textBoxDept.Text.Trim();
					departamento.gerente = textBoxGerente.Text.Trim();
					departamento.supervisor = textBoxSupervisor.Text.Trim();
					db.SaveChanges();
					MessageBox.Show("Departamento atualizar com sucesso");
				}
				else {MessageBox.Show("Não foi possível atualizar, tente novamente");}

				ClearData();
				SetDataInGridView();
			}
		}

		private void buttonDeletar_Click(object sender, EventArgs e)
		{
			if (DeptId != 0)
			{
				if (MessageBox.Show("Deseja deletar ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					using (var db = new ModelContext())
					{
						var departamento = new Cadastro_Departamento();
						departamento = db.Cadastro_Departamento.Where(x => x.id_departamento == DeptId).FirstOrDefault();
						db.Cadastro_Departamento.Remove(departamento);
						db.SaveChanges();
					}

					ClearData();
					SetDataInGridView();
					MessageBox.Show("Registro deletado com sucesso!");
				}
			} else { MessageBox.Show("Não foi possível excluir, tente novamente"); }
		}

		private void dataGridView_MouseClick(object sender, MouseEventArgs e)
		{
			DeptId = Convert.ToInt32(dataGridView.CurrentRow.Cells["iddepartamentoDataGridViewTextBoxColumn"].Value);
			if (dataGridView.CurrentCell.RowIndex != -1 && DeptId > 1)
			{
				using (var db = new ModelContext())
				{
					var departamento = new Cadastro_Departamento();
					departamento = db.Cadastro_Departamento.Where(x => x.id_departamento == DeptId).FirstOrDefault();

					textBoxId.Text = departamento.id_departamento.ToString();
					textBoxDept.Text = departamento.nome;
					textBoxGerente.Text = departamento.gerente;
					textBoxSupervisor.Text = departamento.supervisor;
				}
			}
		}

		private void buttonAdicionar_Click(object sender, EventArgs e)
		{
			if (DeptId == 0)
			{
				using (var db = new ModelContext())
				{
					var departamento = new Cadastro_Departamento();
					departamento.nome = textBoxDept.Text.Trim();
					departamento.gerente = textBoxGerente.Text.Trim();
					departamento.supervisor = textBoxSupervisor.Text.Trim();

					db.Cadastro_Departamento.Add(departamento);
					db.SaveChanges();
				}
			} else { MessageBox.Show("Não foi possível adicionar, tente novamente"); }

			ClearData();
			SetDataInGridView();
		}

		private void buttonLimpar_Click(object sender, EventArgs e)
		{
			ClearData();
			SetDataInGridView();
		}
	}
}
