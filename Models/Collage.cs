using System.ComponentModel.DataAnnotations;

namespace BookSelling_E_Comerse.Models;

public class Collage
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int Rol { get; set; }
    public required string Department { get; set; }
}
