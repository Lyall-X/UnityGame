local UIBaseCtrl = require "UIController/UIBaseCtrl"
local UIMainCtrl = class("UIMainCtrl", UIBaseCtrl)

local btnSelectImage = nil
local bottomUI = nil
local panelMgr = nil

function UIMainCtrl:InitBottomUI()
	local ctrlMgr = MgrCenter:GetManager(ManagerNames.Ctrl)
	bottomUI = {
		{ button = self.btn_fight , ctrl = ctrlMgr:GetCtrl(UiNames.Battle), aa = nil },
		{ button = self.btn_city , ctrl = ctrlMgr:GetCtrl(UiNames.Dungeon) },
		{ button = self.btn_role , ctrl = ctrlMgr:GetCtrl(UiNames.MainRole) },
		{ button = self.btn_forging , ctrl = ctrlMgr:GetCtrl(UiNames.Bag) },
		{ button = self.btn_xiannv , ctrl = ctrlMgr:GetCtrl(UiNames.Hero) },
		{ button = self.btn_pet , ctrl = ctrlMgr:GetCtrl(UiNames.Hero) },
	}
end

function UIMainCtrl:Awake()
	panelMgr = MgrCenter:GetManager(ManagerNames.Panel)
	panelMgr:CreatePanel(self, UILayer.Fixed, UiNames.Main, self.OnCreateOK)
	-- logWarn("UIMainCtrl.Awake--->>")
end

--启动事件--
function UIMainCtrl:OnCreateOK()
  self:InitBottomUI()
  for _, v in ipairs(bottomUI) do
		self.behaviour:AddClick(v.button, self, self.OnClick)
  end
	Main.ShowUI(UiNames.Battle)
	-- logWarn("OnCreateOK--->>"..self.gameObject.name)
end

--单击事件--
function UIMainCtrl:OnClick(go)
	self:SelectImage(go)
	self:ShowSelectUI(go)
end

function UIMainCtrl:SelectImage(go)
	local image = go:GetComponent('Image')
	if image ~= nil then
		if btnSelectImage ~= nil then
			btnSelectImage.material = nil
		end
		image.material = GrayMat
		btnSelectImage = image
	end
end

function UIMainCtrl:ShowSelectUI(go)
  
  for _, item in ipairs(bottomUI) do
    if item.button.name == go.name then
      log(item.button.name)
			item.ctrl:Show()
		else
			item.ctrl:Show(false)
		end
  end
end

--关闭事件--
function UIMainCtrl:Close()
	panelMgr:ClosePanel(UiNames.Main)
end

return UIMainCtrl