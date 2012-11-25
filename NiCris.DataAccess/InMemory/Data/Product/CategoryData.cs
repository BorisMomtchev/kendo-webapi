using System;
using System.Collections.Generic;
using System.Linq;
using NiCris.BusinessObjects;

namespace NiCris.DataAccess.InMemory
{
    public class CategoryData
    {
        public static List<Category> GetData()
        {
            List<Category> list = new List<Category>();

            list.Add(new Category() { id = 1, CategoryName = "Household Items" });
            list.Add(new Category() { id = 2, CategoryName = "Sporting Goods" });
            list.Add(new Category() { id = 3, CategoryName = "Electronics" });

            return list;
        }
    }
}
