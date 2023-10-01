using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SisEnterprise_2._0
{
	public partial class ModelContext : DbContext
	{
		public ModelContext()
			: base("Data Source=sisenterprise.database.windows.net;Initial Catalog=sisenterprise;Persist Security Info=True;User ID=sisenterprise;Password=Jdt7$uwF9u^B8uvd")
		{
		}

		public virtual DbSet<Cadastro_Departamento> Cadastro_Departamento { get; set; }
		public virtual DbSet<Cadastro_Ferias> Cadastro_Ferias { get; set; }
		public virtual DbSet<Cadastro_Funcionario> Cadastro_Funcionario { get; set; }
		public virtual DbSet<Log_calculo_13> Log_calculo_13 { get; set; }
		public virtual DbSet<Log_calculo_ferias> Log_calculo_ferias { get; set; }
		public virtual DbSet<Login_Usuario> Login_Usuario { get; set; }
		public virtual DbSet<Marcacao_de_ponto> Marcacao_de_ponto { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cadastro_Departamento>()
				.Property(e => e.nome)
				.IsUnicode(false);

			modelBuilder.Entity<Cadastro_Departamento>()
				.Property(e => e.gerente)
				.IsUnicode(false);

			modelBuilder.Entity<Cadastro_Departamento>()
				.Property(e => e.supervisor)
				.IsUnicode(false);

			modelBuilder.Entity<Cadastro_Funcionario>()
				.Property(e => e.nome)
				.IsUnicode(false);

			modelBuilder.Entity<Cadastro_Funcionario>()
				.Property(e => e.cpf)
				.IsUnicode(false);

			modelBuilder.Entity<Cadastro_Funcionario>()
				.Property(e => e.endereco)
				.IsUnicode(false);

			modelBuilder.Entity<Cadastro_Funcionario>()
				.Property(e => e.salario)
				.HasPrecision(10, 2);

			modelBuilder.Entity<Cadastro_Funcionario>()
				.Property(e => e.email)
				.IsUnicode(false);

			modelBuilder.Entity<Cadastro_Funcionario>()
				.Property(e => e.telefone)
				.IsUnicode(false);

			modelBuilder.Entity<Cadastro_Funcionario>()
				.Property(e => e.path_foto3x4)
				.IsUnicode(false);

			modelBuilder.Entity<Cadastro_Funcionario>()
				.Property(e => e.qtd_horas_trabalhadas)
				.HasPrecision(5, 2);

			modelBuilder.Entity<Log_calculo_13>()
				.Property(e => e.valor_calculado)
				.HasPrecision(10, 2);

			modelBuilder.Entity<Log_calculo_ferias>()
				.Property(e => e.valor_calculado)
				.HasPrecision(10, 2);

			modelBuilder.Entity<Login_Usuario>()
				.Property(e => e.nome)
				.IsUnicode(false);

			modelBuilder.Entity<Login_Usuario>()
				.Property(e => e.login)
				.IsUnicode(false);

			modelBuilder.Entity<Login_Usuario>()
				.Property(e => e.pass)
				.IsUnicode(false);

			modelBuilder.Entity<Login_Usuario>()
				.Property(e => e.tipo)
				.IsUnicode(false);

			modelBuilder.Entity<Marcacao_de_ponto>()
				.Property(e => e.local)
				.IsUnicode(false);

			modelBuilder.Entity<Marcacao_de_ponto>()
				.Property(e => e.status)
				.IsUnicode(false);
		}
	}
}
