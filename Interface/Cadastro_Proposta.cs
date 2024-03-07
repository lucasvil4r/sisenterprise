namespace SisEnterprise_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cadastro_Proposta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cadastro_Proposta()
        {
            Item_Proposta = new HashSet<Item_Proposta>();
        }

        [Key]
        public int id_proposta { get; set; }

        public int? id_cliente { get; set; }

        public int? id_vendedor { get; set; }

        [StringLength(255)]
        public string projeto { get; set; }

        public DateTime? validade { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public decimal? cotacao_dolar { get; set; }

        public int? probabilidade { get; set; }

        [StringLength(50)]
        public string estado_faturamento { get; set; }

        public virtual Cadastro_Cliente Cadastro_Cliente { get; set; }

        public virtual Cadastro_Vendedor Cadastro_Vendedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item_Proposta> Item_Proposta { get; set; }
    }
}
