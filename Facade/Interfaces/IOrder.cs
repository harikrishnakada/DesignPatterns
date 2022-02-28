
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Interfaces
{
    public interface IOrder
    {
        int PlaceOrder(int cartId, int shippingAddressId);
    }

    public class Order : IOrder
    {
        public int PlaceOrder(int cartId, int shippingAddressId)
        {
            Console.WriteLine("Order Placed");
            return 10;
        }
    }
}
