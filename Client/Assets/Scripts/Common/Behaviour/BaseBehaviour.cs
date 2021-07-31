using System.Collections;
using UnityEngine;
using Client.Utility;
// using Client.Manager;

public abstract class BaseBehaviour
{
  public static void Initialize()
  {
    InitGameSettings();
    InitManager();
    // InitExtManager();
    // InitComponent();
  }
  
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

  private static void InitManager()
  {
    // AddMa
  }

  
}