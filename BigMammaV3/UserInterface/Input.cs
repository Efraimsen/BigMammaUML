using BigMammaV3.Interfaces;
using BigMammaV3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaV3.UserInterface;

public class Input
{
    public Controller Controller { get; set; }

    public Input(Controller controller)
    {
        Controller = controller;
    }

    public void PizzaMenu(Member customer)
    {
        Order order = new Order(customer);
        while (true)
        {
            string? input = Console.ReadLine();
            Action action = input switch
            {
                "1" => () => order.Add(Controller.Get(1)),
                "2" => () => order.Add(Controller.Get(2)),
                "3" => () => order.Add(Controller.Get(3)),
                "4" => () => order.Add(Controller.Get(4)),
                "5" => () => order.Add(Controller.Get(5)),
                "6" => () => order.Add(Controller.Get(6)),
                "7" => () => order.Add(Controller.Get(7)),
                "8" => () => order.Add(Controller.Get(8)),
                "9" => () => order.Add(Controller.Get(9)),
                "10" => () => order.Add(Controller.Get(10)),
                "cart" => () => Controller.Post()

            };
            action();

            if (input == "cart")
            {
                break;
            }
            else
            {
                ToppingsMenu();
            }
        }

    }
    public void ToppingsMenu()
    {

    }
    public void BeverageMenu()
    {

    }
}
