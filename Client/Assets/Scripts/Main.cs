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
		DontDestroyOnLoad(gameObject);
	}

	protected override void OnUpdate()
	{
		base.OnUpdate();
		BaseBehaviour.OnUpdate(Time.deltaTime);
	}

	protected override void OnDestroyMe()
	{
		base.OnDestroyMe();
		Debug.Log("~Main wa destroyed");
	}

	/// <summary>
	/// 先于OnDestroyMe调用
	/// </summary>
	private void OnApplicationQuit()
	{
		AppConst.AppState = AppState.Exiting;    
	}
}
