using BookSelling_E_Comerse.Data;
using BookSelling_E_Comerse.Models.EmployFile;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BookSelling_E_Comerse.Controllers;
public class EmployController : Controller
{
    private readonly ApplicatioDbContext _db;
    public EmployController(ApplicatioDbContext db)
    {
        db = _db;
    }
    public IActionResult Index()
    {
        return View();
    }
   
    [HttpGet]
    public IActionResult GetEmploy(int id) { 
        var employ = _db.EmployList.FirstOrDefault(x => x.Id == id);
        if (employ is  null) { 
           return NotFound();
        }
        return Ok(employ);
    }
    [HttpPost]
    public ActionResult<List<EmployList>> GetAllEmploy()
    {
        var employ = _db.EmployList.ToList();
        return Ok(employ);
    }
    [HttpPost]
    public ActionResult Create(string name, string employId, string email, BloodGroup bloodGroup, bool isManager, int departmentID)
    {
        var val = Enum.GetValues(typeof(BloodGroup)).Cast<BloodGroup>().Select(v => new SelectListItem
        { 
            Text = v.GetType().GetMember(v.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
            Value = v.ToString() }).ToList();
        
 
        var employ = new EmployList
        {
            Name = name,
            EmployId = employId,
            Email = email,
            BloodGroup = bloodGroup,
            IsManager = isManager,
            DepartmentId = departmentID,
        };
        _db.Add(employ);
        _db.SaveChanges();
        return Ok(employ.Id);
    }

}
