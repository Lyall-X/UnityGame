local UIBaseCtrl = require "UIController/UIBaseCtrl"
local UILoginCtrl = class("UILoginCtrl", UIBaseCtrl)

function UILoginCtrl:Awake()
	local moduleMgr = MgrCenter:GetManager(ManagerNames.Module)
	self.userModule = moduleMgr:GetModule(ModuleNames.User)
	self.mainRoleModule = moduleMgr:GetModule(ModuleNames.MainRole)
	self.panelMgr = MgrCenter:GetManager(ManagerNames.Panel)
	local adapterMgr = MgrCenter:GetManager(ManagerNames.Adapter)
	self.adapter = adapterMgr:GetAdapter(LevelType.Login)
  self.roleIndex = NpcRole.Human
  self.sexIndex = NpcSex.Man

	self.panelMgr:CreatePanel(self, UILayer.Common, self.OnCreateOK)
end

--启动事件--
function UILoginCtrl:OnCreateOK()
	self:SetUiLayout()
  self:OnShowUI()

  for _,toggle in ipairs(self.roleBtns) do
    self.behaviour:AddToggleClick(toggle, self, self.OnRoleClienk)
  end
  for _,toggle in ipairs(self.sexBtns) do
    self.behaviour:AddToggleClick(toggle, self, self.OnSexClienk)
  end
  
	self.behaviour:AddClick(self.btn_select_left, self, self.OnSelectLeft)
	self.behaviour:AddClick(self.btn_select_right, self, self.OnSelectRight)
  
	self.behaviour:AddClick(self.btn_startgame, self, self.OnCreateClick)
	self.behaviour:AddClick(self.btn_random, self, self.OnRandomClick)
end

--创建角色--

function UILoginCtrl:OnSelectLeft(check)
  self.roleIndex = self.roleIndex == 1 and #self.roleBtns or self.roleIndex - 1
  self.roleBtns[self.roleIndex].isOn = true
end

function UILoginCtrl:OnSelectRight(check)
  self.roleIndex = self.roleIndex == #self.roleBtns and 1 or self.roleIndex + 1
  self.roleBtns[self.roleIndex].isOn = true
end

function UILoginCtrl:OnRoleClienk(click)
  for index,toggle in ipairs(self.roleBtns) do
    if toggle.isOn then
      self.roleIndex = index
    end
  end 
  self:OnRefreshLogin()
end

function UILoginCtrl:OnSexClienk(click)
  for index,toggle in ipairs(self.sexBtns) do
    if toggle.isOn then
      self.sexIndex = index
    end
  end 
  self:OnRefreshLogin()
end

function UILoginCtrl:OnShowUI()
  self.roleBtns = {
    self.toggle_role_renzu,
    self.toggle_role_xainzu,
    self.toggle_role_mozu,
  }
  self.sexBtns = {
    self.toggle_sex_nan,
    self.toggle_sex_nv,
  }
  self:OnRefreshLogin()
end

function UILoginCtrl:OnRefreshLogin()
  self.mainRoleModule:AssignMainRoleData(self.roleIndex, self.sexIndex)
  local spriteName = self.roleIndex..'_'..self.sexIndex
	self:LoadRoleAsset(spriteName, function (sprite)
		self:ShowImage(self.img_ShowActor, sprite)
	end)
end

function UILoginCtrl:LoadRoleAsset(spriteName, func)
	if self.oleSprites == nil then
		self.roleSprites = {}
	end
	local sprite = self.roleSprites[spriteName]
	if sprite ~= nil then
		func(sprite)
		return
	end
	local path = "Textures/Login/MainRole/"..spriteName
	local resMgr = MgrCenter:GetManager(ManagerNames.Resource)
	resMgr:LoadAssetAsync(path, { spriteName }, typeof(Sprite), function (objs)
		if objs ~= nil and objs[0] ~= nil then
			local spriteObj = objs[0]
			self.roleSprites[spriteObj.name] = spriteObj
			func(spriteObj)
		end
	end)
end

--进入游戏--
function UILoginCtrl:OnCreateClick(go)
	if AppConst.NetworkMode then
		self.userModule:ReqLogin('user', 'password', function(userinfo) 
			self.adapter:StartLogin()
			logError("login ok!!! userid>>"..userinfo.userid)
		end)
	else
		self.adapter:StartLogin()
	end
end


--随机姓名--
function UILoginCtrl:OnRandomClick(go)
  self.txt_name.text = range(0,1000)
end

--关闭事件--
function UILoginCtrl:Close()
	self.panelMgr:ClosePanel(self)
end

return UILoginCtrl