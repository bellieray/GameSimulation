using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class OrderManager : IOrderController
    {
        public void AddGame(Order order)
        {
            Console.WriteLine("Game Added" + order.gameName);
        }

        public void AddPrice(Order Order)
        {
            Console.WriteLine("Game Price Added" + Order.gamePrice);
        }
    }
}
