using System;
using System.Collections.Generic;
using System.Linq;
using ICT13580013FinalB.Models;
using SQLite;

namespace ICT13580013FinalB.Helper
{
    public class DbHelpers
    {
        
			SQLiteConnection db;
			
            public DbHelpers(string dbPath)
			{
				db = new SQLiteConnection(dbPath);
				db.CreateTable<Product>();
			}

			public int AddProduct(Product product)
			{
				db.Insert(product);
				return product.Id;

			}
			public List<Product> GetProducts()
			{
				return db.Table<Product>().ToList();

			}
			public int UpdateProduct(Product product)
			{
				return db.Update(product);
			}

			public int DeleteProduct(Product product)
			{
				return db.Delete(product);
			}
		
    }
}
