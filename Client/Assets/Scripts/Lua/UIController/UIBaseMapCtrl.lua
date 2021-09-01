local UIBaseCtrl = require "UIController/UIBaseCtrl"
local UIBaseMapCtrl = class("UIBaseMapCtrl", UIBaseCtrl)

function UIBaseMapCtrl:Awake()
	local panelMgr = MgrCenter:GetManager(ManagerNames.Panel)
	panelMgr:CreatePanel(self, UILayer.Common, self.OnCreateOK)
	-- logWarn("UIBaseMapCtrl.Awake--->>")
end

--启动事件--
function UIBaseMapCtrl:OnCreateOK()
	self:SetUiLayout()		--设置UI布局--
	-- logWarn("OnCreateOK--->>"..self.gameObject.name)
end

--单击事件--
function UIBaseMapCtrl:OnClick(go)
	self:Close()
end

--关闭事件--
function UIBaseMapCtrl:Close()
	local panelMgr = MgrCenter:GetManager(ManagerNames.Panel)
	panelMgr:ClosePanel(self)
end

return UIBaseMapCtrl