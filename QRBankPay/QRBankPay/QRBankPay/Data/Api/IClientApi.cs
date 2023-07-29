using Refit;
using System.Net.Http;
using System.Threading.Tasks;

namespace QRBankPay.Data.API
{
    public interface IClientApi
    {
        [Get("/Clients")]
        Task<HttpResponseMessage> GetClients();
    }
}

