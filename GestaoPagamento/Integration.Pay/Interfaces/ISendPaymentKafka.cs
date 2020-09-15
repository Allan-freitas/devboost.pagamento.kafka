using Confluent.Kafka;
using Integration.Pay.Dto;
using System.Threading.Tasks;

namespace Integration.Pay.Interfaces
{
    public interface ISendPaymentKafka
    {
        Task<DeliveryResult<Null, string>> SendPay(RequestPaymentDto requestPaymentDto);
    }
}
