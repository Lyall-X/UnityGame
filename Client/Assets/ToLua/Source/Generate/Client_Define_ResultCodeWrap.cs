﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Client_Define_ResultCodeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(Client.Define.ResultCode));
		L.RegVar("Success", new LuaCSFunction(get_Success), null);
		L.RegVar("Failed", new LuaCSFunction(get_Failed), null);
		L.RegVar("ExistUser", new LuaCSFunction(get_ExistUser), null);
		L.RegFunction("IntToEnum", new LuaCSFunction(IntToEnum));
		L.EndEnum();
		TypeTraits<Client.Define.ResultCode>.Check = CheckType;
		StackTraits<Client.Define.ResultCode>.Push = Push;
	}

	static void Push(IntPtr L, Client.Define.ResultCode arg)
	{
		ToLua.Push(L, arg);
	}

	static Type TypeOf_Client_Define_ResultCode = typeof(Client.Define.ResultCode);

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(TypeOf_Client_Define_ResultCode, L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Success(IntPtr L)
	{
		ToLua.Push(L, Client.Define.ResultCode.Success);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Failed(IntPtr L)
	{
		ToLua.Push(L, Client.Define.ResultCode.Failed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ExistUser(IntPtr L)
	{
		ToLua.Push(L, Client.Define.ResultCode.ExistUser);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tointeger(L, 1);
		Client.Define.ResultCode o = (Client.Define.ResultCode)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

