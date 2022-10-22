using CookComputing.XmlRpc;
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
        private BitmessageApiHandler GetHandler()
        {
            return new("http://127.0.0.1:8442", "username", "password");
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_HelloWorld()
        {
            BitmessageApiHandler handler = GetHandler();
            string result = handler.Proxy.HelloWorld("test", "213123");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_Add()
        {
            BitmessageApiHandler handler = GetHandler();
            int result = handler.Proxy.Add(23, 11);
            Assert.AreEqual(23 + 11, result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_ListAddresses()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.ListAddresses();
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_ListAddressBookEntries()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.ListAddressBookEntries();
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_AddAddressBookEntry()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.AddAddressBookEntry("test", "213123");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_DeleteAddressBookEntry()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.DeleteAddressBookEntry("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_CreateRandomAddress()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.CreateRandomAddress("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_CreateDeterministicAddresses()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.CreateDeterministicAddresses("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_GetDeterministicAddress()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.GetDeterministicAddress("test", 2, 1);
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_CreateChan()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.CreateChan("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_JoinChan()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.JoinChan("test", "213123");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_LeaveChan()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.LeaveChan("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_DeleteAddress()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.DeleteAddress("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_EnableAddress()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.EnableAddress("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_GetAllInboxMessages()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.GetAllInboxMessages();
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_GetAllInboxMessageIds()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.GetAllInboxMessageIds();
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_GetInboxMessageById()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.GetInboxMessageById("test", null);
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_GetAllSentMessages()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.GetAllSentMessages();
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_GetAllSentMessageIds()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.GetAllSentMessageIds();
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_GetInboxMessagesByReceiver()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.GetInboxMessagesByReceiver("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_GetSentMessageById()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.GetSentMessageById("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_GetSentMessagesByAddress()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.GetSentMessagesByAddress("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_GetSentMessageByAckData()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.GetSentMessageByAckData("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_TrashMessage()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.TrashMessage("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_TrashInboxMessage()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.TrashInboxMessage("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_TrashSentMessage()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.TrashSentMessage("test");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_SendMessage()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendMessage("test", "213123", "123", "aawf");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_SendBroadcast()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }

        [TestMethod]
        public void BitmessageApiHandlerTest_GetStatus()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }

        [XmlRpcMethod("addSubscription")]
        public void BitmessageApiHandlerTest_AddSubscription()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }

        [XmlRpcMethod("deleteSubscription")]
        public void BitmessageApiHandlerTest_DeleteSubscription()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }

        [XmlRpcMethod("listSubscriptions")]
        public void BitmessageApiHandlerTest_ListSubscriptions()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }

        [XmlRpcMethod("disseminatePreEncryptedMsg")]
        public void BitmessageApiHandlerTest_DisseminatePreEncryptedMsg()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }

        [XmlRpcMethod("trashSentMessageByAckData")]
        public void BitmessageApiHandlerTest_TrashSentMessageByAckData()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }

        [XmlRpcMethod("disseminatePubkey")]
        public void BitmessageApiHandlerTest_DisseminatePubkey()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }

        [XmlRpcMethod("getMessageDataByDestinationHash")]
        public void BitmessageApiHandlerTest_GetMessageDataByDestinationHash()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }

        [XmlRpcMethod("clientStatus")]
        public void BitmessageApiHandlerTest_ClientStatus()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }

        [XmlRpcMethod("statusBar")]
        public void BitmessageApiHandlerTest_StatusBar()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }

        [XmlRpcMethod("deleteAndVacuum")]
        public void BitmessageApiHandlerTest_DeleteAndVacuum()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }

        [XmlRpcMethod("shutdown")]
        public void BitmessageApiHandlerTest_Shutdown()
        {
            BitmessageApiHandler handler = GetHandler();
            object result = handler.Proxy.SendBroadcast("test", "213123", "awdawdw");
            Assert.AreEqual("test-213123", result);
        }
    }
}