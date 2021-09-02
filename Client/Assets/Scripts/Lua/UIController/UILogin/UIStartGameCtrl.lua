local UIBaseCtrl = require "UIController/UIBaseCtrl"
local UIStartGameCtrl = class("UIStartGameCtrl", UIBaseCtrl)

function UIStartGameCtrl:Initialize()
  self.panelMgr = nil
  self.userModule = nil
end

function UIStartGameCtrl:Awake()
	self.panelMgr = MgrCenter:GetManager(ManagerNames.Panel)
	self.userModule = MgrCenter:GetManager(ManagerNames.Module):GetModule(ModuleNames.User)

	self.panelMgr:CreatePanel(self, UILayer.Common, self.OnCreateOK)
end

--启动事件--
function UIStartGameCtrl:OnCreateOK()
	self:SetUiLayout()
  self:OnShowUI()
  
  self.behaviour:AddClick(self.btn_login, self, self.OnLogin)
  self.behaviour:AddClick(self.btn_notice, self, self.OnNotice)
end

function UIStartGameCtrl:OnShowUI()
	self.txt_version.text = LuaHelper.GetVersionInfo()
end

--单击事件--
function UIStartGameCtrl:OnNotice(go)
  Main.ShowUI(UiNames.UILogin.Notice)
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

--关闭事件--
function UIStartGameCtrl:Close()
	self.panelMgr:ClosePanel(self)
end

return UIStartGameCtrl