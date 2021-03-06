//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Client_Component_VarTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(Client.Component.VarType));
		L.RegVar("GameObject", new LuaCSFunction(get_GameObject), null);
		L.RegVar("Transform", new LuaCSFunction(get_Transform), null);
		L.RegVar("Image", new LuaCSFunction(get_Image), null);
		L.RegVar("Text", new LuaCSFunction(get_Text), null);
		L.RegVar("Button", new LuaCSFunction(get_Button), null);
		L.RegVar("TMP_InputField", new LuaCSFunction(get_TMP_InputField), null);
		L.RegVar("Toggle", new LuaCSFunction(get_Toggle), null);
		L.RegVar("Slider", new LuaCSFunction(get_Slider), null);
		L.RegVar("CMultiProgressBar", new LuaCSFunction(get_CMultiProgressBar), null);
		L.RegFunction("IntToEnum", new LuaCSFunction(IntToEnum));
		L.EndEnum();
		TypeTraits<Client.Component.VarType>.Check = CheckType;
		StackTraits<Client.Component.VarType>.Push = Push;
	}

	static void Push(IntPtr L, Client.Component.VarType arg)
	{
		ToLua.Push(L, arg);
	}

	static Type TypeOf_Client_Component_VarType = typeof(Client.Component.VarType);

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(TypeOf_Client_Component_VarType, L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GameObject(IntPtr L)
	{
		ToLua.Push(L, Client.Component.VarType.GameObject);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Transform(IntPtr L)
	{
		ToLua.Push(L, Client.Component.VarType.Transform);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Image(IntPtr L)
	{
		ToLua.Push(L, Client.Component.VarType.Image);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Text(IntPtr L)
	{
		ToLua.Push(L, Client.Component.VarType.Text);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Button(IntPtr L)
	{
		ToLua.Push(L, Client.Component.VarType.Button);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TMP_InputField(IntPtr L)
	{
		ToLua.Push(L, Client.Component.VarType.TMP_InputField);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Toggle(IntPtr L)
	{
		ToLua.Push(L, Client.Component.VarType.Toggle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Slider(IntPtr L)
	{
		ToLua.Push(L, Client.Component.VarType.Slider);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CMultiProgressBar(IntPtr L)
	{
		ToLua.Push(L, Client.Component.VarType.CMultiProgressBar);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tointeger(L, 1);
		Client.Component.VarType o = (Client.Component.VarType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

