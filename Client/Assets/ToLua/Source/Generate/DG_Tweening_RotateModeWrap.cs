//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DG_Tweening_RotateModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(DG.Tweening.RotateMode));
		L.RegVar("Fast", new LuaCSFunction(get_Fast), null);
		L.RegVar("FastBeyond360", new LuaCSFunction(get_FastBeyond360), null);
		L.RegVar("WorldAxisAdd", new LuaCSFunction(get_WorldAxisAdd), null);
		L.RegVar("LocalAxisAdd", new LuaCSFunction(get_LocalAxisAdd), null);
		L.RegFunction("IntToEnum", new LuaCSFunction(IntToEnum));
		L.EndEnum();
		TypeTraits<DG.Tweening.RotateMode>.Check = CheckType;
		StackTraits<DG.Tweening.RotateMode>.Push = Push;
	}

	static void Push(IntPtr L, DG.Tweening.RotateMode arg)
	{
		ToLua.Push(L, arg);
	}

	static Type TypeOf_DG_Tweening_RotateMode = typeof(DG.Tweening.RotateMode);

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(TypeOf_DG_Tweening_RotateMode, L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Fast(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.RotateMode.Fast);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FastBeyond360(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.RotateMode.FastBeyond360);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_WorldAxisAdd(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.RotateMode.WorldAxisAdd);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LocalAxisAdd(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.RotateMode.LocalAxisAdd);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tointeger(L, 1);
		DG.Tweening.RotateMode o = (DG.Tweening.RotateMode)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

