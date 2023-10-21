using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisEnterprise_2._0
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			using (var db = new ModelContext())
			{
				if (db.Login_Usuario.Where(x => x.login == textBoxUser.Text && x.pass == textBoxPass.Text).Count() > 0)
				{
					this.Hide();
					Form FormMain = new FormMain();
					FormMain.Show();
					MessageBox.Show("Bem vindo!");
				} else
				{
					MessageBox.Show("Usúario Inválido");
				}
			}
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			this.AcceptButton = buttonLogin;
		}

		private void FormLogin_KeyUp(object sender, KeyEventArgs e)
		{

		}
	}
}
