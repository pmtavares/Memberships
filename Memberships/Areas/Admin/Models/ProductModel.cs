using Memberships.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memberships.Areas.Admin.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [DisplayName("Image URL")]
        public string ImageUrl { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        public int ProductLinkTextId { get; set; }

        public int ProductTypeId { get; set; }

        [DisplayName("Product Link Texts")]
        public ICollection<ProductLinkText> ProductLinkTexts { get; set; }

        [DisplayName("Product Types")]
        public ICollection<ProductType> ProductTypes { get; set; }

        public string ProductType
        {
            get
            {
                return ProductTypes == null || ProductTypes.Count.Equals(0) ? string.Empty : ProductTypes.First(pt => pt.Id.Equals(ProductLinkTextId)).Title;
            }

        }

        public string ProductLinkText{
            get {
                return ProductLinkTexts == null || ProductLinkTexts.Count.Equals(0) ? string.Empty : ProductLinkTexts.First(pt => pt.Id.Equals(ProductTypeId)).Title;
            }

        }

    }
}