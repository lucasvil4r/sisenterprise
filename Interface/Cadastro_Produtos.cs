namespace SisEnterprise_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cadastro_Produtos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cadastro_Produtos()
        {
            Item_Proposta = new HashSet<Item_Proposta>();
        }

        [Key]
        public int id_produto { get; set; }

        [StringLength(255)]
        public string descricao { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        [Column(TypeName = "text")]
        public string obs { get; set; }

        public decimal? preco { get; set; }

        public decimal? desconto { get; set; }

        [StringLength(15)]
        public string ncm { get; set; }

        public decimal? icms { get; set; }

        public DateTime? data_cadastro { get; set; }

        public DateTime? data_alteracao { get; set; }

        public int? id_fornecedor { get; set; }

        public virtual Cadastro_Fornecedores Cadastro_Fornecedores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item_Proposta> Item_Proposta { get; set; }
    }
}
