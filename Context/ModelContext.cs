using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SisEnterprise_2._0
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("data source=localhost;initial catalog=sisenterprise;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<Cadastro_Cliente> Cadastro_Cliente { get; set; }
        public virtual DbSet<Cadastro_Departamento> Cadastro_Departamento { get; set; }
        public virtual DbSet<Cadastro_Ferias> Cadastro_Ferias { get; set; }
        public virtual DbSet<Cadastro_Fornecedores> Cadastro_Fornecedores { get; set; }
        public virtual DbSet<Cadastro_Funcionario> Cadastro_Funcionario { get; set; }
        public virtual DbSet<Cadastro_Produtos> Cadastro_Produtos { get; set; }
        public virtual DbSet<Cadastro_Proposta> Cadastro_Proposta { get; set; }
        public virtual DbSet<Cadastro_Vendedor> Cadastro_Vendedor { get; set; }
        public virtual DbSet<Item_Proposta> Item_Proposta { get; set; }
        public virtual DbSet<Log_calculo_13> Log_calculo_13 { get; set; }
        public virtual DbSet<Log_calculo_ferias> Log_calculo_ferias { get; set; }
        public virtual DbSet<Login_Usuario> Login_Usuario { get; set; }
        public virtual DbSet<Marcacao_de_ponto> Marcacao_de_ponto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cadastro_Cliente>()
                .Property(e => e.razao_social)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Cliente>()
                .Property(e => e.nome_cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Cliente>()
                .Property(e => e.cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Cliente>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Cliente>()
                .Property(e => e.pais)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Cliente>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Cliente>()
                .Property(e => e.bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Cliente>()
                .Property(e => e.cep)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Cliente>()
                .Property(e => e.cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Cliente>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Cliente>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Cliente>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Departamento>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Departamento>()
                .Property(e => e.gerente)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Departamento>()
                .Property(e => e.supervisor)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.razao_social)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.nome_cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.pais)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.cep)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Fornecedores>()
                .Property(e => e.tel_vendedor)
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

            modelBuilder.Entity<Cadastro_Produtos>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Produtos>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Produtos>()
                .Property(e => e.obs)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Produtos>()
                .Property(e => e.ncm)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Produtos>()
                .Property(e => e.icms)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Cadastro_Proposta>()
                .Property(e => e.projeto)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Proposta>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Proposta>()
                .Property(e => e.estado_faturamento)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Vendedor>()
                .Property(e => e.nome_vendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Vendedor>()
                .Property(e => e.cpf)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Vendedor>()
                .Property(e => e.email_vendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Vendedor>()
                .Property(e => e.empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Vendedor>()
                .Property(e => e.telvendedor)
                .IsUnicode(false);

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
