namespace SisEnterprise_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cadastro_Departamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cadastro_Departamento()
        {
            Cadastro_Funcionario = new HashSet<Cadastro_Funcionario>();
        }

        [Key]
        public int id_departamento { get; set; }

        [StringLength(255)]
        public string nome { get; set; }

        [StringLength(255)]
        public string gerente { get; set; }

        [StringLength(255)]
        public string supervisor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cadastro_Funcionario> Cadastro_Funcionario { get; set; }
    }
}
