﻿namespace CatalogAPI.Models;

public class Product
{
    public  Guid Id { get; set; }
    public required string Name { get; set; }
    public List<string> Category { get; set; } = new();
    public string Description { get; set; } = default!;
    public string ImageFile { get; set; } = default!;
    public decimal Price { get; set; }
}