using BookSelling_E_Comerse.Data;
using BookSelling_E_Comerse.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookSelling_E_Comerse.Controllers;
public class StudentController : Controller
{
    private readonly ApplicatioDbContext _db;
    public StudentController(ApplicatioDbContext db)
    {
       _db = db;
        
    }
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult GetStudent(int id)
    {
        var st = _db.Students.FirstOrDefault(x => x.Id == id);
        return Ok(st);
    }

    [HttpGet]
    public ActionResult<List<Student>> GetAllStudent()
    {
        var st = _db.Students.ToList();
        return Ok(st);
    }
    [HttpPost]
    public ActionResult Create(string name, string studentId, string department, string city, string email) {
       var student = new Student {
           Name = name,
           StudentId = studentId,
           Department = department,
           City = city,
           Email = email
       };
        _db.Students.Add(student);
        _db.SaveChanges();
        return Ok(student);
    }
    [HttpPost]
    public ActionResult Update(int id, string name, string studentId, string department, string city, string email)
    {
        var student = _db.Students.FirstOrDefault(x=>x.Id == id);
        if(student is not null)
        {
            student.Name = name;
            student.StudentId = studentId;
            student.Department = department;
            student.City = city;
            student.Email = email;
            _db.Students.Update(student);
            _db.SaveChanges();
        }
         return Ok();
    }
    [HttpDelete]
    public ActionResult Delete(int id)
    {
        var st = _db.Students.FirstOrDefault(x=>x.Id ==id);
        _db.Remove(st!);
        _db.SaveChanges();
        return Ok();
    }
}
