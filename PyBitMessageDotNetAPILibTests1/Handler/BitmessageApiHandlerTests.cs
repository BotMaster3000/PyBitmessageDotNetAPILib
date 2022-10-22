using Microsoft.VisualStudio.TestTools.UnitTesting;
using PyBitMessageDotNetAPILib.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyBitMessageDotNetAPILib.Handler.Tests
{
    [TestClass]
    public class BitmessageApiHandlerTests
    {
        [TestMethod]
        public void BitmessageApiHandlerTest()
        {
            BitmessageApiHandler handler = new("http://127.0.0.1:8442", "username", "password");
            string result = handler.Proxy.HelloWorld("test", "213123");
            Assert.AreEqual("test-213123", result);
        }
    }
}