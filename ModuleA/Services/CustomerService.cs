using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SampleSharedLib;

namespace ModuleA.Services
{
    public class CustomerService : ICustomerService
    {
        public async Task<SampleGetCustomerResponse> GetCustomerAsync(SampleGetCustomerRequest request)
        {
            return await DoSomethingAsync();
        }
        private async Task<SampleGetCustomerResponse> DoSomethingAsync()
        {
            throw new NotImplementedException();
        }
    }
}
