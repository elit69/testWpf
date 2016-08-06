namespace testWpf
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stock.tbProduct")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string subcategoryid { get; set; }

        [StringLength(255)]
        public string price_khr { get; set; }

        [StringLength(255)]
        public string price_usd { get; set; }

        [StringLength(255)]
        public string created_by { get; set; }

        [StringLength(1)]
        public string updated_by { get; set; }

        [StringLength(255)]
        public string created_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated_at { get; set; }

        [StringLength(255)]
        public string is_package { get; set; }

        [StringLength(255)]
        public string is_deleted { get; set; }
    }
}
