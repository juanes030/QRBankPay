using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace QRBankPay.Helpers.HttpMessageHandlers
{
    public class BaseAddressHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            return response;
        }
    }
}
