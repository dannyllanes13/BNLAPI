namespace CodeAssignment.Models;

public class Kiwi : Fruit
{
    public Kiwi(decimal weight, string color, decimal price, DateTime datePicked, bool hasSeed)
        : base(weight, color, price, datePicked, hasSeed)
    {
    }
}
