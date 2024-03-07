namespace SisEnterprise_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cadastro_Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cadastro_Cliente()
        {
            Cadastro_Proposta = new HashSet<Cadastro_Proposta>();
        }

        [Key]
        public int id_cliente { get; set; }

        public int? id_vendedor { get; set; }

        [StringLength(255)]
        public string razao_social { get; set; }

        [StringLength(255)]
        public string nome_cliente { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(50)]
        public string estado { get; set; }

        [StringLength(50)]
        public string pais { get; set; }

        [StringLength(255)]
        public string endereco { get; set; }

        [StringLength(100)]
        public string bairro { get; set; }

        [StringLength(10)]
        public string cep { get; set; }

        [StringLength(100)]
        public string cidade { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(50)]
        public string tipo { get; set; }

        [Column(TypeName = "text")]
        public string comentario { get; set; }

        public byte[] logo_empresa { get; set; }

        public DateTime? data_cadastro { get; set; }

        public DateTime? data_alteracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cadastro_Proposta> Cadastro_Proposta { get; set; }

        public virtual Cadastro_Vendedor Cadastro_Vendedor { get; set; }
    }
}
