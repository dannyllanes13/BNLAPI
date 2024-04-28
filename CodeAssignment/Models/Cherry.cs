namespace CodeAssignment.Models;

public class Cherry : Fruit
{
    public Cherry(decimal weight, string color, decimal price, DateTime datePicked, bool hasSeed)
        : base(weight, color, price, datePicked, hasSeed)
    {
    }
}
