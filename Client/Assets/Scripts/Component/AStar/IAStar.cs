using System.Collections.Generic;
using UnityEngine;

namespace Client.Component
{
    public interface IAStar
    {
        bool IsWalkable(Vector3Int pos);
        Vector3 GetCellPos(Vector3Int pos);
        void DrawDebuggerNode(Dictionary<Vector3Int, Node> allNode, Vector3Int[] path);
    }
}

