local ManagerCenter = class("ManagerCenter")

function ManagerCenter:Initialize()
	self.managers = {}
	--C# Manager--
	self:AddManager(ManagerNames.Shader, self:GetCSharpManager("ShaderManager"))
	self:AddManager(ManagerNames.Resource, self:GetCSharpManager("ResourceManager"))
	self:AddManager(ManagerNames.NPC, self:GetCSharpManager("NPCManager"))
	self:AddManager(ManagerNames.Socket, self:GetCSharpManager("NetworkManager"))

	--C# Ext Manager--
	self:AddManager(ManagerNames.Timer, self:GetExtManager("TimerManager"))
	self:AddManager(ManagerNames.Config, self:GetExtManager("ConfigManager"))

	--Lua Manager--
	self:AddManager(ManagerNames.Ctrl, require "Manager.CtrlManager", true) -- 控制器管理器, 所有panel的ctrl管理
	self:AddManager(ManagerNames.Adapter, require "Manager.AdapterManager", true) -- 管理所有Adapter, 有所关卡Level都含有一个，数据相关
	self:AddManager(ManagerNames.Map, require "Manager.MapManager", true) -- 地图控制器,管理地图预制体和背景的加载
	self:AddManager(ManagerNames.Level, require "Manager.LevelManager", true) -- 关卡管理器,异步切换场景,加载和释放时函数调用
	self:AddManager(ManagerNames.Network, require "Manager.NetworkManager", true)
	self:AddManager(ManagerNames.Table, require "Data.TableManager", true)
	self:AddManager(ManagerNames.UI, require "Manager.UIManager", true) -- HUD控制器 和 Layer层级控制器
	self:AddManager(ManagerNames.Panel, require "Manager.PanelManager", true) -- 创建/销毁/显隐 panel到指定的layer
	self:AddManager(ManagerNames.Component, require "Manager.ComponentManager", true) -- 组件控制器,默认添加BatchTask组件,new函数会调用initialize方法
	self:AddManager(ManagerNames.Module, require "Manager.ModuleManager", true) -- Main界面, 子页签下MVC中的Moudle
	self:AddManager(ManagerNames.Handler, require "Manager.HandlerManager", true)
	self:AddManager(ManagerNames.RedDot, require "Manager.RedDotManager", true)
	self:AddManager(ManagerNames.Event, require "Manager.EventManager") -- 事件管理器,事件注册与广播

	logWarn('ManagerCenter:InitializeOK...')
end

function ManagerCenter:AddManager(name, manager, needInit)
	if name == nil or manager == nil then
		logError('ManagerCenter:AddManager Error!! '..name..' was nil.')
		return
	end
	self.managers[name] = manager

	needInit = needInit or nil
	if needInit == true then
		if name == ManagerNames.Table then
			manager.Initialize()
		else
			manager:Initialize()
		end
	end
end

function ManagerCenter:GetManager(name)
	return self.managers[name]
end

function ManagerCenter:RemoveManager(name)
	return table.removeKey(self.managers, name)
end

function ManagerCenter:GetCSharpManager(name)
	return ManagementCenter.GetManager(name)
end

function ManagerCenter:GetExtManager(name)
	return ManagementCenter.GetExtManager(name)
end

return ManagerCenter