using BookSelling_E_Comerse.Data;
using BookSelling_E_Comerse.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookSelling_E_Comerse.Controllers;
public class HouseController : Controller
{
    private readonly ApplicatioDbContext _dbContext;
    public HouseController(ApplicatioDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult HouseList()
    {
        return View(); 
    }
    [HttpGet]
    public ActionResult<List<House>> HouseDetail()
    {
        var house = _dbContext.House.ToList();
        return Ok(house);
    }
    [HttpPost]
    public ActionResult CreateHouse(string name, string houseNumber, string city)
    {
        var house = new House
        {
            Name = name,    
            HouseNumber = houseNumber,
            City = city
        };
        _dbContext.Add(house);
        _dbContext.SaveChanges();
        return Ok(house.Id);
    }
}
