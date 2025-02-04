﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookSelling_E_Comerse.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required, DisplayName("Category Name")]
    public string? Name { get; set; }
    [DisplayName("Display Order")]
    public string? DisplayOreder { get; set; }
}
