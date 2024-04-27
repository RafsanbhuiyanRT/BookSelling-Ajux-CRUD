using BookSelling_E_Comerse.Data;
using BookSelling_E_Comerse.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookSelling_E_Comerse.Controllers;
public class CategoryController : Controller
{
    private readonly ApplicatioDbContext _db;
    public CategoryController(ApplicatioDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        List<Category> ObjCategoryList = _db.Categorys.ToList();
        return View(ObjCategoryList);
    }
    public ActionResult GetDrpCategories()
    {
        var category = _db.Categorys
                          .Select(s => new SelectListItem
                          {
                              Text = s.Name,
                              Value = $"{s.Id}"
                          })
                        .ToList();
        return Ok(category);
    }
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category obj )
    {
        if (ModelState.IsValid)
        {
            _db.Categorys.Add(obj);
            _db.SaveChanges();
        }

        return RedirectToAction("Index");
    }
}

