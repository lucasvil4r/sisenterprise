namespace SisEnterprise_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cadastro_Ferias
    {
        [Key]
        public int id_ferias { get; set; }

        public int? id_funcionario { get; set; }

        public int? qtd_dias { get; set; }

        public DateTime? data_cadastro { get; set; }

        public virtual Cadastro_Funcionario Cadastro_Funcionario { get; set; }
    }
}
