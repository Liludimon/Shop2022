namespace Shop2022
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(255)]
        public string ProductArticleNumber { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductCategory { get; set; }

        public string ProductManufacturer { get; set; }

        public int? ProductCost { get; set; }

        public int? ProductDiscountAmount { get; set; }

        public int? ProductQuantityInStock { get; set; }
    }
}
