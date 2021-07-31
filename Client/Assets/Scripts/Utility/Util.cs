using UnityEngine;
using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Client.Define;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Client.Utility
{
  public static class Util
  {
    public static GameSettings LoadGameSettings()
    {
      return Resources.Load<GameSettings>(AppConst.GameSettingName);
    }
  }
}