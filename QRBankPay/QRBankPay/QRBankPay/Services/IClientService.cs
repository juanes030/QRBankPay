using QRBankPay.Data.Dto;
using QRBankPay.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QRBankPay.Services
{
    public interface IClientService
    {
        Task<List<Client>> GetClients();
        Task<ClientDetailDto> GetClient(long clientId);
    }
}


