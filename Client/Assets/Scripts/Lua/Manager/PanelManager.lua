local PanelManager = class("PanelManager")

function PanelManager:Initialize()
	self.mPanels = {}
	self.mPrefabs = {}
	self.mCtrls = {}
	-- logWarn('PanelManager:InitializeOK...')
end

function PanelManager:OnUiShow(uiCtrlName)
	local ctrl = self.mCtrls[uiCtrlName]
	if ctrl ~= nil and ctrl.OnShowUI ~= nil then
		ctrl:OnShowUI()
	end
end

function PanelManager:CreatePanel(ctrl, layer, createOK)
	local uiMgr = MgrCenter:GetManager(ManagerNames.UI)
	local parent = uiMgr:GetLayer(layer).transform;
	self.mCtrls[ctrl.panelName] = ctrl
	if parent:Find(ctrl.panelName) ~= nil then
		self:OnUiShow(ctrl.panelName)
		return
	end
	local resMgr = MgrCenter:GetManager(ManagerNames.Resource)
	resMgr:LoadAssetAsync(ctrl.abName, { ctrl.panelName }, typeof(GameObject), function(objs) 
		if objs ~= nil and objs[0] ~= nil then
			self:CreatePanelInternal(ctrl, ctrl.panelName, objs[0], parent, createOK)
		end
	end)
	-- logWarn("CreatePanel::>>"..abName)
end

function PanelManager:CreatePanelInternal(ctrl, panelName, prefab, parent, createOK)
	local gameObj = newObject(prefab)
	gameObj.name = panelName;
	gameObj.layer = LayerMask.NameToLayer("UI");
	gameObj.transform:SetParent(parent);
	gameObj.transform.localScale = Vector3.one;
	gameObj.transform.localPosition = Vector3.zero;

	local behaviour = gameObj:AddComponent(typeof(Client.Behaviour.LuaBehaviour))
	ctrl:InitUI(behaviour)
	if createOK ~= nil then
		createOK(ctrl)
	end
	self.mPanels[panelName] = gameObj
end

function PanelManager:DestroyPanel(panelName)
	local removeItem = table.removeKey(self.mPanels, panelName)
	if removeItem ~= nil then
		destroy(removeItem)
	end
end

function PanelManager:ClosePanel(ctrl)
	local ctrl = table.removeKey(self.mCtrls, ctrl.panelName)
	if ctrl then
		ctrl:Dispose()
	end
	self:DestroyPanel(ctrl.panelName)
	-- logWarn('ClosePanel:>>'..panelName)
end
 
return PanelManager