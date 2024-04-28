namespace CodeAssignment.Models;

public class Coconut: Fruit
{
    public Coconut(decimal weight, string color, decimal price, DateTime datePicked, bool hasSeed)
        : base(weight, color, price, datePicked, hasSeed)
    {
    }

    public override string MakeEdible()
    {
        return "Peel";
    }
}
