//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ConfigManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ConfigManager), typeof(BaseObject));
		L.RegFunction("Create", new LuaCSFunction(Create));
		L.RegFunction("GetDialogDataByKey", new LuaCSFunction(GetDialogDataByKey));
		L.RegFunction("GetEmbattlePosData", new LuaCSFunction(GetEmbattlePosData));
		L.RegFunction("GetSkillData", new LuaCSFunction(GetSkillData));
		L.RegFunction("GetChapterList", new LuaCSFunction(GetChapterList));
		L.RegFunction("GetDungeonData", new LuaCSFunction(GetDungeonData));
		L.RegFunction("GetTeamData", new LuaCSFunction(GetTeamData));
		L.RegFunction("GetMapData", new LuaCSFunction(GetMapData));
		L.RegFunction("GetRoleData", new LuaCSFunction(GetRoleData));
		L.RegFunction("GetBulletData", new LuaCSFunction(GetBulletData));
		L.RegFunction("GetBulletList", new LuaCSFunction(GetBulletList));
		L.RegFunction("GetEffectData", new LuaCSFunction(GetEffectData));
		L.RegFunction("GetEffectList", new LuaCSFunction(GetEffectList));
		L.RegFunction("New", new LuaCSFunction(_CreateConfigManager));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateConfigManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				ConfigManager obj = new ConfigManager();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: ConfigManager.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Create(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			ConfigManager o = ConfigManager.Create();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDialogDataByKey(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			ConfigManager obj = (ConfigManager)ToLua.CheckObject<ConfigManager>(L, 1);
			uint arg0 = (uint)LuaDLL.luaL_checkinteger(L, 2);
			uint arg1 = (uint)LuaDLL.luaL_checkinteger(L, 3);
			uint arg2 = (uint)LuaDLL.luaL_checkinteger(L, 4);
			Client.Data.DialogData o = obj.GetDialogDataByKey(arg0, arg1, arg2);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEmbattlePosData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ConfigManager obj = (ConfigManager)ToLua.CheckObject<ConfigManager>(L, 1);
			Client.Data.EmbattleType arg0 = (Client.Data.EmbattleType)ToLua.CheckObject(L, 2, TypeTraits<Client.Data.EmbattleType>.type);
			System.Collections.Generic.Dictionary<uint,UnityEngine.Vector3> o = obj.GetEmbattlePosData(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSkillData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ConfigManager obj = (ConfigManager)ToLua.CheckObject<ConfigManager>(L, 1);
			uint arg0 = (uint)LuaDLL.luaL_checkinteger(L, 2);
			System.Collections.Generic.Dictionary<string,Client.Data.SkillData> o = obj.GetSkillData(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChapterList(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ConfigManager obj = (ConfigManager)ToLua.CheckObject<ConfigManager>(L, 1);
			System.Collections.Generic.Dictionary<uint,Client.Data.ChapterData> o = obj.GetChapterList();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDungeonData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			ConfigManager obj = (ConfigManager)ToLua.CheckObject<ConfigManager>(L, 1);
			uint arg0 = (uint)LuaDLL.luaL_checkinteger(L, 2);
			uint arg1 = (uint)LuaDLL.luaL_checkinteger(L, 3);
			Client.Data.DungeonData o = obj.GetDungeonData(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTeamData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ConfigManager obj = (ConfigManager)ToLua.CheckObject<ConfigManager>(L, 1);
			uint arg0 = (uint)LuaDLL.luaL_checkinteger(L, 2);
			Client.Data.TeamData o = obj.GetTeamData(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMapData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ConfigManager obj = (ConfigManager)ToLua.CheckObject<ConfigManager>(L, 1);
			uint arg0 = (uint)LuaDLL.luaL_checkinteger(L, 2);
			Client.Data.MapData o = obj.GetMapData(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRoleData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ConfigManager obj = (ConfigManager)ToLua.CheckObject<ConfigManager>(L, 1);
			uint arg0 = (uint)LuaDLL.luaL_checkinteger(L, 2);
			Client.Data.RoleData o = obj.GetRoleData(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBulletData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ConfigManager obj = (ConfigManager)ToLua.CheckObject<ConfigManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Client.Data.BulletData o = obj.GetBulletData(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBulletList(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ConfigManager obj = (ConfigManager)ToLua.CheckObject<ConfigManager>(L, 1);
			System.Collections.Generic.Dictionary<string,Client.Data.BulletData> o = obj.GetBulletList();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEffectData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ConfigManager obj = (ConfigManager)ToLua.CheckObject<ConfigManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Client.Data.EffectData o = obj.GetEffectData(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEffectList(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ConfigManager obj = (ConfigManager)ToLua.CheckObject<ConfigManager>(L, 1);
			System.Collections.Generic.Dictionary<string,Client.Data.EffectData> o = obj.GetEffectList();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

