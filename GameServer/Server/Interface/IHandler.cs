using Common.Data;

namespace Server.Interface
{
    public interface IHandler : IObject
    {
        void OnMessage(ClientPeer peer, byte[] bytes);
    }
}
