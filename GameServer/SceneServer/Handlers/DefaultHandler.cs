using Common.Data;
using Server;
using Server.Handler;
using log4net;
using System;

namespace GameLibs.SceneServer.Handlers
{
    public class DefaultHandler : BaseHandler
    {
        private static readonly ILog logger = LogManager.GetLogger(AppServer.repository.Name, typeof(DefaultHandler));

        public override void OnMessage(ClientPeer peer, byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }
}
