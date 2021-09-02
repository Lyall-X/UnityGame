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

	self.behaviour:AddToggleClick(self.toggle_role_renzu, self, self.OnHumanClienk)
	self.behaviour:AddToggleClick(self.toggle_role_xainzu, self, self.OnFairyClienk)
	self.behaviour:AddToggleClick(self.toggle_role_mozu, self, self.OnDevilClienk)
  
	self.behaviour:AddToggleClick(self.toggle_sex_nan, self, self.OnManClienk)
	self.behaviour:AddToggleClick(self.toggle_sex_nv, self, self.OnWomanClienk)
  
	self.behaviour:AddClick(self.btn_startgame, self, self.OnCreateClick)
	self.behaviour:AddClick(self.btn_random, self, self.OnRandomClick)
end

--创建角色--
function UILoginCtrl:OnHumanClienk(check)
  self.roleIndex = NpcRole.Human
  self:OnRefreshLogin()
end

function UILoginCtrl:OnFairyClienk(check)
  self.roleIndex = NpcRole.Fairy
  self:OnRefreshLogin()
end

function UILoginCtrl:OnDevilClienk(check)
  self.roleIndex = NpcRole.Devil
  self:OnRefreshLogin()
end

function UILoginCtrl:OnManClienk(check)
  self.sexIndex = NpcSex.Man
  self:OnRefreshLogin()
end

function UILoginCtrl:OnWomanClienk(check)
  self.sexIndex = NpcSex.Woman
  self:OnRefreshLogin()
end


function UILoginCtrl:OnShowUI()
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
  -- self.obj_InputField:GetComponent("InputField").text = "111"
end

--关闭事件--
function UILoginCtrl:Close()
	self.panelMgr:ClosePanel(self)
end

return UILoginCtrl