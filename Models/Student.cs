using System.ComponentModel.DataAnnotations;

namespace BookSelling_E_Comerse.Models;

public class Student
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string StudentId { get; set; }
    public required string Department { get; set; }
    public required string City { get; set; }
    public required string Email { get; set;}
   

}
