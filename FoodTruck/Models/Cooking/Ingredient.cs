using FoodTruck.Models.Stock;

namespace FoodTruck.Models.Cooking;

public record Ingredient(Guid Id, string Name, string Description, ProductCategory ProductCategory);