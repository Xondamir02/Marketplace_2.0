﻿using Marketplace.Services.Products.Entities;

namespace Marketplace.Services.Products.Models;

public class CreateProductModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }

    public List<ProductImageModel> Images { get; set; }
}