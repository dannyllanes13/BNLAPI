using CodeAssignment.Models;

namespace CodeAssignment.Services;

public interface IFruitServices
{
    List<Fruit> GetFruitList();

}

public class FruitsServices : IFruitServices
{
    public FruitsServices()
    {
        
    }

    public List<Fruit> GetFruitList()
    {
        var result = new List<Fruit>()
        {
            new Banana(3, "yellow", 3, DateTime.Now.AddDays(-5), false),
            new Banana(1, "yellow", 2, DateTime.Now.AddDays(-3), false),
            new Banana(2, "yellow", 2, DateTime.Now.AddDays(-2), false),
            new Banana(3, "yellow", 5, DateTime.Now.AddDays(-6), false),
            new Banana(2, "yellow", 2, DateTime.Now, false),
            new Apple(1, "red", 3, DateTime.Now.AddDays(-5), true),
            new Apple(3, "red", 1, DateTime.Now.AddDays(-2), true),
            new Apple(3, "red", 2, DateTime.Now.AddDays(-3), true),
            new Apple(1, "red", 3, DateTime.Now.AddDays(-1), true),
            new Apple(2, "red", 2, DateTime.Now.AddDays(-8), true),
            new Cherry(2, "red", 2, DateTime.Now.AddDays(-8), false),
            new Cherry(1, "red", 1, DateTime.Now.AddDays(-2), false),
            new Cherry(1, "red", 2, DateTime.Now.AddDays(-1), false),
            new Cherry(3, "red", 1, DateTime.Now, false),
            new Cherry(3, "red", 2, DateTime.Now.AddDays(-4), false),
            new Coconut(3, "green", 5, DateTime.Now.AddDays(-4), false),
            new Coconut(2, "green", 2, DateTime.Now.AddDays(-1), false),
            new Coconut(5, "green", 3, DateTime.Now.AddDays(-2), false),
            new Coconut(1, "green", 4, DateTime.Now.AddDays(-2), false),
            new Coconut(3, "green", 2, DateTime.Now.AddDays(-5), false),
            new Strawberry(3, "red", 2, DateTime.Now.AddDays(-5), false),
            new Strawberry(1, "red", 2, DateTime.Now.AddDays(-2), false),
            new Strawberry(1, "red", 2, DateTime.Now.AddDays(-4), false),
            new Strawberry(2, "red", 1, DateTime.Now.AddDays(-1), false),
            new Strawberry(2, "red", 2, DateTime.Now.AddDays(-8), false),
            new Kiwi(2, "brown", 2, DateTime.Now.AddDays(-8), true),
            new Kiwi(1, "brown", 5, DateTime.Now.AddDays(-4), true),
            new Kiwi(3, "brown", 2, DateTime.Now.AddDays(-5), true),
            new Kiwi(2, "brown", 1, DateTime.Now.AddDays(-2), true),
            new Kiwi(2, "brown", 1, DateTime.Now.AddDays(-1), true),

        };

        return result;
    }
    
}
