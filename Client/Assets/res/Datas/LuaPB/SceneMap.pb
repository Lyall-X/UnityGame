
�Q
SceneMap.protoCmdProtoCommon.protoSceneUser.protoUEnumTable.proto"�
NineData
level (
pd (2.Cmd.PersonalityDataRpd 
normalskill (
state (
equipweapon (

fightstate (
fightstate

killername (	R
killername
equipids	 (
campid
 (Rcampid&
iscreatedstove (
reconcileactionid
featureflag (Rfeatureflag,
	entrydata (2.Cmd.EntryDataR	entrydata"�
MapItem
guid (Rguid
id (
type (2.Cmd.EStageObjectTypeRtype
sourceid (Rsourceid
pos (2
owners (Rowners
	disappear (R	disappear
dir (Rdir
subguid	 (Rsubguid

parentguid (R
parentguid
	isprivate
fromid (Rfromid
roomids (
state (	Rstate.
interactivefeature (

boxdata (2.Cmd.MapBoxDataRboxdata 
iscollected (Riscollected
energy (
alias (	Ralias"
questOwnerID (RquestOwnerID 
ismapstatic (Rismapstatic"
pickgroupids (Rpickgroupids 
isreinforce (Risreinforce
isbirth (Risbirth$


	spawnerid (	R	spawnerid
questid (
interactivemode  (2 .Cmd.ESceneObjectInteractionModeRinteractivemode%
scale" (2.Cmd.SceneScaleRscale"0

AddMapItem"
items (2.Cmd.MapItemRitems"b

PickupItem

playerguid (R
playerguid
itemguid (Ritemguid
success (Rsuccess"�

MapNpcData
charid (Rcharid
alias (	Ralias!
data (2
attrs (2
buffs (2.Cmd.BufferDataRbuffs
isbirth (Risbirth.
movedata (2.Cmd.MoveStateDataRmovedata 
featureflag	 (Rfeatureflag
feature
 (

interactiveradius (
perceptionradius
	spawnerid (	R	spawnerid
questid (
bubbleperceptionradius (

MapBoxData
unlock (RunlockD
unlockneeditems (2.Cmd.MapBoxData.UnlockItemRunlockneeditems.

UnlockItem
id (
num (
MapEntry
guid (Rguid
name (	Rname
cfgid (
type (2.Cmd.EStageObjectTypeRtype
pos (2
dir (Rdir)
npcdata (2.Cmd.MapNpcDataRnpcdata)
boxdata (2.Cmd.MapBoxDataRboxdata"
questOwnerID	 (RquestOwnerID
	isprivate
 (R	isprivate
fromid (Rfromid

curfighter (R
curfighter*
interactivestate

AddMapEntry#
entry (2

MapMissile
id (Rid
skillID (
pos (2
velspeed (2
gravity (2
masterid (Rmasterid"<

missiles (2.Cmd.MapMissileRmissiles".
	MapCmdEnd!
player_count (
DeleteEntryUserCmd
list (Rlist
fadeout (
deltype (	Rdeltype"5
TestParabolaPosCmd
pos (2

entryid (Rentryid
targetid (Rtargetid

auto_fight (R	autoFight"+
UnlockTargetCmd
entryid (Rentryid"�
SyncDirectionCmd
guid (Rguid
dir (Rdir$


playaction (R
playaction
curdir (Rcurdir";
SyncNpcWatchCmd
npcid (Rnpcid
guid (Rguid"u
SyncNpcVisibleStatusCmd0
npcs (2.Cmd.MapNpcVisibleStatusDataRnpcs(
type (2.Cmd.SyncNpcDataTypeRtype"�
MapObjectStatus
cfgid (
status (	Rstatus
alias (	Ralias
guids (Rguids
	spawnerid (	R	spawnerid"m
SyncNpcPrivateDataCmd*
npcs (2.Cmd.MapNpcPrivateDataRnpcs(
type (2.Cmd.SyncNpcDataTypeRtype"S
BlockSceneMapCmd%
type (2.Cmd.MapBlockTypeRtype
blockid (
NpcFeaturesUpdateCmd
guid (Rguid 
featureflag (Rfeatureflag
feature (
NpcNineSyncCmd
guid (Rguid#
attrs (2
data (2
ItemNineSyncCmd
guid (Rguid
pos (2

state (	Rstate 
iscollected (Riscollected
energy (
LeaveCopyCmd"�
MoveStateCmd
guid (Rguid)
state (2.Cmd.EMoveStateTypeRstate2
substate (2.Cmd.EMoveSubStateTypeRsubstate%
curpos (2
	targetpos (2
rotate (Rrotate
	movespeed (R	movespeed
clientDt (
jumpdata	 (2
vehicledata
 (2.Cmd.VehicleDataRvehicledata

stopaction (R
stopaction"
SingleRepairObjData
	spawnerid (	R	spawnerid$


UpdateRepairObjState
mapid (
repairdatas (2.Cmd.SingleRepairObjDataRrepairdatas&
reteliterepair (
SendEffectClosedType"f
BoxChoiceFunction
guid (
choiceid (
type (2
ServerPosTestCmd
guid (Rguid
pos (2
ServerSectorPosTestCmd
pos (2
rotate (
angle (
radius (
drawtime (

coloralpha (R
coloralpha"�
ServerSweepTestCmd
guid (Rguid!
from (2
to (2
hit (2
drawtime (

coloralpha (R
coloralpha"�
ServerBoxPosTestCmd
pos (2
rotator (2
extent (2
drawtime (

coloralpha (R
coloralpha"�
ServerCapsulePosTestCmd
pos (2
rotator (2

halfheight (
halfheight
radius (
drawtime (

coloralpha (R
coloralpha"�
ServerArrowPosTestCmd!
from (2
to (2
size (
drawtime (

coloralpha (R
coloralpha"�
ServerSpherePosTestCmd
pos (2
radius (
drawtime (

coloralpha (R
coloralpha"c
EnterRaidSceneByStage
	character (
stage (
copyid (
SendBoxInfoList
guid (
type (2
id (
SendBossEnterMap
guid (
WXKJLeaveMapCmd"R
	MapObject#
entry (2
item (2.Cmd.MapItemRitem"F
AddMapObject6
mapobjectarray (2.Cmd.MapObjectRmapobjectarray"�
InteractionMode
cfgid (
	spawnerid (	R	spawnerid4
mode (2 .Cmd.ESceneObjectInteractionModeRmode
guids (Rguids"o
SyncNpcInteractionModeCmd(
data (2.Cmd.InteractionModeRdata(
type (2.Cmd.SyncNpcDataTypeRtype"�
SyncStageObjectBehaviorCmd 
stageObject (RstageObject
operator (Roperator&
controllerName (	RcontrollerName,
controllerVersion (
controllerNodeID (
VarList
name (	Rname(
value (2.Cmd.TemplateValueRvalue"�
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
preset (	Rpreset"�
TriggerPerceptionCmd>
perceptionType (2.Cmd.NpcPerceptionTypeRperceptionType7
trigger (2.Cmd.NpcPerceptionTriggerTypeRtrigger
npcid (Rnpcid
guid (Rguid"�
SkillActorEffectUserCmd
charid (Rcharid
skillid (
effectid (
	time_axis (
pos (2

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
SYNC_NPC_DATA_TYPE_REMOVE*�
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
'G_EVENT_BIND_TYPE_DAILYACTIVITY_REFRESH
#G_EVENT_BIND_TYPE_QUEST_STORY_VALUE&
"G_EVENT_BIND_TYPE_COPYSCENE_FINISH"
G_EVENT_BIND_TYPE_STAGE_FINISH
G_EVENT_BIND_TYPE_END*�
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
$SCENE_ENTRY_BIND_TYPE_WALKPOSE_RESET
%SCENE_ENTRY_BIND_TYPE_WALKPOSE_CHANGE
SCENE_EVENT_BIND_TYPE_END*�
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
*�
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