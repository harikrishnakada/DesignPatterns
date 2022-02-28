namespace Facade.ClientFacade
{
    public interface IUserOrder
    {
        int AddToCart(int itemId, int qty);
        int PlaceOrder(int cartId, int userId);
    }
}