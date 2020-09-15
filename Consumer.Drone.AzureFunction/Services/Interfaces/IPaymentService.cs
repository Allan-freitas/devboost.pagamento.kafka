using System.Net.Http;
using System.Threading.Tasks;

namespace Consumer.Drone.AzureFunction.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<HttpResponseMessage> AtualizaStatusPedido(string token, string jsonBody);
    }
}
