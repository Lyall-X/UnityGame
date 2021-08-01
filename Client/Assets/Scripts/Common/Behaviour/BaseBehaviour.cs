using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Client.Utility;
using Client.Manager;

public abstract class BaseBehaviour
{
  // 管理器字典
  static Dictionary<string, BaseManager> Managers = new Dictionary<string, BaseManager>();
  // 额外管理器
  static Dictionary<string, BaseObject> ExtManagers = new Dictionary<string, BaseObject>();

  public static void Initialize()
  {
    InitGameSettings();
    InitManager();
    InitExtManager();
    // InitComponent();
  }
  
  /// <summary>
  /// 初始化游戏设置
  /// </summary>
  private static void InitGameSettings()
  {
    var settings = Util.LoadGameSettings();
    if (settings != null)
    {
      AppConst.DebugMode = settings.debugMode;
      AppConst.LogMode = settings.logMode;
      AppConst.UpdateMode = settings.updateMode;
      AppConst.NetworkMode = settings.networkMode;
      AppConst.LuaByteMode = settings.luaByteMode;
      AppConst.ShowFps = settings.showFps;
      AppConst.GameFrameRate = settings.GameFrameRate;
    }
  }

  /// <summary>
  /// 初始化管理类
  /// </summary>
  private static void InitManager()
  {
    // addManager<>;
  }

  /// <summary>
  /// 初始化扩展管理器
  /// </summary>
  private static void InitExtManager()
  {

  }

  static T addManager<T>() where T : BaseManager, new()
  {
    var type = typeof(T);
    var obj = new T();
    Managers.Add(type.Name, obj);
    return obj;
  }

  public static T GetManager<T>() where T : class
  {
    var type = typeof(T);
    if (!Managers.ContainsKey(type.Name))
    {
      return null;
    }
    return Managers[type.Name] as T;
  }

  public static BaseManager GetManager(string managerName)
  {
    if (!Managers.ContainsKey(managerName))
    {
      return null;
    }
    return Managers[managerName];
  }

  public static object GetExtManager(string componentName)
  {
    if (!ExtManagers.ContainsKey(componentName))
    {
      return null;
    }
    return ExtManagers[componentName];
  }

  /// <summary>
  /// 控制器更新
  /// </summary>
  /// <param name="deltaTime"></param>
  public static void OnUpdate(float deltaTime)
  {
    // 驱动所有的管理器
    foreach (var mgr in Managers)
    {
      if (mgr.Value != null && mgr.Value.isOnUpdate)
      {
        mgr.Value.OnUpdate(deltaTime);
      }
    }
    // 驱动所有的组件
    foreach (var com in ExtManagers)
    {
      if (com.Value != null && com.Value.isOnUpdate)
      {
        com.Value.OnUpdate(deltaTime);
      }
    }
  }
  
}