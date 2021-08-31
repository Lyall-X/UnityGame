using Common.Data;
using Server.Interface;

namespace Server.Handler
{
    public abstract class BaseHandler : BaseBehaviour, IHandler
    {
        public abstract void OnMessage(ClientPeer peer, byte[] bytes);
    }
}
