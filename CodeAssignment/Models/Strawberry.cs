namespace CodeAssignment.Models;

public class Strawberry : Fruit
{
    public Strawberry(decimal weight, string color, decimal price, DateTime datePicked, bool hasSeed)
        :base(weight, color, price, datePicked, hasSeed)
    {
    }
}
