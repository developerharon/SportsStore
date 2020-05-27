using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        /// <summary>
        /// Renders a view to display a complete list of the products in the repository.
        /// </summary>
        public ViewResult List(int productPage = 1) 
            => View(repository.Products.OrderBy(p => p.ProductId).Skip((productPage - 1) * PageSize).Take(PageSize));
    }
}
