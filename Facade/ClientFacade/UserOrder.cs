
using Facade.Interfaces;
using Facade.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.ClientFacade
{
    public class UserOrder : IUserOrder
    {
        public int AddToCart(int itemId, int qty)
        {
            Console.WriteLine("Start Add item to cart");

            //Iniialze shooping cart
            ICart userCart = new ShoppingCart();

            //Get item details
            Product item = userCart.GetItemDetails(itemId);

            //check item avaialbity
            if (!userCart.IsItemAvailable(itemId))
                return -1;

            //Lock the item in the stock.
            userCart.LockItemInStock(itemId, qty);

            //Add item to the cart.
            var cartId = userCart.AddItemToCart(itemId, qty);
            Console.WriteLine("Item Added to cart: " + cartId);

            return cartId;
        }

        public int PlaceOrder(int cartID, int userID)
        {
            Console.WriteLine("Start Place order");

            int orderID = -1;
            IWallet wallet = new Wallet();
            ITax tax = new Tax();
            ICart userCart = new ShoppingCart();
            IAddressDetails address = new AddressDetails();
            IOrder order = new Order();
            //Step 1 : Get Tax percentage by State
            double stateTax = tax.GetTaxPercentage();
            //Step 2 : Apply Tax on the Cart Items
            tax.ApplyTax(cartID, stateTax);
            //Step 3 : Get user Wallet balance
            double userWalletBalance = wallet.GetUserBalance(userID);
            //Step 4 : Get the cart items price
            double cartPrice = userCart.GetCartPrice(cartID);
            //Step 5 : Compare the balance and price
            if (userWalletBalance > cartPrice)
            {
                //Step 6 : Get user Address and set to cart
                Address userAddress = address.GetAddressDetails(userID);
                //Step 7 : Place the order
                orderID = order.PlaceOrder(cartID, userAddress.Id);

            }
            Console.WriteLine("End PlaceOrderDetails");
            return orderID;
        }
    }
}
