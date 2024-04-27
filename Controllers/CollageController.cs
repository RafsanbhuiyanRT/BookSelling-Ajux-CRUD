using BookSelling_E_Comerse.Data;
using BookSelling_E_Comerse.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookSelling_E_Comerse.Controllers;

public class CollageController: Controller
{
    private readonly ApplicatioDbContext _db;

    public CollageController(ApplicatioDbContext db)
    {
        _db = db;
    }
    public IActionResult CollageIndex()
    {
        return View();
    }
    [HttpGet]
    public IActionResult GetStudent(int id)
    {
        var std = _db.Collage.FirstOrDefault(x => x.Id == id);
        return Ok(std);
    }

    [HttpGet]
    public ActionResult<List<Collage>> GetAllStudent()
    {
        var students = _db.Collage.ToList();
        return Ok(students);
    }

    [HttpPost]
    public ActionResult Create(string name, int rol, string department)
    {
        var collage = new Collage
        {
           
            Name = name,
            Rol = rol,
            Department = department
        };
        _db.Add(collage);
        _db.SaveChanges();
        return Ok(collage.Id);
    }
}
