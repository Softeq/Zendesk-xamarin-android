using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace Zendesk.Messaging
{
    public partial class BelvedereMediaResolverCallback
    {
        public override void Success(Java.Lang.Object obj)
        {
            Success((IList<Belvedere.MediaResult>)obj);
        }
    }
}
