using System;

namespace Client.Logic.Event
{
    public interface ISceneEvent
    {
        void OnExecute(string param, Action moveNext);
    }
}