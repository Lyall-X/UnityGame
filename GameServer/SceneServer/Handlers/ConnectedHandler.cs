using Common.Data;
using Server;
using Server.Handler;
using log4net;

namespace GameLibs.SceneServer.Handlers
{
    public class ConnectedHandler : BaseHandler
    {
        private static readonly ILog logger = LogManager.GetLogger(AppServer.repository.Name, typeof(ConnectedHandler));

        public override void OnMessage(ClientPeer peer, byte[] bytes)
        {
            logger.Info(peer.EndPoint + " OnConnected!!");
        }
    }
}
