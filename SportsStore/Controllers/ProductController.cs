using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        /// <summary>
        /// Renders a view to display a complete list of the products in the repository.
        /// </summary>
        public ViewResult List() => View(repository.Products);
    }
}
