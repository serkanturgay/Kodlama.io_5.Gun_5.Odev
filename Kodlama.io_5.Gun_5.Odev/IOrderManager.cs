using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.io_5.Gun_5.Odev
{
    interface IOrderManager
    {
        void Buy( Order order);
        void AddToCart( Order order);
    }
}
