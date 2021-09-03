
ôQ
SceneMap.protoCmdProtoCommon.protoSceneUser.protoUEnumTable.proto"º
NineData
level (Rlevel$
pd (2.Cmd.PersonalityDataRpd 
normalskill (Rnormalskill
state (Rstate 
equipweapon (Requipweapon

fightstate (R
fightstate

killername (	R
killername
equipids	 (Requipids
campid
 (Rcampid&
iscreatedstove (Riscreatedstove,
reconcileactionid (Rreconcileactionid 
featureflag (Rfeatureflag,
	entrydata (2.Cmd.EntryDataR	entrydata"ÿ
MapItem
guid (Rguid
id (Rid)
type (2.Cmd.EStageObjectTypeRtype
sourceid (Rsourceid
pos (2.Cmd.ScenePosRpos
owners (Rowners
	disappear (R	disappear
dir (Rdir
subguid	 (Rsubguid

parentguid (R
parentguid
	isprivate (R	isprivate
fromid (Rfromid
roomids (Rroomids
state (	Rstate.
interactivefeature (Rinteractivefeature8
itementrydata (2.Cmd.ItemEntryDataRitementrydata)
boxdata (2.Cmd.MapBoxDataRboxdata 
iscollected (Riscollected
energy (Renergy
alias (	Ralias"
questOwnerID (RquestOwnerID 
ismapstatic (Rismapstatic"
pickgroupids (Rpickgroupids 
isreinforce (Risreinforce
isbirth (Risbirth$
borndelaytime (Rborndelaytime$
overlapradius (Roverlapradius
	spawnerid (	R	spawnerid
questid (RquestidJ
interactivemode  (2 .Cmd.ESceneObjectInteractionModeRinteractivemode%
scale" (2.Cmd.SceneScaleRscale"0

AddMapItem"
items (2.Cmd.MapItemRitems"b

PickupItem

playerguid (R
playerguid
itemguid (Ritemguid
success (Rsuccess"Ÿ

MapNpcData
charid (Rcharid
alias (	Ralias!
data (2.Cmd.NineDataRdata#
attrs (2.Cmd.UserAttrRattrs%
buffs (2.Cmd.BufferDataRbuffs
isbirth (Risbirth.
movedata (2.Cmd.MoveStateDataRmovedata 
featureflag	 (Rfeatureflag
feature
 (Rfeature$
borndelaytime (Rborndelaytime,
interactiveradius (Rinteractiveradius*
perceptionradius (Rperceptionradius
	spawnerid (	R	spawnerid
questid (Rquestid6
bubbleperceptionradius (Rbubbleperceptionradius"š

MapBoxData
unlock (RunlockD
unlockneeditems (2.Cmd.MapBoxData.UnlockItemRunlockneeditems.

UnlockItem
id (Rid
num (Rnum"È
MapEntry
guid (Rguid
name (	Rname
cfgid (Rcfgid)
type (2.Cmd.EStageObjectTypeRtype
pos (2.Cmd.ScenePosRpos
dir (Rdir)
npcdata (2.Cmd.MapNpcDataRnpcdata)
boxdata (2.Cmd.MapBoxDataRboxdata"
questOwnerID	 (RquestOwnerID
	isprivate
 (R	isprivate
fromid (Rfromid

curfighter (R
curfighter*
interactivestate (	Rinteractivestate$
defaultaction (	Rdefaultaction"2
AddMapEntry#
entry (2.Cmd.MapEntryRentry"Ç

MapMissile
id (Rid
skillID (RskillID
pos (2.Cmd.ScenePosRpos)
velspeed (2.Cmd.ScenePosRvelspeed'
gravity (2.Cmd.ScenePosRgravity
masterid (Rmasterid"<
AddMapMissile+
missiles (2.Cmd.MapMissileRmissiles".
	MapCmdEnd!
player_count (RplayerCount"\
DeleteEntryUserCmd
list (Rlist
fadeout (Rfadeout
deltype (	Rdeltype"5
TestParabolaPosCmd
pos (2.Cmd.ScenePosRpos"d
LockTargetCmd
entryid (Rentryid
targetid (Rtargetid

auto_fight (R	autoFight"+
UnlockTargetCmd
entryid (Rentryid"–
SyncDirectionCmd
guid (Rguid
dir (Rdir$
instantrotate (Rinstantrotate

playaction (R
playaction
curdir (Rcurdir";
SyncNpcWatchCmd
npcid (Rnpcid
guid (Rguid"u
SyncNpcVisibleStatusCmd0
npcs (2.Cmd.MapNpcVisibleStatusDataRnpcs(
type (2.Cmd.SyncNpcDataTypeRtype"‰
MapObjectStatus
cfgid (Rcfgid
status (	Rstatus
alias (	Ralias
guids (Rguids
	spawnerid (	R	spawnerid"m
SyncNpcPrivateDataCmd*
npcs (2.Cmd.MapNpcPrivateDataRnpcs(
type (2.Cmd.SyncNpcDataTypeRtype"S
BlockSceneMapCmd%
type (2.Cmd.MapBlockTypeRtype
blockid (Rblockid"f
NpcFeaturesUpdateCmd
guid (Rguid 
featureflag (Rfeatureflag
feature (Rfeature"l
NpcNineSyncCmd
guid (Rguid#
attrs (2.Cmd.UserAttrRattrs!
data (2.Cmd.NineDataRdata"Ð
ItemNineSyncCmd
guid (Rguid
pos (2.Cmd.ScenePosRpos8
itementrydata (2.Cmd.ItemEntryDataRitementrydata
state (	Rstate 
iscollected (Riscollected
energy (Renergy"
LeaveCopyCmd"¦
MoveStateCmd
guid (Rguid)
state (2.Cmd.EMoveStateTypeRstate2
substate (2.Cmd.EMoveSubStateTypeRsubstate%
curpos (2.Cmd.ScenePosRcurpos+
	targetpos (2.Cmd.ScenePosR	targetpos
rotate (Rrotate
	movespeed (R	movespeed
clientDt (RclientDt)
jumpdata	 (2.Cmd.JumpDataRjumpdata2
vehicledata
 (2.Cmd.VehicleDataRvehicledata

stopaction (R
stopaction"
SingleRepairObjData
	spawnerid (	R	spawnerid$
boeliterepair (Rboeliterepair$
showeliteitem (Rshoweliteitem"
UpdateRepairObjState
mapid (Rmapid:
repairdatas (2.Cmd.SingleRepairObjDataRrepairdatas&
reteliterepair (Rreteliterepair"
SendEffectClosedType"f
BoxChoiceFunction
guid (Rguid
choiceid (Rchoiceid!
type (2.Cmd.EBoxTypeRtype"G
ServerPosTestCmd
guid (Rguid
pos (2.Cmd.ScenePosRpos"»
ServerSectorPosTestCmd
pos (2.Cmd.ScenePosRpos
rotate (Rrotate
angle (Rangle
radius (Rradius
drawtime (Rdrawtime

coloralpha (R
coloralpha"Ç
ServerSweepTestCmd
guid (Rguid!
from (2.Cmd.ScenePosRfrom
to (2.Cmd.ScenePosRto
hit (2.Cmd.ScenePosRhit
drawtime (Rdrawtime

coloralpha (R
coloralpha"Â
ServerBoxPosTestCmd
pos (2.Cmd.ScenePosRpos'
rotator (2.Cmd.ScenePosRrotator%
extent (2.Cmd.ScenePosRextent
drawtime (Rdrawtime

coloralpha (R
coloralpha"×
ServerCapsulePosTestCmd
pos (2.Cmd.ScenePosRpos'
rotator (2.Cmd.ScenePosRrotator

halfheight (R
halfheight
radius (Rradius
drawtime (Rdrawtime

coloralpha (R
coloralpha"©
ServerArrowPosTestCmd!
from (2.Cmd.ScenePosRfrom
to (2.Cmd.ScenePosRto
size (Rsize
drawtime (Rdrawtime

coloralpha (R
coloralpha"
ServerSpherePosTestCmd
pos (2.Cmd.ScenePosRpos
radius (Rradius
drawtime (Rdrawtime

coloralpha (R
coloralpha"c
EnterRaidSceneByStage
	character (R	character
stage (Rstage
copyid (Rcopyid"X
SendBoxInfoList
guid (Rguid!
type (2.Cmd.EBoxTypeRtype
id (Rid"&
SendBossEnterMap
guid (Rguid"
WXKJLeaveMapCmd"R
	MapObject#
entry (2.Cmd.MapEntryRentry 
item (2.Cmd.MapItemRitem"F
AddMapObject6
mapobjectarray (2.Cmd.MapObjectRmapobjectarray"‘
InteractionMode
cfgid (Rcfgid
	spawnerid (	R	spawnerid4
mode (2 .Cmd.ESceneObjectInteractionModeRmode
guids (Rguids"o
SyncNpcInteractionModeCmd(
data (2.Cmd.InteractionModeRdata(
type (2.Cmd.SyncNpcDataTypeRtype"Ü
SyncStageObjectBehaviorCmd 
stageObject (RstageObject
operator (Roperator&
controllerName (	RcontrollerName,
controllerVersion (RcontrollerVersion*
controllerNodeID (RcontrollerNodeID"G
VarList
name (	Rname(
value (2.Cmd.TemplateValueRvalue"…
SyncBlueprintPerformanceCmd
target (Rtarget,
type (2.Cmd.ENetPerformanceTypeRtype 
list (2.Cmd.VarListRlist"L
SyncTime
client_time (R
clientTime
server_time (R
serverTime"Q
SetCollisionCmd
guid (Rguid
open (Ropen
preset (	Rpreset"¹
TriggerPerceptionCmd>
perceptionType (2.Cmd.NpcPerceptionTypeRperceptionType7
trigger (2.Cmd.NpcPerceptionTriggerTypeRtrigger
npcid (Rnpcid
guid (Rguid"Ö
SkillActorEffectUserCmd
charid (Rcharid
skillid (Rskillid
effectid (Reffectid
	time_axis (RtimeAxis
pos (2.Cmd.ScenePosRpos/

addmapitem (2.Cmd.AddMapItemR
addmapitem"L
SyncUserDeadCmd
guid (Rguid%
type (2.Cmd.UserDeadTypeRtype* 
	EGiveType
EGiveType_FIRST *h
SyncNpcDataType
SYNC_NPC_DATA_TYPE_MAP 
SYNC_NPC_DATA_TYPE_ADD
SYNC_NPC_DATA_TYPE_REMOVE*€
GlobalEventBindType
G_EVENT_BIND_TYPE_BEGIN !
G_EVENT_BIND_TYPE_CREATESCENE!
G_EVENT_BIND_TYPE_DELETESCENE
G_EVENT_BIND_TYPE_LOGIN
G_EVENT_BIND_TYPE_LOGINOUT!
G_EVENT_BIND_TYPE_KILLMONSTER 
G_EVENT_BIND_TYPE_ENTERSCENE 
G_EVENT_BIND_TYPE_LEAVESCENE 
G_EVENT_BIND_TYPE_ADDFIGHTER!
G_EVENT_BIND_TYPE_FINISHQUEST	"
G_EVENT_BIND_TYPE_FINISHREPAIR

G_EVENT_BIND_TYPE_UNLOCKED
G_EVENT_BIND_TYPE_REDDOT+
'G_EVENT_BIND_TYPE_DAILYACTIVITY_REFRESH'
#G_EVENT_BIND_TYPE_QUEST_STORY_VALUE&
"G_EVENT_BIND_TYPE_COPYSCENE_FINISH"
G_EVENT_BIND_TYPE_STAGE_FINISH
G_EVENT_BIND_TYPE_END*¿
SceneEventBindType
SCENE_EVENT_BIND_TYPE_BEGIN %
!SCENE_EVENT_BIND_TYPE_MONSTERDEAD1
-SCENE_EVENT_BIND_TYPE_QUESTMONSTER_LEAVESCENE#
SCENE_EVENT_BIND_TYPE_QUESTKILL+
'SCENE_ENTRY_BIND_TYPE_PHYSIC_MOVE_TOUCH+
'SCENE_ENTRY_BIND_TYPE_PHYSIC_MOVE_BLOCk)
%SCENE_ENTRY_BIND_TYPE_PHYSIC_MOVE_CCT%
!SCENE_ENTRY_BIND_TYPE_BREAK_SKILL$
 SCENE_ENTRY_BIND_TYPE_JUMP_START$
 SCENE_ENTRY_BIND_TYPE_JUMP_FLOOR	1
-SCENE_ENTRY_BIND_TYPE_BUBBLE_PERCEPTION_ENTER
1
-SCENE_ENTRY_BIND_TYPE_BUBBLE_PERCEPTION_LEAVE7
3SCENE_ENTRY_BIND_TYPE_BUBBLE_PERCEPTION_NEXT_ACTION(
$SCENE_ENTRY_BIND_TYPE_WALKPOSE_RESET)
%SCENE_ENTRY_BIND_TYPE_WALKPOSE_CHANGE
SCENE_EVENT_BIND_TYPE_END*¨
StageSourceType
STAGE_SOURCE_NULL 
STAGE_SOURCE_QUEST
STAGE_SOURCE_COPY
STAGE_SOURCE_POLLUTION_AREA
STAGE_SOURCE_WXKJ
STAGE_SOURCE_DSCENE*x
NpcPerceptionType
NPC_PERCEPTION_BEGIN 
NPC_PERCEPTION_VISIT
NPC_PERCEPTION_HEAR
NPC_PERCEPTION_END
* 
NpcPerceptionTriggerType 
NPC_PERCEPTION_TRIGGRT_BEGIN  
NPC_PERCEPTION_TRIGGRT_ENTER 
NPC_PERCEPTION_TRIGGRT_LEAVE
NPC_PERCEPTION_TRIGGRT_END
*|
UserDeadType
USER_DEAD_TYPE_MIN 
USER_DEAD_TYPE_NORMAL_TEAM
USER_DEAD_TYPE_LDBE_TEAM
USER_DEAD_TYPE_MAXBZ.;Cmdbproto3