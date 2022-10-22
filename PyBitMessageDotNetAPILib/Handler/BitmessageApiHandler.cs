using CookComputing.XmlRpc;
using PyBitMessageDotNetAPILib.objecterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyBitMessageDotNetAPILib.Handler
{
    public class BitmessageApiHandler
    {
        public IBitmessageRpcProxy Proxy { get; }

        public BitmessageApiHandler(string url, string username, string password)
        {
            Proxy = XmlRpcProxyGen.Create<IBitmessageRpcProxy>();
            Proxy.Url = url;
            string loginDataBase64String = Convert.ToBase64String(
                Encoding.UTF8.GetBytes($"{username}:{password}"));

            Proxy.Headers.Add("Authorization", $"Basic ${loginDataBase64String}");
        }
    }
}
