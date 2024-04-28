namespace CodeAssignment.Models;

public class Apple : Fruit
{
    public Apple(decimal weight, string color, decimal price, DateTime datePicked, bool hasSeed)
        : base(weight, color, price, datePicked, hasSeed)
    {
    }
}
