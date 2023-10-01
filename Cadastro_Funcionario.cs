namespace SisEnterprise_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cadastro_Funcionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cadastro_Funcionario()
        {
            Cadastro_Ferias = new HashSet<Cadastro_Ferias>();
            Log_calculo_13 = new HashSet<Log_calculo_13>();
            Log_calculo_ferias = new HashSet<Log_calculo_ferias>();
            Marcacao_de_ponto = new HashSet<Marcacao_de_ponto>();
        }

        [Key]
        public int id_funcionario { get; set; }

        [StringLength(255)]
        public string nome { get; set; }

        [StringLength(14)]
        public string cpf { get; set; }

        [StringLength(255)]
        public string endereco { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_nascimento { get; set; }

        public decimal? salario { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public int? id_departamento { get; set; }

        [StringLength(20)]
        public string telefone { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_admissao { get; set; }

        public DateTime? data_alteracao { get; set; }

        public DateTime? data_cadastro { get; set; }

        [StringLength(255)]
        public string path_foto3x4 { get; set; }

        public int? qtd_dependentes { get; set; }

        public decimal? qtd_horas_trabalhadas { get; set; }

        public virtual Cadastro_Departamento Cadastro_Departamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cadastro_Ferias> Cadastro_Ferias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log_calculo_13> Log_calculo_13 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log_calculo_ferias> Log_calculo_ferias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Marcacao_de_ponto> Marcacao_de_ponto { get; set; }
    }
}
