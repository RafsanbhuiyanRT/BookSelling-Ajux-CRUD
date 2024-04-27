using System.ComponentModel.DataAnnotations;

namespace BookSelling_E_Comerse.Models.EmployFile;

public class EmpDepartment
{
    [Key]
    public int DepartmentId { get; set; }
    public required string DepartmentName { get; set; }
}
