using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace GetProxySettings
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.IWebProxy webProxy = System.Net.WebProxy.GetDefaultProxy();

            Uri requestaddress = new Uri("https://github.com");

            Uri proxyAddress = webProxy.Get Proxy(requestaddress);

            Console.WriteLine(proxyAddress.AbsoluteUri);

            Console.ReadKey();
        }
    }
}
