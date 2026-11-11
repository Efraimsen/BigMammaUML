using BigMammaV3.Interfaces;
using BigMammaV3.Repositories;

namespace BigMammaV3.Services;

public class OrderService : IDataHandler
{
    public OrderRepository OrderRepository { get; set; }

    public void CreateOrder()
    { 

    }
}
