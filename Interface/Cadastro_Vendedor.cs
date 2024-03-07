namespace SisEnterprise_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cadastro_Vendedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cadastro_Vendedor()
        {
            Cadastro_Cliente = new HashSet<Cadastro_Cliente>();
            Cadastro_Proposta = new HashSet<Cadastro_Proposta>();
        }

        [Key]
        public int id_vendedor { get; set; }

        [StringLength(255)]
        public string nome_vendedor { get; set; }

        [StringLength(14)]
        public string cpf { get; set; }

        [StringLength(255)]
        public string email_vendedor { get; set; }

        [StringLength(255)]
        public string empresa { get; set; }

        [StringLength(15)]
        public string telvendedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cadastro_Cliente> Cadastro_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cadastro_Proposta> Cadastro_Proposta { get; set; }
    }
}
