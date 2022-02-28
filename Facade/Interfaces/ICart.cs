using Facade.Model;

namespace Facade.Interfaces
{
    public interface ICart
    {
        Product GetItemDetails(int itemId);
        bool IsItemAvailable(int itemId);
        bool LockItemInStock(int itemId, int quantity);
        int AddItemToCart(int itemId, int quantity);
        double GetCartPrice(int cartid);
    }

    public class ShoppingCart : ICart
    {
        public int AddItemToCart(int itemId, int quantity)
        {
            Console.WriteLine("Added Item to Cart");
            return 17;
        }

        public double GetCartPrice(int cartid)
        {
            Console.WriteLine("Getting cart Price");
            return 563.25;
        }

        public Product GetItemDetails(int itemId)
        {
            Console.WriteLine("Getting Item details");
            return new Product();
        }

        public bool IsItemAvailable(int itemId)
        {
            Console.WriteLine("Checking if item is available");
            return true;
        }

        public bool LockItemInStock(int itemId, int quantity)
        {
            Console.WriteLine("Item locked in stock");
           return true;
        }
    }


}
