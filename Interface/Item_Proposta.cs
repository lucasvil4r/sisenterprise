namespace SisEnterprise_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item_Proposta
    {
        public int id { get; set; }

        public int? id_proposta { get; set; }

        public int? id_produto { get; set; }

        public virtual Cadastro_Produtos Cadastro_Produtos { get; set; }

        public virtual Cadastro_Proposta Cadastro_Proposta { get; set; }
    }
}
