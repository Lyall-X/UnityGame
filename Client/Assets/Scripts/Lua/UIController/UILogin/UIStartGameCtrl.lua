local UIBaseCtrl = require "UIController/UIBaseCtrl"
local UIStartGameCtrl = class("UIStartGameCtrl", UIBaseCtrl)

local panelMgr = nil

function UIStartGameCtrl:Awake()
	self.panelMgr = MgrCenter:GetManager(ManagerNames.Panel)
	panelMgr:CreatePanel(self, UILayer.Common, self.OnCreateOK)
	logWarn("UIStartGameCtrl.Awake--->>")
end

--启动事件--
function UIStartGameCtrl:OnCreateOK()
	self:SetUiLayout()
	logWarn("OnCreateOK--->>"..self.gameObject.name)
end

--单击事件--
function UIStartGameCtrl:OnClick(go)
	self:Close()
end

--关闭事件--
function UIStartGameCtrl:Close()
	self.panelMgr:ClosePanel(self)
end

return UIStartGameCtrl