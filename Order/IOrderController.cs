using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface IOrderController
    {
        void AddGame(Order order);
        void AddPrice(Order Order);
    }
}
