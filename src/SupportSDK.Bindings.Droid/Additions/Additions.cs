namespace Zendesk.Support
{
    public sealed partial class SupportSdkModule_ProvidesActionHandlersFactory
    {
        public Java.Lang.Object Get()
        {
            return (Java.Lang.Object)TypedGet();
        }
    }

    public partial class SupportEngine
    {
        public override global::Zendesk.Messaging.IEngine.TransferOptionDescription GetTransferOptionDescription ()
        {
            return GetTransferOptionDescProperty;
        }
    }
}

namespace Zendesk.Support.Request
{
    public sealed partial class RequestModule_ProvidesReducerFactory
    {
        public Java.Lang.Object Get()
        {
            return (Java.Lang.Object)TypedGet();
        }
    }
}
