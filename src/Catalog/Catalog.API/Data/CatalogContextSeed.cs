using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreConfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreConfiguredProducts()
        {
            return new List<Product>(){
                new Product()
                {
                    Name="p1-afadsf",
                    Summary="s-fdsf",
                    Description="d-fdsf",
                    Price=33432,
                    ImageFile="fdsf",
                    Category="jreir"

                },
                 new Product()
                {
                    Name="p2-afadsf",
                    Summary="s-fdsf",
                    Description="d-fdsf",
                    Price=33432,
                    ImageFile="fdsf",
                    Category="jreir"

                },
                  new Product()
                {
                    Name="p3-afadsf",
                    Summary="s-fdsf",
                    Description="d-fdsf",
                    Price=33432,
                    ImageFile="fdsf",
                    Category="jreir"

                },
                   new Product()
                {
                    Name="p4-afadsf",
                    Summary="s-fdsf",
                    Description="d-fdsf",
                    Price=33432,
                    ImageFile="fdsf",
                    Category="jreir"

                }
            };
        }
    }
}
