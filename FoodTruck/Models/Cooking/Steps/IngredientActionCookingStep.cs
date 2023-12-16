namespace FoodTruck.Models.Cooking.Steps;

public record IngredientActionCookingStep(Guid Id, Dish Dish) : ICookingStep
{
    public Ingredient Ingredient { get; }
}