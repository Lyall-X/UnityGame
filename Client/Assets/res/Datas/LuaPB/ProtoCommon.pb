
?
ProtoCommon.protoCmdProtoAttr.proto"4
ScenePos
x (Rx
y (Ry
z (Rz"6

SceneScale
x (Rx
y (Ry
z (Rz"?
SnapShotDataPB
id (Rid
baselv (Rbaselv
	partnerid (R	partnerid
portrait (Rportrait
name (	Rname
isopen (Risopen

deletetime (R
deletetime$
pd (2.Cmd.PersonalityDataRpd"Q
Param
key (	Rkey
value (	Rvalue 
items (2
.Cmd.ParamRitems"?

PinchPeople

bodyweight (R
bodyweight

bodyheight (R
bodyheight

bodybreast (R
bodybreast
	bodycolor (R	bodycolor
eyebrow (Reyebrow
	browcolor (R	browcolor
eyepupil (Reyepupil&
pupilcolorleft (Rpupilcolorleft(
pupilcolorright	 (Rpupilcolorright
	eyeshadow
 (R	eyeshadow&
eyeshadowcolor (Reyeshadowcolor
eyeshape (Reyeshape
	faceshape (R	faceshape
ear (Rear

facetattoo (R
facetattoo(
facetattoocolor (Rfacetattoocolor
hairmain (Rhairmain
hairside (Rhairside
ahoge (Rahoge
	haircolor (R	haircolor
cloth (	Rcloth
pupilla (Rpupilla
blusher (Rblusher"
blushercolor (Rblushercolor&
defaultfashion (	Rdefaultfashion"
avatarpreset (Ravatarpreset
vhaire (Rvhair(
vhairmajorcolorf (Rvhairmajorcolor*
vhairsecondcolorg (Rvhairsecondcolor
vahogeh (Rvahoge

vfaceshapei (R
vfaceshape
veyebrowj (Rveyebrow
	veyeshapek (R	veyeshape
	veyepupill (R	veyepupil
vblushm (Rvblush 
vbodyweightn (Rvbodyweight
	vbodybusto (R	vbodybust

vskincolorp (R
vskincolor

vpupilsizeq (R
vpupilsize
vtattor (Rvtatto"
vdyeingcolors (Rvdyeingcolor"4
AvatarOrnament
type (Rtype
id (Rid"?
PersonalityData&
pinch (2.Cmd.PinchPeopleRpinch(
characteristics (Rcharacteristics=
avatarornaments (2.Cmd.AvatarOrnamentRavatarornaments"?
TemplateValue
valueInt (RvalueInt 
valueString (	RvalueString
	valueBool (R	valueBool2

valueTable (2.Cmd.TemplateValueR
valueTable"?
MapBlock
id (Rid%
type (2.Cmd.MapBlockTypeRtype(
shape (2.Cmd.MapBlockShapeRshape
pos (2.Cmd.ScenePosRpos
range (Rrange
width (Rwidth
length (Rlength"?
ZoneInfo
zoneid (Rzoneid
	maxbaselv (R	maxbaselv(
status (2.Cmd.EZoneStatusRstatus%
state (2.Cmd.EZoneStateRstate"\
UserData&
type (2.Cmd.EUserDataTypeRtype
value (Rvalue
data (	Rdata"I
	EntryData&
type (2.Cmd.ENineDataTypeRtype
value (Rvalue"Q
ItemEntryData*
type (2.Cmd.EItemNineDataTypeRtype
value (Rvalue"4
UserAttr
type (Rtype
value (Rvalue"?
WorkShopFurniture 
furnitureid (Rfurnitureid
pos (2.Cmd.ScenePosRpos
dir (Rdir=
subfurniturelist (2.Cmd.SubFurnitureRsubfurniturelist
roomids (Rroomids
guid (Rguid"?
SubFurniture 
furnitureid (Rfurnitureid
pos (2.Cmd.ScenePosRpos
dir (Rdir

parentguid (R
parentguid"b
WorkShopOrnament.
type (2.Cmd.EWorkShopOrnamentTypeRtype

ornamentid (R
ornamentid"?
WorkShopRoomOrnament
roomid (Rroomid9
roomornament (2.Cmd.WorkShopOrnamentRroomornament<
furniturelist (2.Cmd.WorkShopFurnitureRfurniturelist 
blueprintid (Rblueprintid*
hasinitblueprint (Rhasinitblueprint"?
WorkShopRoomBaseInfo
roomid (Rroomid 
blueprintid (Rblueprintid*
hasinitblueprint (Rhasinitblueprint9
roomornament (2.Cmd.WorkShopOrnamentRroomornament"v
WorkShopProtoType
id (Rid=
ornamentlist (2.Cmd.WorkShopRoomOrnamentRornamentlist
name (	Rname"u
WorkShopRoomData
roomid (Rroomid
roomlv (Rroomlv1
referencepos (2.Cmd.ScenePosRreferencepos"I
WorkShopWallEdit5
wallList (2.Cmd.WorkShopRoomWallDataRwallList"]
WorkShopRoomHeightEditC
roomheightlist (2.Cmd.WorkShopRoomHeightDataRroomheightlist"H
WorkShopRoomHeightData
roomid (Rroomid
height (Rheight"?
WorkShopRoomWallData'
wallPos (2.Cmd.ScenePosRwallPos)
state (2.Cmd.EWallStateTypeRstate

roomidlist (R
roomidlist"b
WorkShopBlueprintData'
type (2.Cmd.EBlueprintTypeRtype 
blueprintid (Rblueprintid"{
WorkShopProfitPartnerData
profitid (RprofitidB
profitstatelist (2.Cmd.WorkShopProfitStateRprofitstatelist"Z
WorkShopProfitRepairData
profitid (Rprofitid"
lastcalctime (Rlastcalctime"i
WorkShopProfitState
	isreceive (R	isreceive
calctime (Rcalctime
process (Rprocess"?
MoveStateData
actionid (Ractionid 
actionspeed (Ractionspeed
speed (Rspeed)
state (2.Cmd.EMoveStateTypeRstate"?
VehicleData
guid (Rguid2
state (2.Cmd.EPlayerVehicleStateTypeRstate%
curpos (2.Cmd.ScenePosRcurpos
rotate (Rrotate"r
JumpData
zSpeed (RzSpeed
index (Rindex
segment (Rsegment

timepassed (R
timepassed"c
FallData+
	targetpos (2.Cmd.ScenePosR	targetpos
rotate (Rrotate
flag (Rflag"w

MoveTarget
charid (Rcharid'
movepos (2.Cmd.ScenePosRmovepos
dir (Rdir
moveid (Rmoveid"?
MoveData
effectid (Reffectid
	time_axis (RtimeAxis1
movetargets (2.Cmd.MoveTargetRmovetargets
hitindex (Rhitindex"U
ShareDamageTarget
charid (Rcharid
value (Rvalue
type (Rtype"?
DamageTarget
charid (Rcharid
value (Rvalue
type (Rtype:
sharetargets (2.Cmd.ShareDamageTargetRsharetargets'
movepos (2.Cmd.ScenePosRmovepos
dir (Rdir
hittype (Rhittype

forcepower (R
forcepower
	damagedir	 (R	damagedir 
elementweak
 (Relementweak
iscrit (Riscrit

breaklevel (R
breaklevel
moveid (Rmoveid
	imbalance (R	imbalance"?

DamageData
effectid (Reffectid
	time_axis (RtimeAxis7
damagetargets (2.Cmd.DamageTargetRdamagetargets
hitindex (Rhitindex"?
MoveEffectData+
	targetpos (2.Cmd.ScenePosR	targetpos
rotate (Rrotate
skillid (Rskillid 
mainskillid (Rmainskillid)
movedata (2.Cmd.MoveDataRmovedata/

damagedata (2.Cmd.DamageDataR
damagedata
flag (Rflag"n

CDTimeItem
id (Rid
time (Rtime 
type (2.Cmd.CD_TYPERtype
recharge (Rrecharge"?
MapNpcVisibleStatusData
npcid (Rnpcid
	npcstatus (R	npcstatus&
npclogicstatus (RnpclogicstatusB
npcvisiblestatus (2.Cmd.ENpcVisibleStatusRnpcvisiblestatus
alias (	Ralias
guids (Rguids"?
NpcPrivateData
data (Rdata
data_str (	RdataStr+
type (2.Cmd.NpcPrivateDataTypeRtype 
talkcontent (	Rtalkcontent"~
MapNpcPrivateData
npcid (Rnpcid'
data (2.Cmd.NpcPrivateDataRdata
alias (	Ralias
guids (Rguids"_
CollegeGiftData
giftid (Rgiftid4
collegegifts (2.Cmd.CollegeGiftRcollegegifts"e
CollegeGift
gaintime (Rgaintime

isreceived (R
isreceived
isactive (Risactive*?
EUserDataType
EUSERDATATYPE_MIN 
EUSERDATATYPE_MAPID
EUSERDATATYPE_ROLELEVEL
EUSERDATATYPE_ROLEEXP
EUSERDATATYPE_ONLINETIME
EUSERDATATYPE_OFFLINETIME
EUSERDATATYPE_ADDICT
EUSERDATATYPE_AUTOCOMBAT
EUSERDATATYPE_STATUS*
EUSERDATATYPE_PORTRAIT-
EUSERDATATYPE_FRAME.
EUSERDATATYPE_RAIDID0
EUSERDATATYPE_CREATETIME3
EUSERDATATYPE_FOLLOWID5
EUSERDATATYPE_HANDID6
EUSERDATATYPE_FRIENDSHIP8
EUSERDATATYPE_MUSIC_CURID9
EUSERDATATYPE_MUSIC_START:
EUSERDATATYPE_MUSIC_DEMAND;
EUSERDATATYPE_MUSIC_DEMAND1<
EUSERDATATYPE_GAGTIME=
EUSERDATATYPE_NOLOGINTIME>
EUSERDATATYPE_NAME@
EUSERDATATYPE_CUR_TITLED 
EUSERDATATYPE_ADDICTTIPSTIMEI!
EUSERDATATYPE_NPC_INTERACTIONP 
EUSERDATATYPE_EQUIPED_WEAPON}
EUSERDATATYPE_FIGHTSTATUS?
EUSERDATATYPE_CUR_LOCKID?
EUSERDATATYPE_EQUIP_IDS?
EUSERDATATYPE_CAMP_ID?
EUSERDATATYPE_COMBAT_ID?,
'EUSERDATATYPE_TODAY_ACTIVE_DATING_COUNT?/
*EUSERDATATYPE_ACTIVE_DATING_CHOOSE_PARTNER?
EUSERDATATYPE_MAX?*Q
EGender
EGENDER_MIN 
EGENDER_MALE
EGENDER_FEMALE
EGENDER_MAX*?

EMoneyType
EMONEYTYPE_MIN 
EMONEYTYPE_GOLD???
EMONEYTYPE_DIAMOND???
EMONEYTYPE_COPY_MONEY???
EMONEYTYPE_EQUIP_EXP鴉"
EMONEYTYPE_FIGHTER_EXP_POOL괉
EMONEYTYPE_MAX_SEND???
EMONEYTYPE_CHARGE???
EMONEYTYPE_DAILYACTIVITY???*?
ECreatureStatus
ECREATURESTATUS_MIN 
ECREATURESTATUS_LIVE
ECREATURESTATUS_DEAD
ECREATURESTATUS_CLEAR
ECREATURESTATUS_RELIVE
ECREATURESTATUS_INRELIVE	
ECREATURESTATUS_MAX
*?
EFeaturesStatusType
EFEATURESSTATUS_MIN 
EFEATURESSTATUS_NOSELECT
EFEATURESSTATUS_SELECTLIGHT
EFEATURESSTATUS_UNSHOWNAME
EFEATURESSTATUS_UNSHOWHP	
EFEATURESSTATUS_UNSHOWLEVEL

EFEATURESSTATUS_UNSHOWMSG 
EFEATURESSTATUS_UNSHOWAVATAR%
!EFEATURESSTATUS_CLOSETODISPLAYNPC 
EFEATURESSTATUS_BLOCKMISSILE
EFEATURESSTATUS_NPCNOTTURN
EFEATURESSTATUS_NPCNOTWAVE
EFEATURESSTATUS_NPCNOTTALK"
EFEATURESSTATUS_NPCNOTTURNHEAD%
!EFEATURESSTATUS_NPCNOTPLAYBUBBLES(
$EFEATURESSTATUS_CLOSETOSPECIALACTION
EFEATURESSTATUS_VISIT
EFEATURESSTATUS_ONCONTROL
EFEATURESSTATUS_NORUN *?
EMoveStateType
EMOVESTATE_MIN 
EMOVESTATE_WALK
EMOVESTATE_RUN
EMOVESTATE_SPRINT
EMOVESTATE_BURROWS
EMOVESTATE_JUMP
EMOVESTATE_MOVEEFFECT
EMOVESTATE_FLY
EMOVESTATE_MOVING_SKILL
EMOVESTATE_LINK_JUMP	
EMOVESTATE_CLIMB

EMOVESTATE_MAX*i
EPlayerVehicleStateType
EPLAYER_VEHICLE_ENTER 
EPLAYER_VEHICLE_LEAVE
EPLAYER_VEHICLE_STAY*?
EMoveSubStateType
EMOVESUBSTATE_NORMAL 
EMOVESUBSTATE_BACKWARD
EMOVESUBSTATE_LOCKTARGET
EMOVESUBSTATE_CURVEEND
EMOVESUBSTATE_MAX*?
ESceneEntryCfgType
ESCENE_ENTRYTYPE_MIN 
ESCENE_ENTRYTYPE_PARTNER
ESCENE_ENTRYTYPE_NPC
 
ESCENE_ENTRYTYPE_REPAIR_ITEM 
ESCENE_ENTRYTYPE_NORMAL_ITEM!
ESCENE_ENTRYTYPE_COLLECT_ITEM(
ESCENE_ENTRYTYPE_BOX_ITEM2#
ESCENE_ENTRYTYPE_NORMAL_MONSTER<$
 ESCENE_ENTRYTYPE_PARTNER_MONSTER=#
ESCENE_ENTRYTYPE_ELITES_MONSTERF!
ESCENE_ENTRYTYPE_BOSS_MONSTERP!
ESCENE_ENTRYTYPE_BOSS_ANCIENTQ#
ESCENE_ENTRYTYPE_FURNITURE_ITEMZ 
ESCENE_ENTRYTYPE_BATTLE_ITEMd
ESCENE_ENTRYTYPE_TOY_ITEMn
ESCENE_ENTRYTYPE_MAX?
ESCENE_ENTRYTYPE_VEHICLE?
ESCENE_ENTRYTYPE_MAPACTOR?
ESCENE_ENTRYTYPE_DROPITEM?!
ESCENE_ENTRYTYPE_INTERACTION?*E

BoxNpcType
BOXNPC_UNLOCK 
BOXNPC_LOCK_1
BOXNPC_LOCK_2*?
EFightStatusType
EFIGHTSTATUS_MIN 
EFIGHTSTATUS_FIGHT
EFIGHTSTATUS_FREE
EFIGHTSTATUS_FIGHTACT
EFIGHTSTATUS_MAX*d
EFightSwordType
EFIGHTSWORD_MIN 
EFIGHTSWORD_OFF
EFIGHTSWORD_ON
EFIGHTSWORD_MAX*o
EAutoCombatStatusType
EAUTOCOMBATSTATUS_MIN 
EAUTOCOMBATSTATUS_SEMI_AUTO
EAUTOCOMBATSTATUS_AUTO*?
EIdleSubStatusType
EIDLESUBSTATUS_MIN 
EIDLESUBSTATUS_IDLE
EIDLESUBSTATUS_SIT
EIDLESUBSTATUS_LAY!
EIDLESUBSTATUS_WEAPON_EQUIPED*?
EAngerStatusType
EANGERSTATUS_MIN 
EANGERSTATUS_NORMAL
EANGERSTATUS_FURY
EANGERSTATUS_WEAK
EANGERSTATUS_MAX*?
EWeaponInteractType
EWEAPONINTERACT_MIN 
EWEAPONINTERACT_PICK
EWEAPONINTERACT_USE
EWEAPONINTERACT_BEPICKe
EWEAPONINTERACT_BEUSEf
EWEAPONINTERACT_MAX?*s
EBarrierStatusType
EBARRIERSTATUS_MIN 
EBARRIERSTATUS_ON
EBARRIERSTATUS_OFF
EBARRIERSTATUS_MAX*?
	GoMapType

GOMAP_NULL 
GOMAP_EXITPOINT
GOMAP_KICKUSER
GOMAP_QUEST
GOMAP_GOCITY
GOMAP_RELIVE
GOMAP_GM

GOMAP_WORLD
GOMAP_MAPLIST
GOMAP_LOGIN
GOMAP_REPAIR
GOMAP_DAILYACTIVITY
GOMAP_ACTIVEDATING
GOMAP_INTERACTION

GOMAP_WXKJ
GOMAP_COPYSCENE
GOMAP_FIGHTMOVETOMASTER
GOMAP_NPCFOLLOW
GOMAP_EDITTEAM
GOMAP_MATCH*Z
MapBlockType
MAP_BLOCK_TYPE_MIN 
MAP_BLOCK_TYPE_QUEST
MAP_BLOCK_TYPE_STAGE*?
MapBlockShape
MAP_BLOCK_SHAPE_ROUND 
MAP_BLOCK_SHAPE_SQUARE
MAP_BLOCK_SHAPE_POLYGON
MAP_BLOCK_SHAPE_AREA
MAP_BLOCK_SHAPE_MAX*?
NpcPrivateDataType
NPC_PRIVATE_DATA_TYPE_MIN $
 NPC_PRIVATE_DATA_TYPE_IDLEACTION(
$NPC_PRIVATE_DATA_TYPE_IDLEEXPRESSION$
 NPC_PRIVATE_DATA_TYPE_TALKACTION(
$NPC_PRIVATE_DATA_TYPE_TALKEXPRESSION)
%NPC_PRIVATE_DATA_TYPE_DEFAULTTALKTEXT(
$NPC_PRIVATE_DATA_TYPE_HEADBUBBLETEXT!
NPC_PRIVATE_DATA_TYPE_NPCNAME$
 NPC_PRIVATE_DATA_TYPE_REPAIRSTAR
NPC_PRIVATE_DATA_TYPE_MAX	*?
EFollowType
EFOLLOWTYPE_MIN 
EFOLLOWTYPE_HAND
EFOLLOWTYPE_BREAK
EFOLLOWTYPE_TWINSACTION
EFOLLOWTYPE_MAX*}
EZoneStatus
EZONESTATUS_MIN 
EZONESTATUS_FREE
EZONESTATUS_BUSY
EZONESTATUS_VERYBUSY
EZONESTATUS_MAX*`

EZoneState
EZONESTATE_MIN 
EZONESTATE_FULL
EZONESTATE_NOFULL
EZONESTATE_MAX*?
EWorkShopOrnamentType
EWORKSHOP_ORNAMENT_TYPE_MIN  
EWORKSHOP_ORNAMENT_TYPE_WALL!
EWORKSHOP_ORNAMENT_TYPE_FLOOR#
EWORKSHOP_ORNAMENT_TYPE_CEILING*?
EWallStateType
EWALLSTATE_NORMAL 
EWALLSTATE_DESTROY*D
EBlueprintType
EBLUEPRINTTYPE_SYSTEM 
EBLUEPRINTTYPE_USER*_
EProfitReceiveType
EPROFIT_RECEIVE_ALL 
EPROFIT_RECEIVE_ID
EPROFIT_RECEIVE_TIME*?
	SceneType
SCENE_TYPE_MIN 
SCENE_TYPE_PUBLIC
SCENE_TYPE_DSCENE
SCENE_TYPE_LOBBYRAID
SCENE_TYPE_WXKJRAID
SCENE_TYPE_MAX

SCENE_TYPE_COPY??
SCENE_TYPE_MISSION??*?
ERepairObjState
STATE_DISAPPEAR 
STATE_APPEARED_NO_RESEARCH
STATE_ITEM_ENOUGH
STATE_REPAIRED

STATE_DONE*?

EQuestFlag
QUEST_FLAG_MIN 
QUEST_FLAG_GRAY
QUEST_FLAG_YELLOW
QUEST_FLAG_ENERGY
QUEST_FLAG_NORMAL_STAR
QUEST_FLAG_SHINE_STAR
QUEST_FLAG_MAX*U
ActionPriority
ACTION_PRIORITY_1 
ACTION_PRIORITY_2
ACTION_PRIORITY_3*?
ERaidCopySchedule
ECOPY_SCHEDULE_MIN 
ECOPY_SCHEDULE_QUEST
ECOPY_SCHEDULE_BOSS
ECOPY_SCHEDULE_COMPLETE
ECOPY_SCHEDULE_MAXN*Z
EBoxType
EBOXTYPE_MIN 
EBoxType_NORMAL
EBOXTYPE_BUFF
EBOXTYPE_MONSTER*^
CD_TYPE
CD_TYPE_SKILL 
CD_TYPE_ITEM
CD_TYPE_SKILLDELAY
CD_TYPE_DODGESKILL*?
ENpcVisibleStatus
NPC_VISIBLE_STATUS_MIN 
NPC_VISIBLE_STATUS_PUBLIC
NPC_VISIBLE_STATUS_TEAM
NPC_VISIBLE_STATUS_PRIVATE
NPC_VISIBLE_STATUS_MAX*?
EWXKJStageSchedule
EWXKJSTAGESCHEDULE_INIT 
EWXKJSTAGESCHEDULE_OPEN
EWXKJSTAGESCHEDULE_COMPLETE
EWXKJSTAGESCHEDULE_END*?
EUserCounterType"
EUSERCOUNTERTYPE_LOTTERY_NOSSR  
EUSERCOUNTERTYPE_LOTTERY_ALL#
EUSERCOUNTERTYPE_EQUIP_POS_MIN?N$
EUSERCOUNTERTYPE_EQUIP_POS_MAX??"
EUSERCOUNTERTYPE_SKILL_LEVEL??*?
EConfigType
CONFIGTYPE_NONE 
CONFIGTYPE_AILEAF
CONFIGTYPE_ROLEDATA
CONFIGTYPE_OBJECTATTR
CONFIGTYPE_FIGHTATTRCFG
CONFIGTYPE_BATTLECFG
CONFIGTYPE_MISC
CONFIGTYPE_ITEM
CONFIGTYPE_SKILL
CONFIGTYPE_BUFFER	
CONFIGTYPE_NPC

CONFIGTYPE_PARTNER
CONFIGTYPE_USERLEVEL
CONFIGTYPE_SCENE
CONFIGTYPE_QUEST
CONFIGTYPE_REWARD
CONFIGTYPE_ANIMATION
CONFIGTYPE_MENU
CONFIGTYPE_SKILLLEVEL
CONFIGTYPE_MOVEACTION
CONFIGTYPE_LOTTERY
CONFIGTYPE_SCENEITEM
CONFIGTYPE_ITEMEQUIOUPGRADE
CONFIGTYPE_WXKJSCENECONFIG
CONFIGTYPE_COLLEGE
CONFIGTYPE_DAILYACTIVITY
CONFIGTYPE_CLUBCHALLENGE
CONFIGTYPE_ENTRYEVENT
CONFIGTYPE_SYSMSG
CONFIGTYPE_FAVORILITY 
CONFIGTYPE_ACCESSITEM!
CONFIGTYPE_ACTIVEDATING"
CONFIGTYPE_ENTRYPERFORMANCE#
CONFIGTYPE_SCENECONFIG$
CONFIGTYPE_OBJECTDATA%
CONFIGTYPE_NAVMESH&
CONFIGTYPE_MAX?*?
EObjectDefineType
EOBJECTDEFINE_TYPE_UNKNOWN 
EOBJECTDEFINE_TYPE_OBJECT
EOBJECTDEFINE_TYPE_NPC
EOBJECTDEFINE_TYPE_STATIC
EOBJECTDEFINE_TYPE_USER*`

EModelType
EMODELTYPE_MIN 
EMODELTYPE_CAPSULE
EMODELTYPE_BOX
EMODELTYPE_MAXBZ.;Cmdbproto3