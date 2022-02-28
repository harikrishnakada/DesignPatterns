namespace Facade.Interfaces
{
    public interface ITax
    {
        double GetTaxPercentage();
        void ApplyTax(int cartId, double taxPercentage);
    }

    public class Tax : ITax
    {
        public void ApplyTax(int cartId, double taxPercentage)
        {
            Console.WriteLine("Applied Tax");
        }

        public double GetTaxPercentage()
        {
            return 17.0;
        }
    }

}
