namespace Zendesk.Chat
{
    public partial class ChatEngine
    {
        public override global::Zendesk.Messaging.IEngine.TransferOptionDescription GetTransferOptionDescription ()
        {
            return GetTransferOptionDescProperty;
        }
    }
}