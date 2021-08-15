﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DG_Tweening_PathTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(DG.Tweening.PathType));
		L.RegVar("Linear", new LuaCSFunction(get_Linear), null);
		L.RegVar("CatmullRom", new LuaCSFunction(get_CatmullRom), null);
		L.RegVar("CubicBezier", new LuaCSFunction(get_CubicBezier), null);
		L.RegFunction("IntToEnum", new LuaCSFunction(IntToEnum));
		L.EndEnum();
		TypeTraits<DG.Tweening.PathType>.Check = CheckType;
		StackTraits<DG.Tweening.PathType>.Push = Push;
	}

	static void Push(IntPtr L, DG.Tweening.PathType arg)
	{
		ToLua.Push(L, arg);
	}

	static Type TypeOf_DG_Tweening_PathType = typeof(DG.Tweening.PathType);

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(TypeOf_DG_Tweening_PathType, L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Linear(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.PathType.Linear);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CatmullRom(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.PathType.CatmullRom);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CubicBezier(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.PathType.CubicBezier);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tointeger(L, 1);
		DG.Tweening.PathType o = (DG.Tweening.PathType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

