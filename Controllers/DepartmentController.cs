using BookSelling_E_Comerse.Data;
using BookSelling_E_Comerse.Models.EmployFile;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookSelling_E_Comerse.Controllers;
public class DepartmentController(ApplicatioDbContext db) : Controller
{
    private ApplicatioDbContext _db { get; } = db;
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult GetAllDepartment()
    {
        List<EmpDepartment> department = _db.EmpDepartment.ToList();
        return Ok(department);
    }
    [HttpGet]
    public ActionResult GetDropDepartment()
    {
        var department = _db.EmpDepartment
                        .Select(x => new SelectListItem
                        {
                            Text = x.DepartmentName,
                            Value = $"{ x.DepartmentId}"
                        }).ToList();
        return Ok(department);
    }

}
