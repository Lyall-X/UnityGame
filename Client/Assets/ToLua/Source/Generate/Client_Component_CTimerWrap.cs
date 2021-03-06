//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Client_Component_CTimerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Client.Component.CTimer), typeof(BaseObject));
		L.RegFunction("Create", new LuaCSFunction(Create));
		L.RegFunction("Initialize", new LuaCSFunction(Initialize));
		L.RegFunction("OnUpdate", new LuaCSFunction(OnUpdate));
		L.RegFunction("AddTimer", new LuaCSFunction(AddTimer));
		L.RegFunction("AddLuaTimer", new LuaCSFunction(AddLuaTimer));
		L.RegFunction("RemoveTimer", new LuaCSFunction(RemoveTimer));
		L.RegFunction("CreateTicker", new LuaCSFunction(CreateTicker));
		L.RegFunction("OnDispose", new LuaCSFunction(OnDispose));
		L.RegFunction("New", new LuaCSFunction(_CreateClient_Component_CTimer));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateClient_Component_CTimer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Client.Component.CTimer obj = new Client.Component.CTimer();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Client.Component.CTimer.New");
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
			Client.Component.CTimer o = Client.Component.CTimer.Create();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Initialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Client.Component.CTimer obj = (Client.Component.CTimer)ToLua.CheckObject<Client.Component.CTimer>(L, 1);
			obj.Initialize();
			return 0;
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
			ToLua.CheckArgsCount(L, 2);
			Client.Component.CTimer obj = (Client.Component.CTimer)ToLua.CheckObject<Client.Component.CTimer>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.OnUpdate(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddTimer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4)
			{
				Client.Component.CTimer obj = (Client.Component.CTimer)ToLua.CheckObject<Client.Component.CTimer>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				System.Action<object> arg2 = (System.Action<object>)ToLua.CheckDelegate<System.Action<object>>(L, 4);
				Client.Component.TimerInfo o = obj.AddTimer(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 5)
			{
				Client.Component.CTimer obj = (Client.Component.CTimer)ToLua.CheckObject<Client.Component.CTimer>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				System.Action<object> arg2 = (System.Action<object>)ToLua.CheckDelegate<System.Action<object>>(L, 4);
				object arg3 = ToLua.ToVarObject(L, 5);
				Client.Component.TimerInfo o = obj.AddTimer(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 6)
			{
				Client.Component.CTimer obj = (Client.Component.CTimer)ToLua.CheckObject<Client.Component.CTimer>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				System.Action<object> arg2 = (System.Action<object>)ToLua.CheckDelegate<System.Action<object>>(L, 4);
				object arg3 = ToLua.ToVarObject(L, 5);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 6);
				Client.Component.TimerInfo o = obj.AddTimer(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Client.Component.CTimer.AddTimer");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddLuaTimer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 7);
			Client.Component.CTimer obj = (Client.Component.CTimer)ToLua.CheckObject<Client.Component.CTimer>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			LuaTable arg2 = ToLua.CheckLuaTable(L, 4);
			LuaFunction arg3 = ToLua.CheckLuaFunction(L, 5);
			object arg4 = ToLua.ToVarObject(L, 6);
			bool arg5 = LuaDLL.luaL_checkboolean(L, 7);
			Client.Component.TimerInfo o = obj.AddLuaTimer(arg0, arg1, arg2, arg3, arg4, arg5);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveTimer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Client.Component.CTimer obj = (Client.Component.CTimer)ToLua.CheckObject<Client.Component.CTimer>(L, 1);
			Client.Component.TimerInfo arg0 = (Client.Component.TimerInfo)ToLua.CheckObject<Client.Component.TimerInfo>(L, 2);
			obj.RemoveTimer(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateTicker(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Client.Component.CTimer obj = (Client.Component.CTimer)ToLua.CheckObject<Client.Component.CTimer>(L, 1);
			System.Collections.Generic.Dictionary<uint,uint> arg0 = (System.Collections.Generic.Dictionary<uint,uint>)ToLua.CheckObject(L, 2, TypeTraits<System.Collections.Generic.Dictionary<uint,uint>>.type);
			object arg1 = ToLua.ToVarObject(L, 3);
			System.Action<uint,object> arg2 = (System.Action<uint,object>)ToLua.CheckDelegate<System.Action<uint,object>>(L, 4);
			obj.CreateTicker(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Client.Component.CTimer obj = (Client.Component.CTimer)ToLua.CheckObject<Client.Component.CTimer>(L, 1);
			obj.OnDispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

