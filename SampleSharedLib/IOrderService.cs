using System.Threading.Tasks;

namespace SampleSharedLib
{
    public interface IOrderService
    {
        Task<SampleGetOrdersResponse> GetOrdersAsync(SampleGetOrdersRequest request);
    }
}
