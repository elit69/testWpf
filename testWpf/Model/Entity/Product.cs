namespace testWpf
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stock.Product")]
    public partial class Product
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public Int16 subCategoryId { get; set; }

        public Decimal priceKHR { get; set; }

        public Decimal priceUSD { get; set; }

        public Boolean isPackage { get; set; }

        public Boolean isDeleted { get; set; }

        public string createdBy { get; set; }

        public string updatedBy { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

    }
}
