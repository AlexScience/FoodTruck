namespace FoodTruck.Models.Cooking.Steps;

public record CommonCookingStep(Guid Id, Dish Dish) : ICookingStep
{
    
}