using System.Collections.Generic;

namespace SampleSharedLib
{
    public class SampleGetOrdersResponse
    {
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}