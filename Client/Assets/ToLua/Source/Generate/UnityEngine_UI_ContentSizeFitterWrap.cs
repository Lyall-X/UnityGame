//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_ContentSizeFitterWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.ContentSizeFitter), typeof(UnityEngine.EventSystems.UIBehaviour));
		L.RegFunction("SetLayoutHorizontal", new LuaCSFunction(SetLayoutHorizontal));
		L.RegFunction("SetLayoutVertical", new LuaCSFunction(SetLayoutVertical));
		L.RegFunction("__eq", new LuaCSFunction(op_Equality));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("horizontalFit", new LuaCSFunction(get_horizontalFit), new LuaCSFunction(set_horizontalFit));
		L.RegVar("verticalFit", new LuaCSFunction(get_verticalFit), new LuaCSFunction(set_verticalFit));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLayoutHorizontal(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.ContentSizeFitter obj = (UnityEngine.UI.ContentSizeFitter)ToLua.CheckObject<UnityEngine.UI.ContentSizeFitter>(L, 1);
			obj.SetLayoutHorizontal();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLayoutVertical(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.ContentSizeFitter obj = (UnityEngine.UI.ContentSizeFitter)ToLua.CheckObject<UnityEngine.UI.ContentSizeFitter>(L, 1);
			obj.SetLayoutVertical();
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

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_horizontalFit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.ContentSizeFitter obj = (UnityEngine.UI.ContentSizeFitter)o;
			UnityEngine.UI.ContentSizeFitter.FitMode ret = obj.horizontalFit;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index horizontalFit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_verticalFit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.ContentSizeFitter obj = (UnityEngine.UI.ContentSizeFitter)o;
			UnityEngine.UI.ContentSizeFitter.FitMode ret = obj.verticalFit;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index verticalFit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_horizontalFit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.ContentSizeFitter obj = (UnityEngine.UI.ContentSizeFitter)o;
			UnityEngine.UI.ContentSizeFitter.FitMode arg0 = (UnityEngine.UI.ContentSizeFitter.FitMode)ToLua.CheckObject(L, 2, TypeTraits<UnityEngine.UI.ContentSizeFitter.FitMode>.type);
			obj.horizontalFit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index horizontalFit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_verticalFit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.ContentSizeFitter obj = (UnityEngine.UI.ContentSizeFitter)o;
			UnityEngine.UI.ContentSizeFitter.FitMode arg0 = (UnityEngine.UI.ContentSizeFitter.FitMode)ToLua.CheckObject(L, 2, TypeTraits<UnityEngine.UI.ContentSizeFitter.FitMode>.type);
			obj.verticalFit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index verticalFit on a nil value");
		}
	}
}

