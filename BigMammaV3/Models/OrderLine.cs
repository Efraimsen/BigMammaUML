using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaV3.Models;

public class OrderLine
{
    public int LineId { get; set; }
    public Item Item { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal VAT { get; set; }

    public OrderLine(int id, Item item, int quantity)
    {
        LineId = id;
        Item = item;
        Quantity = quantity;
        Price = item.Price;
        VAT = item.Price / 1.25M;
    }

    public override string ToString()
    {
        return $"{LineId}\t{Item.Name}\t{Quantity}\t{Price}\t{VAT}";
    }
}
