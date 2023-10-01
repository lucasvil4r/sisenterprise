namespace SisEnterprise_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Marcacao_de_ponto
    {
        [Key]
        public int id_marcacao_ponto { get; set; }

        public int? id_funcionario { get; set; }

        public DateTime? data_horario_entrada { get; set; }

        public DateTime? data_horario_saida { get; set; }

        [StringLength(255)]
        public string local { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public virtual Cadastro_Funcionario Cadastro_Funcionario { get; set; }
    }
}
