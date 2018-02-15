﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Memberships.Areas.Admin.Models;
using System.Threading.Tasks;
using Memberships.Entities;
using Memberships.Models;

namespace Memberships.Areas.Admin.Extensions
{
    public class ConversionExtensions
    {

        public static async Task<IEnumerable<ProductModel>> Convert(IEnumerable<Product> products, ApplicationDbContext db)
        {

            if (products.Count().Equals(0))
                return new List<ProductModel>();

            var texts = await db.ProductLinkTexts.ToListAsync();
            var types = await db.ProductTypes.ToListAsync();

            return from p in products
                   select new ProductModel
                   {
                       Id = p.Id,
                       Title = p.Title,
                       Description = p.Description,
                       ImageUrl = p.ImageUrl,
                       ProductLinkTextId = p.ProductLinkTextId,
                       ProductTypeId = p.ProductTypeId,
                       ProductLinkTexts = texts,
                       ProductTypes = types
                   };

        }
    }
}