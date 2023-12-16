using FoodTruck.Models.Cooking.Steps;

namespace FoodTruck.Models.Cooking;

public record Receipt(Guid Id, string Name, List<ICookingStep> CookingSteps, string Desription);