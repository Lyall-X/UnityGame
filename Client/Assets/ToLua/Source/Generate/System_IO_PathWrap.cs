//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_IO_PathWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("Path");
		L.RegFunction("ChangeExtension", new LuaCSFunction(ChangeExtension));
		L.RegFunction("Combine", new LuaCSFunction(Combine));
		L.RegFunction("GetDirectoryName", new LuaCSFunction(GetDirectoryName));
		L.RegFunction("GetExtension", new LuaCSFunction(GetExtension));
		L.RegFunction("GetFileName", new LuaCSFunction(GetFileName));
		L.RegFunction("GetFileNameWithoutExtension", new LuaCSFunction(GetFileNameWithoutExtension));
		L.RegFunction("GetFullPath", new LuaCSFunction(GetFullPath));
		L.RegFunction("GetPathRoot", new LuaCSFunction(GetPathRoot));
		L.RegFunction("GetTempFileName", new LuaCSFunction(GetTempFileName));
		L.RegFunction("GetTempPath", new LuaCSFunction(GetTempPath));
		L.RegFunction("HasExtension", new LuaCSFunction(HasExtension));
		L.RegFunction("IsPathRooted", new LuaCSFunction(IsPathRooted));
		L.RegFunction("GetInvalidFileNameChars", new LuaCSFunction(GetInvalidFileNameChars));
		L.RegFunction("GetInvalidPathChars", new LuaCSFunction(GetInvalidPathChars));
		L.RegFunction("GetRandomFileName", new LuaCSFunction(GetRandomFileName));
		L.RegVar("AltDirectorySeparatorChar", new LuaCSFunction(get_AltDirectorySeparatorChar), null);
		L.RegVar("DirectorySeparatorChar", new LuaCSFunction(get_DirectorySeparatorChar), null);
		L.RegVar("PathSeparator", new LuaCSFunction(get_PathSeparator), null);
		L.RegVar("VolumeSeparatorChar", new LuaCSFunction(get_VolumeSeparatorChar), null);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ChangeExtension(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string o = System.IO.Path.ChangeExtension(arg0, arg1);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Combine(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<string, string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				string o = System.IO.Path.Combine(arg0, arg1);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<string, string, string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				string arg2 = ToLua.ToString(L, 3);
				string o = System.IO.Path.Combine(arg0, arg1, arg2);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes<string, string, string, string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				string arg2 = ToLua.ToString(L, 3);
				string arg3 = ToLua.ToString(L, 4);
				string o = System.IO.Path.Combine(arg0, arg1, arg2, arg3);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (TypeChecker.CheckParamsType<string>(L, 1, count))
			{
				string[] arg0 = ToLua.ToParamsString(L, 1, count);
				string o = System.IO.Path.Combine(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.IO.Path.Combine");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDirectoryName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = System.IO.Path.GetDirectoryName(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetExtension(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = System.IO.Path.GetExtension(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFileName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = System.IO.Path.GetFileName(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFileNameWithoutExtension(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = System.IO.Path.GetFileNameWithoutExtension(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFullPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = System.IO.Path.GetFullPath(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPathRoot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = System.IO.Path.GetPathRoot(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTempFileName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = System.IO.Path.GetTempFileName();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTempPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = System.IO.Path.GetTempPath();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasExtension(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = System.IO.Path.HasExtension(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsPathRooted(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = System.IO.Path.IsPathRooted(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInvalidFileNameChars(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			char[] o = System.IO.Path.GetInvalidFileNameChars();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInvalidPathChars(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			char[] o = System.IO.Path.GetInvalidPathChars();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRandomFileName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = System.IO.Path.GetRandomFileName();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AltDirectorySeparatorChar(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, System.IO.Path.AltDirectorySeparatorChar);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DirectorySeparatorChar(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, System.IO.Path.DirectorySeparatorChar);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PathSeparator(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, System.IO.Path.PathSeparator);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_VolumeSeparatorChar(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, System.IO.Path.VolumeSeparatorChar);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

