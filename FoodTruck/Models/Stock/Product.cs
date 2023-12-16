namespace FoodTruck.Models.Stock;

public record Product(Guid Id, string Name, string Description,ProductCategory ProductCategory);