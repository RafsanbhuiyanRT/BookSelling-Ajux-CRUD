namespace BookSelling_E_Comerse.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? CategoryName { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
