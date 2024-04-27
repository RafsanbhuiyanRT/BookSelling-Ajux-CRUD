using System.ComponentModel.DataAnnotations;

namespace BookSelling_E_Comerse.Models;

public class House
{
    [Key]
    public int Id { get; set; }
    public string? HouseNumber { get; set; }
    public required string Name { get; set; }
    public required string City { get; set; }
}
