﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Client_Manager_ResourceManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Client.Manager.ResourceManager), typeof(Client.Manager.BaseManager));
		L.RegFunction("InitResManifest", new LuaCSFunction(InitResManifest));
		L.RegFunction("TakeSnapshot", new LuaCSFunction(TakeSnapshot));
		L.RegFunction("ClearSnapshot", new LuaCSFunction(ClearSnapshot));
		L.RegFunction("DiffSnapshot", new LuaCSFunction(DiffSnapshot));
		L.RegFunction("LoadAssetAsync", new LuaCSFunction(LoadAssetAsync));
		L.RegFunction("New", new LuaCSFunction(_CreateClient_Manager_ResourceManager));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateClient_Manager_ResourceManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Client.Manager.ResourceManager obj = new Client.Manager.ResourceManager();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Client.Manager.ResourceManager.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitResManifest(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Client.Manager.ResourceManager obj = (Client.Manager.ResourceManager)ToLua.CheckObject<Client.Manager.ResourceManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			System.Action arg1 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 3);
			obj.InitResManifest(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TakeSnapshot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Client.Manager.ResourceManager obj = (Client.Manager.ResourceManager)ToLua.CheckObject<Client.Manager.ResourceManager>(L, 1);
			obj.TakeSnapshot();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearSnapshot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Client.Manager.ResourceManager obj = (Client.Manager.ResourceManager)ToLua.CheckObject<Client.Manager.ResourceManager>(L, 1);
			obj.ClearSnapshot();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DiffSnapshot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Client.Manager.ResourceManager obj = (Client.Manager.ResourceManager)ToLua.CheckObject<Client.Manager.ResourceManager>(L, 1);
			obj.DiffSnapshot();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAssetAsync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			Client.Manager.ResourceManager obj = (Client.Manager.ResourceManager)ToLua.CheckObject<Client.Manager.ResourceManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string[] arg1 = ToLua.CheckStringArray(L, 3);
			System.Type arg2 = ToLua.CheckMonoType(L, 4);
			LuaFunction arg3 = ToLua.CheckLuaFunction(L, 5);
			obj.LoadAssetAsync(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

