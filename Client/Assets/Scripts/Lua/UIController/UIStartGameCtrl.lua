local UIBaseCtrl =  require "UIController/UIBaseCtrl"
local UIStartGameCtrl = class("UIStartGameCtrl", UIBaseCtrl)

local panelMgr = nil

function UIStartGameCtrl:Awake()
  panelMgr = MgrCenter:GetManager(ManagerNames.Panel)
  LogError("这里打印")
  panelMgr:CreatePanel(self, UILayer.Fixed, UiNames.StartGame, self.OnCreateOK)
end

function UIStartGameCtrl:OnCreateOK()
  self:SetUiLayout()
end