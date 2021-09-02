local UIBaseCtrl = require "UIController/UIBaseCtrl"
local UINoticeCtrl = class("UINoticeCtrl", UIBaseCtrl)

function UINoticeCtrl:Initialize()
  self.panelMgr = nil
end

function UINoticeCtrl:Awake()
	self.panelMgr = MgrCenter:GetManager(ManagerNames.Panel)
	self.panelMgr:CreatePanel(self, UILayer.Common, self.OnCreateOK)
	logWarn("UINoticeCtrl.Awake--->>")
end

--启动事件--
function UINoticeCtrl:OnCreateOK()
	self:SetUiLayout()
  self:OnShow()
  self.behaviour:AddClick(self.btn_back, self, self.Close)
	logWarn("OnCreateOK--->>"..self.gameObject.name)
end


--UI事件--
function UINoticeCtrl:OnShow()
  -- 显示富文本
  local tableMgr = MgrCenter:GetManager(ManagerNames.Table)
  local notices = tableMgr.noticeTable:GetItems()
  self.txt_notice.text = ""
  for i = #notices,1,-1  do
    self.txt_notice.text = self.txt_notice.text.."<color=green>"..notices[i].title.."</color>\n"..notices[i].content.."\n  <b><i>"..notices[i].time.."</i></b>\n"
  end
end

--关闭事件--
function UINoticeCtrl:Close()
	self.panelMgr:ClosePanel(self)
end

return UINoticeCtrl