using FoodTruck.Models.Cooking;

namespace FoodTruck.Models.Selling;

public record MenuItem(Guid Id, string Name, IngredientsList IngredientsList, string Description);