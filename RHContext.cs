using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SisEnterprise
{
	public class RHContext : DbContext
	{
		public DbSet<FuncionarioInterface> Funcionarios { get; set; }
		public void InserirFuncionario(FuncionarioInterface funcionario)
		{
			using (var context = new RHContext())
			{
				context.Funcionarios.Add(funcionario);
				context.SaveChanges();
			}
		}

		public List<FuncionarioInterface> ObterFuncionarios()
		{
			using (var context = new RHContext())
			{
				return context.Funcionarios.ToList();
			}
		}
		public void AtualizarFuncionario(FuncionarioInterface funcionario)
		{
			using (var context = new RHContext())
			{
				var existingFuncionario = context.Funcionarios.Find(funcionario.Id);
				if (existingFuncionario != null)
				{
					context.Entry(existingFuncionario).CurrentValues.SetValues(funcionario);
					context.SaveChanges();
				}
			}
		}
		public void ExcluirFuncionario(int funcionarioId)
		{
			using (var context = new RHContext())
			{
				var funcionario = context.Funcionarios.Find(funcionarioId);
				if (funcionario != null)
				{
					context.Funcionarios.Remove(funcionario);
					context.SaveChanges();
				}
			}
		}

	}
}
