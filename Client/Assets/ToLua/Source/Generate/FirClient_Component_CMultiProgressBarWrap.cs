﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FirClient_Component_CMultiProgressBarWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Client.Component.CMultiProgressBar), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("SetColors", new LuaCSFunction(SetColors));
		L.RegFunction("SetValue", new LuaCSFunction(SetValue));
		L.RegFunction("Reset", new LuaCSFunction(Reset));
		L.RegFunction("__eq", new LuaCSFunction(op_Equality));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetColors(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Client.Component.CMultiProgressBar obj = (Client.Component.CMultiProgressBar)ToLua.CheckObject<Client.Component.CMultiProgressBar>(L, 1);
			obj.SetColors();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Client.Component.CMultiProgressBar obj = (Client.Component.CMultiProgressBar)ToLua.CheckObject<Client.Component.CMultiProgressBar>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.SetValue(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Client.Component.CMultiProgressBar obj = (Client.Component.CMultiProgressBar)ToLua.CheckObject<Client.Component.CMultiProgressBar>(L, 1);
			obj.Reset();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

