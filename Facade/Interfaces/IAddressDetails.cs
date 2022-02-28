using Facade.Model;

namespace Facade.Interfaces
{
    public interface IAddressDetails
    {
        Address GetAddressDetails(int userId);
    }

    public class AddressDetails : IAddressDetails
    {
        public Address GetAddressDetails(int userId)
        {
            Console.WriteLine($"Getting Address");
            return new Address() { Id = 1, Pincode = 411027, State = "Pune" };
        }
    }

}
