using BigMammaV3.Interfaces;
using BigMammaV3.Services;


namespace BigMammaV3.Models;

public class Order
{
    public Member Customer { get; set; } //TODO
    public List<OrderLine> Items { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal TotalVAT { get; set; }

    public Order(Member customer)
    {
        Customer = customer;
    }

    public void Add(IRepository<Item> repository, int id)
    {
        Item item = repository.Get(id);
        int quantity = 1;
        if (Items.Any(items => items.Item.Name == item.Name))
        {
            quantity = Items.Find(items => items.Item.Name == item.Name).Quantity;
        }
        int i = GetNextOrderLineId(item);
        Items.Add(new OrderLine(id, item, quantity));

    }
    public decimal CalculateTotalPrice()
    {
        return Items.Sum(item => item.Price);
    }
    public decimal CalculateTotalVAT()
    {
        return Items.Sum(item => item.VAT);
    }

    public int GetNextOrderLineId(Item item)
    {
        int nextId = 10;
        if (Items.Any())
        {
            nextId = Items.Last().LineId;
        }
        if (!Items.Any() && item.Category != Category.Topping)
        {
            return nextId;
        }
        else if (item.Category == Category.Beverage || item.Category == Category.Pizza)
        {
            nextId = (int)(Math.Floor(nextId / 10.0) * 10);
            nextId += 10;
        }
        else if (item.Category == Category.Topping)
        {
            Item lastItem = Items.Last().Item;
            OrderLine lastOrderLine = Items.Last();
            if (lastItem.Category == Category.Topping || lastItem.Category == Category.Pizza)
            {
                nextId = lastOrderLine.LineId + 1;

            }
        }

        return nextId;

    }
    public override string ToString()
    {
        string order = "Line\tItem\tQuantity\tPrice\tVAT\n";
        foreach (OrderLine orderline in Items)
        {
            order += $"{orderline}\n";
        }
        order += $"\tTotal Price:{TotalPrice}\t\tTotal VAT: {TotalVAT}";
        return order;
    }
}