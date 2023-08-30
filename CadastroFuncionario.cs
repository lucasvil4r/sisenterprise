using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SisEnterprise
{
	public partial class CadastroFuncionario : Form
	{
		public CadastroFuncionario()
		{
			InitializeComponent();
		}

		private void CadastroFuncionario_Load(object sender, EventArgs e)
		{

		}

		private void SaveFuncionario()
		{
			String sConnectionString = "Data Source=-east-1.rds.amazonaws.com;" +
																	"Initial Catalog=sisenterprise;" +
																	"Persist Security Info=True;" +
																	"User ID=;" +
																	"Password=";

			String sCommandText = "INSERT INTO (name, cpf) VALUES (@Nome,@Cpf)";

			//	Seta conexão com banco de dados
			using (var cn = new SqlConnection(sConnectionString))
			{
				using (var cmd = new SqlCommand(sCommandText))
				{
					cmd.Parameters.AddWithValue(“@Nome”, "");
					cmd.Parameters.AddWithValue(“@Cpf”, "");
					cn.Open();
					cmd.ExecuteNonQuery();
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SaveFuncionario();
		}
	}
}
