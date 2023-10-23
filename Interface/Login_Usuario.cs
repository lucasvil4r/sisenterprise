namespace SisEnterprise_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Login_Usuario
    {
        [Key]
        public int id_usuario { get; set; }

        [StringLength(255)]
        public string nome { get; set; }

        [StringLength(50)]
        public string login { get; set; }

        [StringLength(255)]
        public string pass { get; set; }

        [StringLength(50)]
        public string tipo { get; set; }

        public bool? ativo { get; set; }
    }
}
