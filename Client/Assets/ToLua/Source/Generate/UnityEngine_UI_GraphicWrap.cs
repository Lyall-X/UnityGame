//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_GraphicWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.Graphic), typeof(UnityEngine.EventSystems.UIBehaviour));
		L.RegFunction("SetAllDirty", new LuaCSFunction(SetAllDirty));
		L.RegFunction("SetLayoutDirty", new LuaCSFunction(SetLayoutDirty));
		L.RegFunction("SetVerticesDirty", new LuaCSFunction(SetVerticesDirty));
		L.RegFunction("SetMaterialDirty", new LuaCSFunction(SetMaterialDirty));
		L.RegFunction("OnCullingChanged", new LuaCSFunction(OnCullingChanged));
		L.RegFunction("Rebuild", new LuaCSFunction(Rebuild));
		L.RegFunction("LayoutComplete", new LuaCSFunction(LayoutComplete));
		L.RegFunction("GraphicUpdateComplete", new LuaCSFunction(GraphicUpdateComplete));
		L.RegFunction("SetNativeSize", new LuaCSFunction(SetNativeSize));
		L.RegFunction("Raycast", new LuaCSFunction(Raycast));
		L.RegFunction("PixelAdjustPoint", new LuaCSFunction(PixelAdjustPoint));
		L.RegFunction("GetPixelAdjustedRect", new LuaCSFunction(GetPixelAdjustedRect));
		L.RegFunction("CrossFadeColor", new LuaCSFunction(CrossFadeColor));
		L.RegFunction("CrossFadeAlpha", new LuaCSFunction(CrossFadeAlpha));
		L.RegFunction("RegisterDirtyLayoutCallback", new LuaCSFunction(RegisterDirtyLayoutCallback));
		L.RegFunction("UnregisterDirtyLayoutCallback", new LuaCSFunction(UnregisterDirtyLayoutCallback));
		L.RegFunction("RegisterDirtyVerticesCallback", new LuaCSFunction(RegisterDirtyVerticesCallback));
		L.RegFunction("UnregisterDirtyVerticesCallback", new LuaCSFunction(UnregisterDirtyVerticesCallback));
		L.RegFunction("RegisterDirtyMaterialCallback", new LuaCSFunction(RegisterDirtyMaterialCallback));
		L.RegFunction("UnregisterDirtyMaterialCallback", new LuaCSFunction(UnregisterDirtyMaterialCallback));
		L.RegFunction("__eq", new LuaCSFunction(op_Equality));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("defaultGraphicMaterial", new LuaCSFunction(get_defaultGraphicMaterial), null);
		L.RegVar("color", new LuaCSFunction(get_color), new LuaCSFunction(set_color));
		L.RegVar("raycastTarget", new LuaCSFunction(get_raycastTarget), new LuaCSFunction(set_raycastTarget));
		L.RegVar("depth", new LuaCSFunction(get_depth), null);
		L.RegVar("rectTransform", new LuaCSFunction(get_rectTransform), null);
		L.RegVar("canvas", new LuaCSFunction(get_canvas), null);
		L.RegVar("canvasRenderer", new LuaCSFunction(get_canvasRenderer), null);
		L.RegVar("defaultMaterial", new LuaCSFunction(get_defaultMaterial), null);
		L.RegVar("material", new LuaCSFunction(get_material), new LuaCSFunction(set_material));
		L.RegVar("materialForRendering", new LuaCSFunction(get_materialForRendering), null);
		L.RegVar("mainTexture", new LuaCSFunction(get_mainTexture), null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAllDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			obj.SetAllDirty();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLayoutDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			obj.SetLayoutDirty();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetVerticesDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			obj.SetVerticesDirty();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetMaterialDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			obj.SetMaterialDirty();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnCullingChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			obj.OnCullingChanged();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rebuild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			UnityEngine.UI.CanvasUpdate arg0 = (UnityEngine.UI.CanvasUpdate)ToLua.CheckObject(L, 2, TypeTraits<UnityEngine.UI.CanvasUpdate>.type);
			obj.Rebuild(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LayoutComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			obj.LayoutComplete();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GraphicUpdateComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			obj.GraphicUpdateComplete();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetNativeSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			obj.SetNativeSize();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Raycast(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			UnityEngine.Camera arg1 = (UnityEngine.Camera)ToLua.CheckObject<UnityEngine.Camera>(L, 3);
			bool o = obj.Raycast(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PixelAdjustPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			UnityEngine.Vector2 o = obj.PixelAdjustPoint(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixelAdjustedRect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			UnityEngine.Rect o = obj.GetPixelAdjustedRect();
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFadeColor(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 5)
			{
				UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
				UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
				obj.CrossFadeColor(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 6)
			{
				UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
				UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 6);
				obj.CrossFadeColor(arg0, arg1, arg2, arg3, arg4);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.UI.Graphic.CrossFadeColor");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFadeAlpha(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
			obj.CrossFadeAlpha(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterDirtyLayoutCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			UnityEngine.Events.UnityAction arg0 = (UnityEngine.Events.UnityAction)ToLua.CheckDelegate<UnityEngine.Events.UnityAction>(L, 2);
			obj.RegisterDirtyLayoutCallback(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnregisterDirtyLayoutCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			UnityEngine.Events.UnityAction arg0 = (UnityEngine.Events.UnityAction)ToLua.CheckDelegate<UnityEngine.Events.UnityAction>(L, 2);
			obj.UnregisterDirtyLayoutCallback(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterDirtyVerticesCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			UnityEngine.Events.UnityAction arg0 = (UnityEngine.Events.UnityAction)ToLua.CheckDelegate<UnityEngine.Events.UnityAction>(L, 2);
			obj.RegisterDirtyVerticesCallback(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnregisterDirtyVerticesCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			UnityEngine.Events.UnityAction arg0 = (UnityEngine.Events.UnityAction)ToLua.CheckDelegate<UnityEngine.Events.UnityAction>(L, 2);
			obj.UnregisterDirtyVerticesCallback(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterDirtyMaterialCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			UnityEngine.Events.UnityAction arg0 = (UnityEngine.Events.UnityAction)ToLua.CheckDelegate<UnityEngine.Events.UnityAction>(L, 2);
			obj.RegisterDirtyMaterialCallback(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnregisterDirtyMaterialCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject<UnityEngine.UI.Graphic>(L, 1);
			UnityEngine.Events.UnityAction arg0 = (UnityEngine.Events.UnityAction)ToLua.CheckDelegate<UnityEngine.Events.UnityAction>(L, 2);
			obj.UnregisterDirtyMaterialCallback(arg0);
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
	static int get_defaultGraphicMaterial(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.UI.Graphic.defaultGraphicMaterial);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_color(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Color ret = obj.color;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index color on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_raycastTarget(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			bool ret = obj.raycastTarget;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index raycastTarget on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_depth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			int ret = obj.depth;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index depth on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rectTransform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.RectTransform ret = obj.rectTransform;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rectTransform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canvas(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Canvas ret = obj.canvas;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index canvas on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canvasRenderer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.CanvasRenderer ret = obj.canvasRenderer;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index canvasRenderer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultMaterial(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Material ret = obj.defaultMaterial;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index defaultMaterial on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_material(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Material ret = obj.material;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index material on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_materialForRendering(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Material ret = obj.materialForRendering;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index materialForRendering on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mainTexture(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Texture ret = obj.mainTexture;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mainTexture on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_color(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.color = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index color on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_raycastTarget(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.raycastTarget = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index raycastTarget on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_material(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Material arg0 = (UnityEngine.Material)ToLua.CheckObject<UnityEngine.Material>(L, 2);
			obj.material = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index material on a nil value");
		}
	}
}

