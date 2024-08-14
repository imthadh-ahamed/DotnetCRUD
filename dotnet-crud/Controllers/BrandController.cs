using dotnet_crud.Data;
using dotnet_crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_crud.Controllers
{
    public class BrandController : Controller
    {
        // This constructor will be used to inject the database context
        private readonly ApplicationDBContext _dbcontext;

        // This constructor will be used to inject the database context
        public BrandController(ApplicationDBContext dbcontext)
        {
            // This line will assign the injected database context to the local database context
            _dbcontext = dbcontext;
        }

        // This method will be used to return the view
        [HttpGet]
        public IActionResult Index()
        {
            List<Brand> brands = _dbcontext.Brand.ToList();
            // This line will return the view
            return View(brands);
        }
    }
}
