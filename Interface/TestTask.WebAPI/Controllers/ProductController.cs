using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TestTask.Business.IRepository;
using TestTask.Models;

namespace TestTask.WebAPI.Controllers
{
    public class ProductsController : ApiController
    {

        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        [EnableCors(origins: "http://localhost:23604", headers: "*", methods: "*")]
        public IEnumerable<Product> GetAll()
        {
            return _productService.GetAll();
        }


        [HttpPost]
        [EnableCors(origins: "http://localhost:23604", headers: "*", methods: "*")]
        public bool Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                return true;
            }
            return false;
        }
    }
}