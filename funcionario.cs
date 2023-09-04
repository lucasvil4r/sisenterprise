using System;

namespace SisEnterprise
{
	internal class Funcionario : FuncionarioInterface
	{
		public object Nome { get; set; }
		public object CPF { get; set; }
		public object Email { get; set; }
		public decimal Salario { get; set; }
		public object Cargo { get; set; }
		public object Telefone { get; set; }
		public object Endereco { get; set; }
		public DateTime DataAdmissao { get; set; }
		public DateTime DataAlteracao { get; set; }
		public object Ativo { get; set; }
	}
}