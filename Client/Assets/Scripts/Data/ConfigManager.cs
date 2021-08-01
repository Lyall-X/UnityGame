using UnityEngine;
using LuaInterface;

public class ConfigManager : BaseObject
{
  private static ConfigManager instance;

  public static ConfigManager Create()
  {
    if (instance == null)
    {
      instance = new ConfigManager();
    }
    return instance;
  }

  [NoToLua]
  public override void Initialize()
  {

  }

  [NoToLua]
  public override void OnUpdate(float deltaTime)
  {

  }

  [NoToLua]
  public override void OnDispose()
  {

  }
}