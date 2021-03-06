//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ItemTableItemWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ItemTableItem), typeof(System.Object));
		L.RegFunction("New", new LuaCSFunction(_CreateItemTableItem));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("id", new LuaCSFunction(get_id), new LuaCSFunction(set_id));
		L.RegVar("name", new LuaCSFunction(get_name), new LuaCSFunction(set_name));
		L.RegVar("quality", new LuaCSFunction(get_quality), new LuaCSFunction(set_quality));
		L.RegVar("typeid", new LuaCSFunction(get_typeid), new LuaCSFunction(set_typeid));
		L.RegVar("icon", new LuaCSFunction(get_icon), new LuaCSFunction(set_icon));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateItemTableItem(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				ItemTableItem obj = new ItemTableItem();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: ItemTableItem.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ItemTableItem obj = (ItemTableItem)o;
			int ret = obj.id;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index id on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ItemTableItem obj = (ItemTableItem)o;
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
	static int get_quality(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ItemTableItem obj = (ItemTableItem)o;
			int ret = obj.quality;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index quality on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_typeid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ItemTableItem obj = (ItemTableItem)o;
			int ret = obj.typeid;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index typeid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_icon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ItemTableItem obj = (ItemTableItem)o;
			string ret = obj.icon;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index icon on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ItemTableItem obj = (ItemTableItem)o;
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			obj.id = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index id on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ItemTableItem obj = (ItemTableItem)o;
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
	static int set_quality(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ItemTableItem obj = (ItemTableItem)o;
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			obj.quality = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index quality on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_typeid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ItemTableItem obj = (ItemTableItem)o;
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			obj.typeid = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index typeid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_icon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ItemTableItem obj = (ItemTableItem)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.icon = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index icon on a nil value");
		}
	}
}

