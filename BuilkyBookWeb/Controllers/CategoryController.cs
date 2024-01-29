using Microsoft.AspNetCore.Mvc;
using BuilkyBookWeb.Data;
using BuilkyBookWeb.Models;
namespace BuilkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> ObjCategories = _db.categories.ToList();
            return View(ObjCategories);
        }

        // Get
        public IActionResult create()
        {
            return View();
        }
    }
}
