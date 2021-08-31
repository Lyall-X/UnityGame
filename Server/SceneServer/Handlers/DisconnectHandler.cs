using Common.Data;
using Server;
using Server.Handler;
using log4net;

namespace GameLibs.SceneServer.Handlers
{

    public class DisconnectHandler : BaseHandler
    {
        private static readonly ILog logger = LogManager.GetLogger(AppServer.repository.Name, typeof(DisconnectHandler));

        public override void OnMessage(ClientPeer peer, byte[] bytes)
        {
            logger.Warn("connid:>" + peer.Id);
        }
    }
}
