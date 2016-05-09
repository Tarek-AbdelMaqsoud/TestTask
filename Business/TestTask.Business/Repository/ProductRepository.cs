using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Business.IRepository;
using TestTask.Data;
using TestTask.Models;

namespace TestTask.Business.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ProductsContext db = new ProductsContext();

        public IEnumerable<Product> GetAll()
        {
            return db.Products.ToList();
        }
        public void Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
}
