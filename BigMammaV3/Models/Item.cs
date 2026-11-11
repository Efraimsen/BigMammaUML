namespace BigMammaV3.Models;

public enum Category
{
    Topping,
    Pizza,
    Beverage
}
public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    public decimal CostPrice { get; set; }
    public decimal Price { get; set; }

    public Item(string name, string description, Category category, decimal costPrice, decimal price)
    {
        Name = name;
        Description = description;
        Category = category;
        CostPrice = costPrice;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name}\t{Description}\t{Price},-";
    }
}
