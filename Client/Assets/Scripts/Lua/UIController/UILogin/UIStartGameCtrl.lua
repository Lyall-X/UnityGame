local UIBaseCtrl = require "UIController/UIBaseCtrl"
local UIStartGameCtrl = class("UIStartGameCtrl", UIBaseCtrl)

function UIStartGameCtrl:Awake()
	self.panelMgr = MgrCenter:GetManager(ManagerNames.Panel)
  self.loginCtrl = MgrCenter:GetManager(ManagerNames.Adapter):GetAdapter(LevelType.Login)
	self.userModule = MgrCenter:GetManager(ManagerNames.Module):GetModule(ModuleNames.User)
  
	self.panelMgr:CreatePanel(self, UILayer.Common, self.OnCreateOK)
	logWarn("UIStartGameCtrl.Awake--->>")
end

--启动事件--
function UIStartGameCtrl:OnCreateOK()
	self:SetUiLayout()
  self.behaviour:AddClick(self.btn_login, self, self.OnLogin)
  self.behaviour:AddClick(self.btn_notice, self, self.OnNotice)
  self.behaviour:AddClick(self.btn_back, self, self.OnBack)
	self.txt_version.text = LuaHelper.GetVersionInfo()
  self:InitNoticeContent()
end

--单击事件--
function UIStartGameCtrl:OnNotice(go)
	local Notice = self.gameObject.transform:Find("NoticePanel")
  if not isnil(Notice) then Notice.gameObject:SetActive(true) end
end

function UIStartGameCtrl:OnBack(go)
	local Notice = self.gameObject.transform:Find("NoticePanel")
  if not isnil(Notice) then Notice.gameObject:SetActive(false) end
end

function UIStartGameCtrl:OnLogin(go)
  if AppConst.NetworkMode then
    if self.txt_name.text == "" or self.txt_passwd.text == "" then
      Main.ShowTips("请输入账号与密码")
    end
		self.userModule:ReqLogin(self.txt_name.text, self.txt_passwd.text, function(userinfo) 
			self:GotoLoginPanel()
			logError("login ok!!! userid>>"..userinfo.userid)
		end)
	else
    self:GotoLoginPanel()
	end
end

function UIStartGameCtrl:GotoLoginPanel()
	Main.ShowUI(UiNames.UILogin.Login)
	Main.CloseUI(UiNames.UILogin.StartGame)
end

function UIStartGameCtrl:InitNoticeContent()
  -- 显示富文本
  local tableMgr = MgrCenter:GetManager(ManagerNames.Table)
  local notices = tableMgr.noticeTable:GetItems()
  self.txt_notice.text = ""
  for i = #notices,1,-1  do
    self.txt_notice.text = self.txt_notice.text.."<color=green>"..notices[i].title.."</color>\n"..notices[i].content.."\n  <b><i>"..notices[i].time.."</i></b>\n"
  end
end


--关闭事件--
function UIStartGameCtrl:Close()
	self.panelMgr:ClosePanel(self)
end

return UIStartGameCtrl