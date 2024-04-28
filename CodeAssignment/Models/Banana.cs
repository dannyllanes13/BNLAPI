namespace CodeAssignment.Models;

public class Banana : Fruit
{
    public Banana(decimal weight, string color, decimal price, DateTime datePicked, bool hasSeed)
        : base(weight, color, price, datePicked, hasSeed)
    {
    }
    public override string MakeEdible()
    {
        return "Peel";
    }
}
