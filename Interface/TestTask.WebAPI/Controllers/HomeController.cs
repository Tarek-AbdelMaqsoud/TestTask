using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestTask.Business.IRepository;
using TestTask.Models;

namespace TestTask.WebAPI.Controllers
{
    public class HomeController : ApiController
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _productService.GetAll();
        }
    }
}
