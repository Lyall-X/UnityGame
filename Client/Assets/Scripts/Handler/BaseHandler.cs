using System.IO;

namespace Client.Handler
{
    public abstract class BaseHandler : BaseBehaviour
    {
        public abstract void OnMessage(byte[] bytes);
    }
}

