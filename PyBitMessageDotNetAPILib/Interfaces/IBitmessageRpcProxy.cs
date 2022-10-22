using CookComputing.XmlRpc;

namespace PyBitMessageDotNetAPILib.objecterfaces
{
    public interface IBitmessageRpcProxy : IXmlRpcProxy
    {
        [XmlRpcMethod("add")]
        int Add(object stateNumber, object secondNumber);

        [XmlRpcMethod("decodeAddress")]
        object DecodeAddress(string address);

        [XmlRpcMethod("listAddresses")]
        object ListAddresses();

        [XmlRpcMethod("listAddressBookEntries")]
        object ListAddressBookEntries();

        [XmlRpcMethod("addAddressBookEntry")]
        object AddAddressBookEntry(string address, string label);

        [XmlRpcMethod("deleteAddressBookEntry")]
        object DeleteAddressBookEntry(string address);

        [XmlRpcMethod("createRandomAddress")]
        object CreateRandomAddress(string label, bool eighteenByteRipe = false, int totalDifficulty = 0, int smallMessageDifficulty = 0);

        [XmlRpcMethod("createDeterministicAddresses")]
        object CreateDeterministicAddresses(string passphrase, int numberOfAddresses = 1, int addressVersionNumber = 0, int streamNumber = 0, bool eighteenByteRipe = false, int totalDifficulty = 0, int smallMessageDifficulty = 0);

        [XmlRpcMethod("getDeterministicAddress")]
        object GetDeterministicAddress(string passphrase, int addressVersionNumber, int streamNumber);

        [XmlRpcMethod("createChan")]
        object CreateChan(string passphrase);

        [XmlRpcMethod("joinChan")]
        object JoinChan(string passphrase, string suppliedAddress);

        [XmlRpcMethod("leaveChan")]
        object LeaveChan(string address);

        [XmlRpcMethod("deleteAddress")]
        object DeleteAddress(string address);

        [XmlRpcMethod("enableAddress")]
        object EnableAddress(string address, bool enable = true);

        [XmlRpcMethod("getAllInboxMessages")]
        object GetAllInboxMessages();

        [XmlRpcMethod("getAllInboxMessageIds")]
        object GetAllInboxMessageIds();

        [XmlRpcMethod("getInboxMessageById")]
        object GetInboxMessageById(string hid, bool? readStatus);

        [XmlRpcMethod("getAllSentMessages")]
        object GetAllSentMessages();

        [XmlRpcMethod("getAllSentMessageIds")]
        object GetAllSentMessageIds();

        [XmlRpcMethod("getInboxMessagesByReceiver")]
        object GetInboxMessagesByReceiver(string toAddress);

        [XmlRpcMethod("getSentMessageById")]
        object GetSentMessageById(string hid);

        [XmlRpcMethod("getSentMessagesByAddress")]
        object GetSentMessagesByAddress(string fromAddress);

        [XmlRpcMethod("getSentMessageByAckData")]
        object GetSentMessageByAckData(string ackData);

        [XmlRpcMethod("trashMessage")]
        object TrashMessage(string msgid);

        [XmlRpcMethod("trashInboxMessage")]
        object TrashInboxMessage(string msgid);

        [XmlRpcMethod("trashSentMessage")]
        object TrashSentMessage(string msgid);

        [XmlRpcMethod("sendMessage")]
        object SendMessage(string toAddress, string fromAddress, string subject, string message, int encodingType = 2, int TTL = 4 * 24 * 60 * 60);

        [XmlRpcMethod("sendBroadcast")]
        object SendBroadcast(string fromAddress, string subject, string message, int encodingType = 2, int TTL = 4 * 24 * 60 * 60);

        [XmlRpcMethod("getStatus")]
        object GetStatus(string ackdata);

        [XmlRpcMethod("addSubscription")]
        object AddSubscription(string address, string label = "");

        [XmlRpcMethod("deleteSubscription")]
        object DeleteSubscription(string address);

        [XmlRpcMethod("listSubscriptions")]
        object ListSubscriptions();

        [XmlRpcMethod("disseminatePreEncryptedMsg")]
        object DisseminatePreEncryptedMsg(string encryptedPayload, int requiredAverageProofOfWorkNonceTrialsPerByte, int requiredPayloadLengthExtraBytes);

        [XmlRpcMethod("trashSentMessageByAckData")]
        object TrashSentMessageByAckData(string ackdata);

        [XmlRpcMethod("disseminatePubkey")]
        object DisseminatePubkey(string payload);

        [XmlRpcMethod("getMessageDataByDestinationHash")]
        object GetMessageDataByDestinationHash(string requestedHash);

        [XmlRpcMethod("clientStatus")]
        object ClientStatus();

        [XmlRpcMethod("helloWorld")]
        string HelloWorld(string a, string b);

        [XmlRpcMethod("statusBar")]
        object StatusBar(string message);

        [XmlRpcMethod("deleteAndVacuum")]
        object DeleteAndVacuum();

        [XmlRpcMethod("shutdown")]
        object Shutdown();
    }
}