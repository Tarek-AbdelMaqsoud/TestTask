using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Business.IRepository;
using TestTask.Models;

namespace TestTask.Business.Repository
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
        public void Add(Product product)
        {
            _productRepository.Add(product);
        }
    }
}
