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
        self:AddCtrl(key.."/"..panel, require("UIController."..key..".UI"..panel.."Ctrl"))
      end
    else
      self:AddCtrl(key, require("UIController.UI"..key.."Ctrl"))
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