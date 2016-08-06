using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace testWpf.model.entity
{
    [Table("stock.Product")]
    public class Product
    {
        [Key]
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public Int16 subCategoryId { get; set; }

        public Decimal priceKHR { get; set; }

        public Decimal priceUSD { get; set; }

        public Boolean isPackage { get; set; }

        public Boolean isDeleted { get; set; }

        [StringLength(10)]
        public string createdBy { get; set; }

        [StringLength(10)]
        public string updatedBy { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

    }
}
