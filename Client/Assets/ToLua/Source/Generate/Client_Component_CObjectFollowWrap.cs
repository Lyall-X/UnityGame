//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Client_Component_CObjectFollowWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Client.Component.CObjectFollow), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("AddItem", new LuaCSFunction(AddItem));
		L.RegFunction("RemoveItem", new LuaCSFunction(RemoveItem));
		L.RegFunction("__eq", new LuaCSFunction(op_Equality));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddItem(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			Client.Component.CObjectFollow obj = (Client.Component.CObjectFollow)ToLua.CheckObject<Client.Component.CObjectFollow>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Client.Component.FollowType arg1 = (Client.Component.FollowType)ToLua.CheckObject(L, 3, TypeTraits<Client.Component.FollowType>.type);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			UnityEngine.Transform arg3 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 5);
			UnityEngine.Transform arg4 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 6);
			obj.AddItem(arg0, arg1, arg2, arg3, arg4);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveItem(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Client.Component.CObjectFollow obj = (Client.Component.CObjectFollow)ToLua.CheckObject<Client.Component.CObjectFollow>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.RemoveItem(arg0);
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

