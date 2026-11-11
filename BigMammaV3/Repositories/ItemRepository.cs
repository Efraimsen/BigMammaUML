using BigMammaV3.Configurations;
using BigMammaV3.Interfaces;
using BigMammaV3.Models;

namespace BigMammaV3.Repositories;

public class ItemRepository : JsonRepository<Item>
{

    public ItemRepository(IJsonService jsonService, AppSettings settings) 
                         : base(jsonService, Path.Combine(settings.Storage.DataDirectory, settings.Storage.ItemFileName))
    {

    }

    public override string ToString()
    {
        int length = 100;
        string allItems = $"{new string('-', length)}\n{new string(' ', 10)}Pizza Menu\n{new string('-', length)}\n";
        foreach (KeyValuePair<int, Item> item in Entities)
        {
            int deadspacePreName = 10 - Convert.ToString(item.Key).Length;
            int deadspacePreDescription = 20 - item.Value.Name.Length;
            int deadspacePrePrice = 70 - item.Value.Description.Length - Convert.ToString(item.Value.Price).Length - 2;

            allItems += $"{item.Key}{new string(' ', deadspacePreName)}{item.Value.Name}{new string(' ', deadspacePreDescription)}{item.Value.Description}{new string(' ', deadspacePrePrice)}{item.Value.Price},-\n{new string('-', length)}\n";
        }

        return allItems;
        
    }
}
