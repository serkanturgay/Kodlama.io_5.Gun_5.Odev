using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.io_5.Gun_5.Odev
{
    class OrderManager : IOrderManager
    {
        

        public void AddToCart( Order order)
        {
            Console.WriteLine(  order.OrderName + "Sepete Eklendi.");
        }

        public void Buy( Order order)
        {
            Console.WriteLine(order.Price + " TL Fiyata " + order.OrderName + " Satin Alindi.");

        }
    }
}
