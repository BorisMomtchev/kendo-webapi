using System;
using System.Collections.Generic;
using System.Linq;
using NiCris.BusinessObjects;

namespace NiCris.DataAccess.InMemory
{
    public static class ProductData
    {
        public static List<Product> Current = GetData();

        /*
        public static List<Product> GetData()
        {
            List<Product> list = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                int categoryId = (i % 3) + 1;
                list.Add(new Product()
                {
                    Id = (i + 1),
                    Name = string.Format("Product {0}", (i + 1)),
                    Price = (i + 1),
                    CategoryId = categoryId,
                    Category = CategoryData.GetData().Where(c => c.Id == categoryId).SingleOrDefault()
                });
            }

            return list;
        }
        */ 

        public static List<Product> GetData()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product()
            {
                id = 1,
                Name = "Basketball",
                Price = 34.99m,
                CategoryId = 2,
                Category = CategoryData.GetData().Where(c => c.id == 2).SingleOrDefault()
            });

            list.Add(new Product()
            {
                id = 2,
                Name = "Crossbow",
                Price = 249.95m,
                CategoryId = 2,
                Category = CategoryData.GetData().Where(c => c.id == 2).SingleOrDefault()
            });

            list.Add(new Product()
            {
                id = 3,
                Name = "Blender",
                Price = 24.99m,
                CategoryId = 1,
                Category = CategoryData.GetData().Where(c => c.id == 1).SingleOrDefault()
            });

            list.Add(new Product()
            {
                id = 4,
                Name = "Vaccuum Cleaner",
                Price = 119.95m,
                CategoryId = 1,
                Category = CategoryData.GetData().Where(c => c.id == 1).SingleOrDefault()
            });

            list.Add(new Product()
            {
                id = 5,
                Name = "Blu-ray Player",
                Price = 175.99m,
                CategoryId = 3,
                Category = CategoryData.GetData().Where(c => c.id == 3).SingleOrDefault()
            });

            list.Add(new Product()
            {
                id = 6,
                Name = "Laptop",
                Price = 699.00m,
                CategoryId = 3,
                Category = CategoryData.GetData().Where(c => c.id == 3).SingleOrDefault()
            });

            return list;
        }
    }
}
