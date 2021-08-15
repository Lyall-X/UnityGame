﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FirClient_Define_EventNamesWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Client.Define.EventNames), typeof(System.Object));
		L.RegFunction("New", new LuaCSFunction(_CreateFirClient_Define_EventNames));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("EvLogicUpdate", new LuaCSFunction(get_EvLogicUpdate), null);
		L.RegVar("EvNpcSpawn", new LuaCSFunction(get_EvNpcSpawn), null);
		L.RegVar("EvNpcSpawnOK", new LuaCSFunction(get_EvNpcSpawnOK), null);
		L.RegVar("EvEnterScene", new LuaCSFunction(get_EvEnterScene), null);
		L.RegVar("EvBeginPlay", new LuaCSFunction(get_EvBeginPlay), null);
		L.RegVar("EvMoveCamera", new LuaCSFunction(get_EvMoveCamera), null);
		L.RegVar("EvNpcSkillAttack", new LuaCSFunction(get_EvNpcSkillAttack), null);
		L.RegVar("EvNpcSkillAttackOK", new LuaCSFunction(get_EvNpcSkillAttackOK), null);
		L.RegVar("EvNpcDeath", new LuaCSFunction(get_EvNpcDeath), null);
		L.RegVar("EvEnterDungeon", new LuaCSFunction(get_EvEnterDungeon), null);
		L.RegVar("EvEnterDungeonOK", new LuaCSFunction(get_EvEnterDungeonOK), null);
		L.RegVar("EvBattleStart", new LuaCSFunction(get_EvBattleStart), null);
		L.RegVar("EvBattleEnd", new LuaCSFunction(get_EvBattleEnd), null);
		L.RegVar("EvChooseNpc", new LuaCSFunction(get_EvChooseNpc), null);
		L.RegVar("EvNpcMove", new LuaCSFunction(get_EvNpcMove), null);
		L.RegVar("EvNpcMoveOK", new LuaCSFunction(get_EvNpcMoveOK), null);
		L.RegVar("EvNpcFaceDir", new LuaCSFunction(get_EvNpcFaceDir), null);
		L.RegVar("EvNpcShow", new LuaCSFunction(get_EvNpcShow), null);
		L.RegVar("EvNpcShowOK", new LuaCSFunction(get_EvNpcShowOK), null);
		L.RegVar("EvShowDialog", new LuaCSFunction(get_EvShowDialog), null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFirClient_Define_EventNames(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Client.Define.EventNames obj = new Client.Define.EventNames();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Client.Define.EventNames.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvLogicUpdate(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvLogicUpdate);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvNpcSpawn(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvNpcSpawn);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvNpcSpawnOK(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvNpcSpawnOK);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvEnterScene(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvEnterScene);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvBeginPlay(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvBeginPlay);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvMoveCamera(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvMoveCamera);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvNpcSkillAttack(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvNpcSkillAttack);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvNpcSkillAttackOK(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvNpcSkillAttackOK);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvNpcDeath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvNpcDeath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvEnterDungeon(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvEnterDungeon);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvEnterDungeonOK(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvEnterDungeonOK);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvBattleStart(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvBattleStart);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvBattleEnd(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvBattleEnd);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvChooseNpc(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvChooseNpc);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvNpcMove(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvNpcMove);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvNpcMoveOK(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvNpcMoveOK);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvNpcFaceDir(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvNpcFaceDir);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvNpcShow(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvNpcShow);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvNpcShowOK(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvNpcShowOK);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EvShowDialog(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Client.Define.EventNames.EvShowDialog);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

