namespace CodeAssignment.Models;

public abstract class Fruit
{
    protected Fruit(decimal weight, string color, decimal price, DateTime datePicked, bool hasSeed)
    {
        Weight = weight;
        Color = color;
        Price = price;
        DatePicked = datePicked;
        HasSeed = hasSeed;
    }

    public string Name 
    { 
        get
        {
            return this.GetType().Name;
        }
    }
    public decimal Weight { get; set; }
    public string Color { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public DateTime DatePicked { get; set; }
    public bool HasSeed { get; set; }
    
    public virtual string MakeEdible()
    {
        return "Wash";
    }
}
