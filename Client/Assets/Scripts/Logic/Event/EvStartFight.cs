
using System;

namespace Client.Logic.Event
{
    /// <summary>
    /// 开始战斗
    /// </summary>
    internal class EvStartFight : BaseSceneEvent
    {
        public override void OnExecute(string param, Action moveNext)
        {
            battleHandlerMgr.StartFight(moveNext);
        }
    }
}