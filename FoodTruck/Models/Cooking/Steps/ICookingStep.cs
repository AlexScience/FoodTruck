namespace FoodTruck.Models.Cooking.Steps;

public interface ICookingStep
{
    public Guid Id { get; }
    public Dish Dish { get; }
    
}