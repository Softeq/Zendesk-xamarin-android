using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace Zendesk.Classic.Messaging
{
    public partial class MediaResolverCallback
    {
        public override void Success(Java.Lang.Object obj)
        {
            Success((IList<global::Java.IO.File>)obj);
        }
    }
}
