using Client.Component.FSM;
using Client.Logic.Manager;

namespace Client.Logic.FSM
{
    public class GameFSM : BaseFSM
    {
        protected static bool bRunning = false;
        protected static readonly object mLock = new object();

        protected static NPCDataManager npcDataMgr
        {
            get
            {
                return LogicBehaviour.npcDataMgr;
            }
        }
    }
}

