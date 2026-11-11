using BigMammaV3.Services;
using BigMammaV3.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaV3.Controller;

public class OrderController
{
    public OrderService OrderService { get; set; }
    public Input Input { get; set; }
}
