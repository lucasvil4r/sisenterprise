namespace SisEnterprise_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log_calculo_ferias
    {
        [Key]
        public int id_log_ferias { get; set; }

        public int? id_funcionario { get; set; }

        public decimal? valor_calculado { get; set; }

        public DateTime? data_calculo { get; set; }

        public virtual Cadastro_Funcionario Cadastro_Funcionario { get; set; }
    }
}
