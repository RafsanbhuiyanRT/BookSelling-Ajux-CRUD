using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookSelling_E_Comerse.Models.EmployFile;

public enum BloodGroup
{
    [Display(Name = "O+")]
    OPositive,
    [Display(Name = "A+")]
    APositive,
    [Display(Name = "B+")]
    BPositive,
    [Display(Name = "AB+")]
    ABPositive,
    [Display(Name = "AB-")]
    ABNegative,
    [Display(Name = "A-")]
    ANegative,
    [Display(Name = "B-")]
    BNegative,
    [Display(Name = "O-")]
    ONegative
}
public class EmployList
{
    [Key]
    public  int Id { get; set; }
    public required string Name { get; set; }
    public required string  EmployId{ get; set; }
    public required string Email { get; set; }
    public BloodGroup BloodGroup { get; set; }
    public required bool IsManager { get; set; }
    public required int DepartmentId { get; set; } // Foreign key


    // Navigation property
    public EmpDepartment? EmpDepartment { get; set; }
}

