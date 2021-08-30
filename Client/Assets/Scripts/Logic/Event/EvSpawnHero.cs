using Client.Data;
using System;
using UnityEngine;

namespace Client.Logic.Event
{
    /// <summary>
    /// 出生英雄NPC
    /// </summary>
    public class EvSpawnHero : BaseSceneEvent
    {
        public override void OnExecute(string param, Action moveNext)
        {
            // // Debug.Log("EvSpawnHero..." + param);
            battleHandlerMgr.SpawnHeros(moveNext);
        }
    }
}

