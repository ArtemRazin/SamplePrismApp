using System.Threading.Tasks;

namespace SampleSharedLib
{
    public interface ICustomerService
    {
        Task<SampleGetCustomerResponse> GetCustomerAsync(SampleGetCustomerRequest request);
    }
}
