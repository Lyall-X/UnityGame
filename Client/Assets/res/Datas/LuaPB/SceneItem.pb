
?
SceneItem.protoCmdProtoItemCommon.proto"?
PackageItem"
type (2.Cmd.EPackTypeRtype
	fighterid (R	fighterid
maxslot (Rmaxslot!
data (2.Cmd.ItemDataRdata"<
SendPackageListCmd&
packs (2.Cmd.PackageItemRpacks"?
PackageUpdate"
type (2.Cmd.EPackTypeRtype
	fighterid (R	fighterid/
updateItems (2.Cmd.ItemDataRupdateItems
delItems (	RdelItems"U
ItemUse
itemguid (	Ritemguid
targets (Rtargets
count (Rcount"?
EquipPackageOperCmd
	fighterid (R	fighterid#
oper (2.Cmd.EEquipOperRoper 
pos (2.Cmd.EEquipPosRpos

equip_guid (	R	equipGuid
src_fighter (R
srcFighter"?
RetEquipPackageOperCmd
	fighterid (R	fighterid#
oper (2.Cmd.EEquipOperRoper 
pos (2.Cmd.EEquipPosRpos
	equipguid (	R	equipguid

srcfighter (R
srcfighter
result (Rresult"1
SItem
guid (	Rguid
count (Rcount"3
BrowsePackage"
type (2.Cmd.EPackTypeRtype"?
ItemShowCmd#
items (2.Cmd.ItemInfoRitems0
reduce_items (2.Cmd.ItemInfoRreduceItems0
reward_items (2.Cmd.ItemInfoRrewardItems"?
TradeItemBaseInfo
itemid (Ritemid
price (Rprice
count (Rcount
guid (	Rguid
order_id (RorderId
	refine_lv (RrefineLv
overlap (Roverlap

is_expired	 (R	isExpired*
	item_data
 (2.Cmd.ItemDataRitemData!
publicity_id (RpublicityId
end_time (RendTime
key (	Rkey
charid (Rcharid
name (	Rname#
type (2.Cmd.ETradeTypeRtype
up_rate (RupRate
	down_rate (RdownRate"1
	MoneyData
id (Rid
count (Rcount":
MoneyCmd.

moneydatas (2.Cmd.MoneyDataR
moneydatas">
MoneyUpdateCmd,
	moneydata (2.Cmd.MoneyDataR	moneydata"?
EquipStrengthCmd

equip_guid (	R	equipGuid
	fighterid (R	fighterid
newlv (Rnewlv+
ret (2.Cmd.EEquipStrengthResultRret"?
EquipUpgradeStarCmd

equip_guid (	R	equipGuid
	fighterid (R	fighterid%
material_equip (	RmaterialEquip
newlv (Rnewlv+
ret (2.Cmd.EEquipStrengthResultRret"6
RewardCommonCmd#
items (2.Cmd.ItemDataRitems*[

EEquipOper
EEQUIPOPER_MIN 
EEQUIPOPER_ON
EEQUIPOPER_OFF
EEQUIPOPER_MAX*8

ETradeType
ETRADETYPE_TRADE 
ETRADETYPE_BOOTH*?
EEquipStrengthResult
ESTRENGTHRESULT_MIN 
ESTRENGTHRESULT_SUCCESS
ESTRENGTHRESULT_NOMATERIAL
ESTRENGTHRESULT_MAXLVBZ.;Cmdbproto3