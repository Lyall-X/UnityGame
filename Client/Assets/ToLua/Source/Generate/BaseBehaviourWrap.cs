//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class BaseBehaviourWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(BaseBehaviour), typeof(System.Object));
		L.RegFunction("Instantiate", new LuaCSFunction(Instantiate));
		L.RegFunction("Destroy", new LuaCSFunction(Destroy));
		L.RegFunction("StartCoroutine", new LuaCSFunction(StartCoroutine));
		L.RegFunction("GetExtManager", new LuaCSFunction(GetExtManager));
		L.RegFunction("GetManager", new LuaCSFunction(GetManager));
		L.RegFunction("OnUpdate", new LuaCSFunction(OnUpdate));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("configMgr", new LuaCSFunction(get_configMgr), null);
		L.RegVar("battleViewMgr", new LuaCSFunction(get_battleViewMgr), null);
		L.RegVar("luaMgr", new LuaCSFunction(get_luaMgr), null);
		L.RegVar("gameMgr", new LuaCSFunction(get_gameMgr), null);
		L.RegVar("tableMgr", new LuaCSFunction(get_tableMgr), null);
		L.RegVar("updateMgr", new LuaCSFunction(get_updateMgr), null);
		L.RegVar("extractMgr", new LuaCSFunction(get_extractMgr), null);
		L.RegVar("shaderMgr", new LuaCSFunction(get_shaderMgr), null);
		L.RegVar("fontMgr", new LuaCSFunction(get_fontMgr), null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Instantiate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BaseBehaviour obj = (BaseBehaviour)ToLua.CheckObject<BaseBehaviour>(L, 1);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 2);
			UnityEngine.Object o = obj.Instantiate(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
				BaseBehaviour.Destroy(arg0);
				return 0;
			}
			else if (count == 2)
			{
				UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				BaseBehaviour.Destroy(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: BaseBehaviour.Destroy");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartCoroutine(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BaseBehaviour obj = (BaseBehaviour)ToLua.CheckObject<BaseBehaviour>(L, 1);
			System.Collections.IEnumerator arg0 = ToLua.CheckIter(L, 2);
			UnityEngine.Coroutine o = obj.StartCoroutine(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetExtManager(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			object o = BaseBehaviour.GetExtManager(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetManager(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			Client.Manager.BaseManager o = BaseBehaviour.GetManager(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
			BaseBehaviour.OnUpdate(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_configMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, BaseBehaviour.configMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_battleViewMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, BaseBehaviour.battleViewMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, BaseBehaviour.luaMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gameMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, BaseBehaviour.gameMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tableMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, BaseBehaviour.tableMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, BaseBehaviour.updateMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_extractMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, BaseBehaviour.extractMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shaderMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, BaseBehaviour.shaderMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fontMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, BaseBehaviour.fontMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

