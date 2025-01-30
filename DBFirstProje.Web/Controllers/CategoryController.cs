using DBFirstProje.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstProje.Web.Controllers
{
    public class CategoryController : Controller
    {
        //fields
        private AppDbContext _context;
        private readonly CategoryRepository _categoryRepository;
        private readonly ProductRepository _productRepository;
        private readonly int deger;
        public CategoryController(AppDbContext context)
        {
            _context = context;
            _categoryRepository = new CategoryRepository();
            _productRepository = new ProductRepository();
            //eğer hiç kategori yoksa kategori ekleyelim.
        if(!_context.Categories.Any())
            {
                //_context.Categories.Add(new Category() { CategoryName = "Elektronik", Description = "Elektronik eşyalar kategorisi." });
                _context.Categories.Add(new() { CategoryName = "Elektronik", Description = "Elektronik eşyalar kategorisi." });
                _context.Categories.Add(new() { CategoryName = "Bilgisayar", Description = "Bilgisayar ve OEM kategorisi." });
                _context.Categories.Add(new() { CategoryName = "Telefon", Description = "Telefon kategorisi." });
                _context.Categories.Add(new() { CategoryName = "Beyaz Eşya", Description = "Elektrikli eşyalar kategorisi." });
                _context.Categories.Add(new() { CategoryName = "Spor", Description = "Spor malzemeleri kategorisi." });
                _context.Categories.Add(new() { CategoryName = "Mobil", Description = "Mobil Malzeme kategorisi." });
            }
            //
            _context.SaveChanges();
        }
        public IActionResult Index()
        {
            ViewData["adet"]=deger;
            var categoryModel=_context.Categories.ToList(); // geriye liste türünde döndürdük
            return View(categoryModel);
        }
        public IActionResult Remove(int id)
        {

            var cat = _context.Categories.FirstOrDefault(c => c.Id == id);
            _context.Categories.Remove(cat);
            _context.SaveChanges(); // UNUTMA!!!!!
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
        return View(); 
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return View();
           // return RedirectToAction("Index","Category");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges(); //Unutma!!!
             return RedirectToAction("Index","Category");
        }
        public ActionResult Details(int id)
        {
            var category=_context.Categories.FirstOrDefault(c=>c.Id == id);
            return View(category);
        }
    }
}
