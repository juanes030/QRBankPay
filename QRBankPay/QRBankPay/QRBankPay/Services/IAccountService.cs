using System.Threading.Tasks;

namespace QRBankPay.Services
{
    public interface IAccountService
    {
        Task<bool> LoginAsync(string userName, string password);
    }
}
