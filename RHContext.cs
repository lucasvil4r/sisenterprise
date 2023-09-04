using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace SisEnterprise
{
	public class RHContext : DbContext
	{
		// Your context has been configured to use a 'RHContext' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'SisEnterprise.RHContext' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'RHContext' 
		// connection string in the application configuration file.
		public RHContext()
			: base("Data Source=sisenterprise.database.windows.net;Initial Catalog=sisenterprise;Persist Security Info=True;User ID=sisenterprise;Password=Jdt7$uwF9u^B8uvd")
		{
		}

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
		public DbSet<Funcionario> Funcionarios { get; set; }
	}

	public class Funcionario
	{
		public int Id { get; set; }

		[MaxLength(50)]
		public string Nome { get; set; }

		[MaxLength(50)]
		public string Cargo { get; set; }

		public decimal Salario { get; set; }

		public bool Ativo { get; set; }

		[MaxLength(50)]
		public string CPF { get; set; }

		[MaxLength(50)]
		public string NomeMeio { get; set; }

		[MaxLength(50)]
		public string Telefone { get; set; }

		public DateTime DataAdmissao { get; set; }

		[MaxLength(50)]
		public string Endereco { get; set; }

		public int Matricula { get; set; }

		[MaxLength(50)]
		public string SobreNome { get; set; }

		public DateTime DataNascimento { get; set; }

		[MaxLength(50)]
		public string Email { get; set; }

		[MaxLength(50)]
		public string RG { get; set; }

		public DateTime DataAlteracao { get; set; }
	}
}
