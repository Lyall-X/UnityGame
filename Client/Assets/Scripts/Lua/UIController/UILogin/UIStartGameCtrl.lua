local UIBaseCtrl = require "UIController/UIBaseCtrl"
local UIStartGameCtrl = class("UIStartGameCtrl", UIBaseCtrl)

local panelMgr = nil
local Notice

function UIStartGameCtrl:Awake()
	panelMgr = MgrCenter:GetManager(ManagerNames.Panel)
	panelMgr:CreatePanel(self, UILayer.Common, self.OnCreateOK)
	logWarn("UIStartGameCtrl.Awake--->>")
end

--启动事件--
function UIStartGameCtrl:OnCreateOK()
	self:SetUiLayout()
  self.behaviour:AddClick(self.btn_login, self, self.OnLogin)
  self.behaviour:AddClick(self.btn_notice, self, self.OnNotice)
  self.behaviour:AddClick(self.btn_back, self, self.onBack)
end

--单击事件--
function UIStartGameCtrl:OnLogin(go)
	local Notice = self.gameObject.transform:Find("NoticePanel")
  if not isnil(Notice) then Notice.gameObject:SetActive(true) end
end

function UIStartGameCtrl:onBack(go)
	local Notice = self.gameObject.transform:Find("NoticePanel")
  if not isnil(Notice) then Notice.gameObject:SetActive(false) end
end


--关闭事件--
function UIStartGameCtrl:Close()
	panelMgr:ClosePanel(self)
end

return UIStartGameCtrl