using Client.Handler;
using Common.Define;
using System.Collections.Generic;

namespace Client.Manager
{
    internal class CSMsgDispatcher : BaseDispatcher
    {
        Dictionary<string, BaseHandler> mHandlers = new Dictionary<string, BaseHandler>()
        {
            { Protocal.Default, new DefaultHandler() },
        };

        public override void OnMessage(string protoName, byte[] bytes)
        {
            if (mHandlers.TryGetValue(protoName, out BaseHandler handler))
            {
                if (handler != null)
                {
                    handler.OnMessage(bytes);
                }
            }
        }
    }
}