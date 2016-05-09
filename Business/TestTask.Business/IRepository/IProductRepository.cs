using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Business.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        void Add(Product product);
    }
}
