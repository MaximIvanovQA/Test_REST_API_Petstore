using System;
using RestSharp;

namespace Test_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://petstore.swagger.io/v2");
            var request = new RestRequest("user/login?username=max&password=123456789", Method.GET);
            var response = client.Get(request);

        }
    }
}
