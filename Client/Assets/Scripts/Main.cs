using UnityEngine;
using Client.Define;

public class Main : GameBehaviour
{
    /// <summary>
    /// 初始化游戏管理器
    /// </summary>
    protected override void OnAwake()
    {
        AppConst.AppState = AppState.IsPlaying;
        base.OnAwake();
        this.Initialize();
    }

    /// <summary>
    /// 初始化
    /// </summary>
    void Initialize()
    {
        BaseBehaviour.Initialize();
    }
    void Update()
    {
        Debug.Log("aaaaa");
    }
}
