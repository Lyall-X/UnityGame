﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Client_Component_VarDataWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Client.Component.VarData), typeof(System.Object));
		L.RegFunction("New", new LuaCSFunction(_CreateClient_Component_VarData));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("name", new LuaCSFunction(get_name), new LuaCSFunction(set_name));
		L.RegVar("type", new LuaCSFunction(get_type), new LuaCSFunction(set_type));
		L.RegVar("lastType", new LuaCSFunction(get_lastType), new LuaCSFunction(set_lastType));
		L.RegVar("objValue", new LuaCSFunction(get_objValue), new LuaCSFunction(set_objValue));
		L.RegVar("tranValue", new LuaCSFunction(get_tranValue), new LuaCSFunction(set_tranValue));
		L.RegVar("imgValue", new LuaCSFunction(get_imgValue), new LuaCSFunction(set_imgValue));
		L.RegVar("txtValue", new LuaCSFunction(get_txtValue), new LuaCSFunction(set_txtValue));
		L.RegVar("btnValue", new LuaCSFunction(get_btnValue), new LuaCSFunction(set_btnValue));
		L.RegVar("inputValue", new LuaCSFunction(get_inputValue), new LuaCSFunction(set_inputValue));
		L.RegVar("toggleValue", new LuaCSFunction(get_toggleValue), new LuaCSFunction(set_toggleValue));
		L.RegVar("sliderValue", new LuaCSFunction(get_sliderValue), new LuaCSFunction(set_sliderValue));
		L.RegVar("multiProgreValue", new LuaCSFunction(get_multiProgreValue), new LuaCSFunction(set_multiProgreValue));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateClient_Component_VarData(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Client.Component.VarData obj = new Client.Component.VarData();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Client.Component.VarData.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			string ret = obj.name;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			Client.Component.VarType ret = obj.type;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index type on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lastType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			Client.Component.VarType ret = obj.lastType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lastType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_objValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.GameObject ret = obj.objValue;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index objValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tranValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.Transform ret = obj.tranValue;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tranValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_imgValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.UI.Image ret = obj.imgValue;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index imgValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_txtValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.UI.Text ret = obj.txtValue;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index txtValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_btnValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.UI.Button ret = obj.btnValue;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index btnValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inputValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			TMPro.TMP_InputField ret = obj.inputValue;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index inputValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_toggleValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.UI.Toggle ret = obj.toggleValue;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index toggleValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sliderValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.UI.Slider ret = obj.sliderValue;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index sliderValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_multiProgreValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			Client.Component.CMultiProgressBar ret = obj.multiProgreValue;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index multiProgreValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.name = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			Client.Component.VarType arg0 = (Client.Component.VarType)ToLua.CheckObject(L, 2, TypeTraits<Client.Component.VarType>.type);
			obj.type = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index type on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lastType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			Client.Component.VarType arg0 = (Client.Component.VarType)ToLua.CheckObject(L, 2, TypeTraits<Client.Component.VarType>.type);
			obj.lastType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lastType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_objValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject<UnityEngine.GameObject>(L, 2);
			obj.objValue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index objValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tranValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 2);
			obj.tranValue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tranValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_imgValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.UI.Image arg0 = (UnityEngine.UI.Image)ToLua.CheckObject<UnityEngine.UI.Image>(L, 2);
			obj.imgValue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index imgValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_txtValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.UI.Text arg0 = (UnityEngine.UI.Text)ToLua.CheckObject<UnityEngine.UI.Text>(L, 2);
			obj.txtValue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index txtValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_btnValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.UI.Button arg0 = (UnityEngine.UI.Button)ToLua.CheckObject<UnityEngine.UI.Button>(L, 2);
			obj.btnValue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index btnValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_inputValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			TMPro.TMP_InputField arg0 = (TMPro.TMP_InputField)ToLua.CheckObject<TMPro.TMP_InputField>(L, 2);
			obj.inputValue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index inputValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_toggleValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.UI.Toggle arg0 = (UnityEngine.UI.Toggle)ToLua.CheckObject<UnityEngine.UI.Toggle>(L, 2);
			obj.toggleValue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index toggleValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sliderValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			UnityEngine.UI.Slider arg0 = (UnityEngine.UI.Slider)ToLua.CheckObject<UnityEngine.UI.Slider>(L, 2);
			obj.sliderValue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index sliderValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_multiProgreValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Client.Component.VarData obj = (Client.Component.VarData)o;
			Client.Component.CMultiProgressBar arg0 = (Client.Component.CMultiProgressBar)ToLua.CheckObject<Client.Component.CMultiProgressBar>(L, 2);
			obj.multiProgreValue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index multiProgreValue on a nil value");
		}
	}
}

