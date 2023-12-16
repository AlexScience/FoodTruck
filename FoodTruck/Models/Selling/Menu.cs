namespace FoodTruck.Models.Selling;

public record Menu(Guid Id, string Name, List<MenuItem> MenuItems, string Description);