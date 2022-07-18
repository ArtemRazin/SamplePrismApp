using System;
using System.Threading.Tasks;
using SampleSharedLib;

namespace ModuleB.Services
{
    public class OrderService : IOrderService
    {
        
        public async Task<SampleGetOrdersResponse> GetOrdersAsync(SampleGetOrdersRequest request)
        {
            return await DoSomethingAsync();
        }

        private async Task<SampleGetOrdersResponse> DoSomethingAsync()
        {
            throw new NotImplementedException();
        }
    }
}
