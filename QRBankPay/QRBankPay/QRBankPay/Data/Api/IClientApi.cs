using QRBankPay.Data.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QRBankPay.Data.API
{
    public interface IClientApi
    {
        [Get("/Clients")]
        Task<List<Client>> GetClients();
    }
}
