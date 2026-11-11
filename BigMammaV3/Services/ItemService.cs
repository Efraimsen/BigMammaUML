using BigMammaV3.Controller;
using BigMammaV3.Interfaces;
using BigMammaV3.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaV3.Services;

public class ItemService : IDataHandler
{
    public ItemRepository ItemRepository { get; set; }

    public void CreateItem()
    {

    }
}
