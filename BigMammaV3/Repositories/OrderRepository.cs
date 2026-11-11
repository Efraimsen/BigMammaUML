using BigMammaV3.Configurations;
using BigMammaV3.Interfaces;
using BigMammaV3.Models;

namespace BigMammaV3.Repositories;

public class OrderRepository : JsonRepository<Order>
{

    public OrderRepository(IJsonService jsonService, AppSettings settings) 
                         : base(jsonService, Path.Combine(settings.Storage.DataDirectory, settings.Storage.OrderFileName))
    {
    }

}
