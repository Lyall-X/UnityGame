local CtrlManager = class("CtrlManager")

function CtrlManager:Initialize()
	self.controllers = {}
	--lua controller--
	self:AddCtrl(CtrlNames.GMCmd, require "Controller.GMCmdCtrl")
	self:AddCtrl(CtrlNames.Preload, require "Controller.PreloadCtrl")
	self:AddCtrl(CtrlNames.RedDot, require "Controller.RedDotController")
	
	--ui controller--
  for key,v in pairs(UiNames) do
    if type(v) == "table" then
      for panel,_ in pairs(v) do
        local ctrl = require("UIController."..key..".UI"..panel.."Ctrl")
        ctrl.abName    = "Prefabs/UI/"..key.."/"..panel
        ctrl.panelName = panel.."Panel"
        self:AddCtrl(panel, ctrl)
      end
    else
      local ctrl = require("UIController.UI"..key.."Ctrl")
      ctrl.abName    = "Prefabs/UI/"..key
      ctrl.panelName = key.."Panel"
      self:AddCtrl(key, ctrl)
    end
  end
end

function CtrlManager:AddCtrl(name, ctrl)
	if name == nil or ctrl == nil then
		logError('CtrlManager:AddCtrl Error!! was nil.')
		return
	end
	self.controllers[name] = ctrl
end

function CtrlManager:GetCtrl(name)
	return self.controllers[name]
end

function CtrlManager:RemoveCtrl(name)
	table.removeKey(self.controllers, name)
end

return CtrlManager