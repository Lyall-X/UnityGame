using Client.Data;
using Client.Extensions;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Client.Logic.Event
{
    /// <summary>
    /// 出生敌人，
    /// </summary>
    internal class EvSpawnEnemy : BaseSceneEvent
    {
        public override void OnExecute(string param, Action moveNext)
        {
            // // Debug.Log("EvSpawnEnemy...");
            List<string> teamids = param.ToList<string>(',');
            battleHandlerMgr.InitNpcTeams(teamids, moveNext);
        }
    }
}