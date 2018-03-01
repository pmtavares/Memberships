using Memberships.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace Memberships.Areas.Admin.Models
{
    public class ProductItemModel
    {
        [DisplayName("Product id")]
        public int ProductId { get; set; }
        [DisplayName("Item id")]
        public int ItemId { get; set; }
        [DisplayName("Product title")]
        public string ProductTitle { get; set; }
        [DisplayName("Item title")]
        public string ItemTitle { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Item> Items { get; set; }


    }
}