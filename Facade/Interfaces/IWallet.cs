namespace Facade.Interfaces
{
    public interface IWallet
    {
        double GetUserBalance(int userId);
    }

    public class Wallet : IWallet
    {
        public double GetUserBalance(int userId)
        {
            return 1563.45;
        }
    }

}
