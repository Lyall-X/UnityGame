
��
SceneUser.protoCmdProtoCommon.proto"7
UserAttrSvr
type (
value (Rvalue"5
SetUserDataCmd#
datas (2
SetNineDataCmd.

entrydatas (2.Cmd.EntryDataR
entrydatas")

command (	Rcommand"c
UserLevelUpSyncCmd
guid (Rguid
newlv (
attrs (2
AttrsChangeSyncCmd
npcid (
source (
attrs (2
UserAttrChangeShowCmd
guid (Rguid4

changetype (2.Cmd.EAttrChangeTypeR
changetype#
attrs (2
CmdExitPoint
id (
pos (2
range (2
rotation (2
tomapid (
NpcIcon
npcid (
pos (2
dir (
ChangeSceneUserCmd
mapID (
mapName (	RmapName
pos (2
dmapID (
preview (
resource
 (	Rresource
minimap (	Rminimap#
eps (2.Cmd.CmdExitPointReps0
monstericons (2.Cmd.NpcIconRmonstericons
dir (
	gomaptype (2.Cmd.GoMapTypeR	gomaptype
	scenetype (
localDungeonPos (2
localDungeonRadius (
localDungeonID (
localDungeonName (	RlocalDungeonName*
localDungeonType (
artresource (	Rartresource$

clientloaderror (Rclientloaderror
relogin (Rrelogin
isnewmap (Risnewmap"
RaidBackCmd"M

RaidWinCmd

nextraidid (
nextraidid
pos (2
ShareDamTarget
charid (Rcharid
damage (Rdamage
type (Rtype"�
	PhaseData
number (Rnumber
pos (2
hitedTargets (RhitedTargets'
movepos (2
dir (Rdir
skilldir (Rskilldir 
blacksanend (Rblacksanend
pickitem (Rpickitem.
accumulate_end_time	 (
curpos
 (2
SkillBroadcastUserCmd
charid (Rcharid
skillID (
skilllv (
	reinforce (
data (2.Cmd.PhaseDataRdata
randseed (Rrandseed
	chanttime (

damagedata	 (2.Cmd.DamageDataR
damagedata)
movedata
 (2
mainskillid (
passivetrigger (Rpassivetrigger
	timestamp
uniqueid (Runiqueid"�
BreakSkillUserCmd
charid (Rcharid
skillid (
type (2.Cmd.ESkillBreakTypeRtype
damage (
actionid (
	time_axis (
	breakerid (R	breakerid$

pos	 (2
MoveEffectUserCmd
charid (Rcharid
skillid (
skilllv (
movedata (2
mainskillid (
BattleObjectData
effectid (
	time_axis (
eConditionType (
eResultType (
BattleObjectEffectUserCmd
charid (Rcharid
skillid (
skilllv (
battleObjectdata (2.Cmd.BattleObjectDataRbattleObjectdata"�
DamageEffectUserCmd
charid (Rcharid
skillid (
skilllv (
	timestamp (R	timestamp/

damagedata (2.Cmd.DamageDataR
damagedata 
mainskillid (
uniqueid (Runiqueid"T

charid (Rcharid+
	targetpos (2
MissileData
effectid (
	time_axis (
missiletargets (2.Cmd.MissileTargetRmissiletargets"�
MissileEffectUserCmd
charid (Rcharid
skillid (
skilllv (
missiledata (2.Cmd.MissileDataRmissiledata"^
SpecialRandActorPosData+
	targetpos (2
rotate (Rrotate"3
SpecialSelectByAttrData
targets (Rtargets"�
SpecialThunderDataA
thunders (2%.Cmd.SpecialThunderData.ThunderTargetRthundersI

	thunderid (R	thunderid
targetid (Rtargetid"�
SpecialData
effectid (
	time_axis (
datas (Rdatas8
randdata (2.Cmd.SpecialRandActorPosDataRranddata<

selectdata (2.Cmd.SpecialSelectByAttrDataR
selectdata
	targetids (R	targetids9
thunderdata (2.Cmd.SpecialThunderDataRthunderdata"�
SpecialEffectUserCmd
charid (Rcharid
skillid (
skilllv (
specialdata (2.Cmd.SpecialDataRspecialdata"�
BuffData
effectid (
	time_axis (
targets (Rtargets+
	targetpos (2
buff_effect_layers (
BuffEffectUserCmd
charid (Rcharid
skillid (
skilllv (
buffdata (2
UpdateSkillRandSeedCmd
randseed (Rrandseed"]
SkillResultUserCmd
charid (Rcharid/

damagedata (2.Cmd.DamageDataR
damagedata"�
AnimMoveSyncPosData
charid (Rcharid
pos (2
dir (Rdir
moveid (
state (2.Cmd.EAnimMoveStateRstate
action_name (	R
actionName
action_time (
actionTime!
motion_scale (RmotionScale"D
AnimMoveSyncPosCmd.
infos (2.Cmd.AnimMoveSyncPosDataRinfos"H

guid (Rguid#
list (2.Cmd.CDTimeItemRlist"5

type (2.Cmd.EReliveTypeRtype"�
GoToUserCmd
pos (2
charid (Rcharid
isgomap (Risgomap
rotate (
type (2.Cmd.GoMapTypeRtype"*
GoToExitPosUserCmd
mapid (
CVisitNpcUserCmd
guid (Rguid"N
RetVisitNpcUserCmd
guid (Rguid$

CStopVisitNpcUserCmd
guid (Rguid",
RetStopVisitNpcUserCmd
guid (Rguid"�
SShowDialogUserCmd
guid (Rguid
dialogid (
type (
text (	Rtext
emoji (
action (	Raction
voice	 (	Rvoice",
ChoosePartnerUserCmd
index (
TeamMemberData
index (
cfgid (
guid (
TeamDataCmd
charid (Rcharid+
member (2.Cmd.TeamMemberDataRmember 
leaderindex (
SetTeamUserCmd2
member (2.Cmd.SetTeamUserCmd.MemberRmember8
Member
index (
fighter (
	LayerData
id (
time (Rtime
pos (2
targetid (Rtargetid"�

BufferData
id (
layer (
time (Rtime
active (Ractive
fromname (	Rfromname
fromid (Rfromid
level (
	layerdata (2.Cmd.LayerDataR	layerdata 
fromskillid	 (
fromeffecttime
 (
shielddefvalue (
hide (Rhide"h
UserBuffNineSyncCmd
guid (Rguid)
updates (2.Cmd.BufferDataRupdates
dels (
UserActionNineSyncCmd
guid (Rguid
actionid (
looptime (

actiontype (2.Cmd.EActionTypeR
actiontype
force (Rforce
	isprivate (R	isprivate
islookat	 (Rislookat
isbase
 (Risbase
isstop (Risstop

actionname (	R
actionname"�
UserExpressionNineSyncCmd
guid (Rguid&
expressionname (	Rexpressionname
looptime (
type (2.Cmd.EActionTypeRtype
force (Rforce
	isprivate (R	isprivate
isstop	 (Risstop"�
UserMouthNineSyncCmd
guid (Rguid
idleid (
mouthaction (	Rmouthaction&
mouthactionend (Rmouthactionend
looptime (
type (2.Cmd.EActionTypeRtype
force (Rforce"m
UserShowBubbleCmd
guid (Rguid
name (	Rname
lasttime (
force (Rforce"�
UserEffectNineSyncCmd
pos (2
guid (Rguid
name (	Rname

attachname (	R
attachname
looptime (
isstop (Risstop
dir	 (Rdir"�
UserSoundNineSyncCmd
pos (2
guid (Rguid
name (	Rname
looptime (
isstop (Risstop"L
NotifyHideCloseUserCmd
guid (Rguid

closeguids (R
closeguids"*
UnlockingMenuCmd
menuID (
UnlockedMenuDataCmd#
type (2.Cmd.EMenuEventRtype 
unlockedIDs (RunlockedIDs"
unlockedstrs (	Runlockedstrs"1
ReqMapLinkUserCmd
	maplinkid (
BroadCastMapLinkUserCmd
	maplinkid (
guid (Rguid
pos (2
GoMapUserCmd
mapid (
	PlayCGCmd
cgname (	Rcgname$
cgtype (2.Cmd.ECgTypeRcgtype
params (	Rparams2

cameramode (2.Cmd.ECgCameraModeR
cameramode&
fashionnpclist (	Rfashionnpclist"
adaptiveguid (Radaptiveguid"D
UserCollegeGiftInfoCmd*
gifts (2.Cmd.CollegeGiftDataRgifts"5
UserCollegeGiftReceiveCmd
giftids (
UserUseUniqueSkillCmd
index (

id (
	direction (
strengthcurveid (
inquest (Rinquest"*
CBossShowUpFinishCmd
guid (Rguid"x
ShakeScreenCmd
	curvename (	R	curvename
scale (Rscale
lasttime (
isstop (Risstop"�

guid (Rguid
id (
lasttime (

openrandom (R
openrandom"
intervaltime (
talkContent (	RtalkContent"�
InteractionWithEntryCmd
guid (Rguid
beguid (Rbeguid
	entrytype (
opertype (2.Cmd.EInteractiveOperTypeRopertype
tgtid (Rtgtid%
tgtpos (2
InteractionCmd
guid (Rguid
beguid (Rbeguid
socketid (
opertype (	Ropertype
tgtid (Rtgtid%
tgtpos (2
InteractionResultCmd
guid (Rguid
beguid (Rbeguid
result (Rresult"
	PickUpCmd
guid (Rguid"U
PickUpResultCmd
guid (Rguid
beguid (Rbeguid
result (Rresult"-

PutDownCmd
pos (2
PutDownResultCmd
guid (Rguid
beguid (Rbeguid
result (Rresult
pos (2
ThrowCmd
pos (2
ThrowResultCmd
guid (Rguid
beguid (Rbeguid
result (Rresult
pos (2
CatapultCmd
pos (2
CatapultResultCmd
guid (Rguid
beguid (Rbeguid
result (Rresult"&
OnVehicleCmd
beguid (Rbeguid"X
OnVehicleResultCmd
guid (Rguid
beguid (Rbeguid
result (Rresult"0

pos (2
OffVehicleResultCmd
guid (Rguid
beguid (Rbeguid
result (Rresult
pos (2
InteractionEventCmd
beguid (Rbeguid)
type (2.Cmd.EInteractionTypeRtype"2
ChatMsgClientToGateCmd
content (Rcontent"2
ChatMsgGateToClientCmd
content (Rcontent"�
MiniMapsInfoCmdE
minimapinfo (2#.Cmd.MiniMapsInfoCmd.OneMiniMapInfoRminimapinfoP
OneMiniMapInfo
mapid (
npcicons (2.Cmd.NpcIconRnpcicons"P

LotteryCmd
type (
times (
batchid (
SendLotteryResultCmdO
lotteryresults (2'.Cmd.SendLotteryResultCmd.LotteryResultRlotteryresultsu

itemid (
	itemcount (
type (
brandnew (
SendGMLotteryResultCmdQ
lotteryresults (2).Cmd.SendGMLotteryResultCmd.LotteryResultRlotteryresults�

itemid (
times (

convertnum (
convertnum
type (
brandnew (
UserSpecialActionCmd
beguid (
action (
AsideUserCmd
npcid (
textid (
showtime (
orientation (2.Cmd.EAsideOrientationRorientation"m
SendPartnerSourceCmd
	partnerid (

sourcetype (2.Cmd.EPartnerSourceTypeR
sourcetype"@
SceneRaidResultCmd
rank (
result (Rresult"�
C2SBuffSyncCmd
charid (Rcharid
buffid (
active (Ractive&
shielddefvalue (
AcceptRepairTask
cfgid (
AddPartnerExpFromExpPoolCmd
	fighterid (
expvalue (Rexpvalue1
result (2.Cmd.EAddPartnerExpResultRresult"+
PlayItemAnimation
itemid (
WXKJAsideUserCmd
npcid (
textid (
showtime (
orientation (2.Cmd.EAsideOrientationRorientation"x
BlackSanCmd
guid (Rguid
start (Rstart%
hitpos (2
skillid (
GoToCommonTraceCmd
id (

serveranswer (
pos (2
type (
strkey (	Rstrkey"�
SummonEffectUserCmd
charid (Rcharid
skillid (
skilllv (
effectid (
	time_axis (
pos (2
index (Rindex"?
ClubChallengeInfo
level (
npcid (
DailyActivityInfo
id (
characterid (
endtime (Rendtime
status (
uid (Ruid"�
LeagueActivity
id (
endtime (Rendtime
status (
refreshfield (Rrefreshfield
level (
clubInfo (2.Cmd.ClubChallengeInfoRclubInfo
uid (Ruid
alias (	Ralias"�
ActiveDatingInfo
id (
characterid (
endtime (Rendtime
status (
refreshfield (Rrefreshfield
uid (Ruid
fvalue (
type (
alias	 (	Ralias"�
DailyActivityCmd<

leagueactivity (2.Cmd.LeagueActivityRleagueactivity2
nextQuestRefreshTime (RnextQuestRefreshTime9
activedating (2.Cmd.ActiveDatingInfoRactivedating,
allcompletestatus (
DailyActivityAwardCmd
uid (
ClubChallengeCGCmd
cg (	Rcg
showid1 (
showid2 (
showid3 (
DailyActivityCompleteAwardCmd"<
WeakSyncSwitchCmd'
weaksync_switch (RweaksyncSwitch"B
RootMotionSwitchCmd+
rootmotion_switch (RrootmotionSwitch"G
StressTestResponseCmd
ret (
	timestamp (R	timestamp"C
SetRobotCmd
set (Rset"
isplayerwalk (Risplayerwalk"c
SyncActionListCmd
guid (

actionlist (
actionlist
needloop (Rneedloop",
NpcBubblePerceptionCmd
guid (
EAttrChangeType
EATTRCHANGETYPE_MIN 
EATTRCHANGETYPE_EQUIP"
EATTRCHANGETYPE_EQUIP_STRENGTH 
EATTRCHANGETYPE_EQUIP_UPSTAR
EATTRCHANGETYPE_MAX*w
ELocalDungeonType
ELOCALDUNGEON_TYPE_NORMAL $
 ELOCALDUNGEON_TYPE_CLUBCHALLENGE
ELOCALDUNGEON_TYPE_REPAIR*�
ESkillPhaseType
ESKILLPHASE_TYPE_MIN 
ESKILLPHASE_TYPE_CHANT
ESKILLPHASE_TYPE_RUN#
ESKILLPHASE_TYPE_ACCUMULATE_END
ESKILLPHASE_TYPE_CORRECT
ESKILLPHASE_TYPE_END*�
ESkillBreakType
ESKILLBREAK_TYPE_MIN 
ESKILLBREAK_TYPE_CORRECT
ESKILLBREAK_TYPE_CHANT
ESKILLBREAK_TYPE_RUN
ESKILLBREAK_TYPE_LEADSKILL
ESKILLBREAK_TYPE_MAX*�

DamageType
DAMAGE_TYPE_NONE 
DAMAGE_TYPE_NORMAL
DAMAGE_TYPE_MISS
DAMAGE_TYPE_HEAL
DAMAGE_TYPE_IMMUNE
DAMAGE_TYPE_MULTIHIT
DAMAGE_TYPE_SHIELD
DAMAGE_TYPE_HEAL_ETHER
DAMAGE_TYPE_REDUCE_ETHER	
DAMAGE_TYPE_REBOUND

DAMAGE_TYPE_FIRE
DAMAGE_TYPE_ICE
DAMAGE_TYPE_THUNDER
DAMAGE_TYPE_EARTH
DAMAGE_TYPE_CUT
DAMAGE_TYPE_STRIKE
DAMAGE_TYPE_SPIKE
DAMAGE_TYPE_INVINCIBLE
DAMAGE_TYPE_MAX*�
EAnimMoveState
EANIMMOVESTATE_MIN 
EANIMMOVESTATE_START
EANIMMOVESTATE_MOVING
EANIMMOVESTATE_END
EANIMMOVESTATE_MAX*�
EReliveType
ERELIVETYPE_MIN 
ERELIVETYPE_RETURN
ERELIVETYPE_GM
ERELIVETYPE_SKILL
ERELIVETYPE_AUTO
ERELIVETYPE_QUEST
ERELIVETYPE_LEAVECOPY
ERELIVETYPE_LOGOUT
ERELIVETYPE_MAX	*~
EActionType
EACTIONTYPE_MIN 
EACTIONTYPE_NORMAL
EACTIONTYPE_SUSTAIN
EACTIONTYPE_LOOP
EACTIONTYPE_MAX*�

EMenuEvent
EMENUEVENT_MIN 
EMENUEVENT_UNLOCKFUNCTION
EMENUEVENT_UNLOCKSKILL
EMENUEVENT_UNLOCKMAP
EMENUEVENT_UNLOCKAREA
EMENUEVENT_UNLOCKNPCSTATUS
EMENUEVENT_SHOWNPC
EMENUEVENT_MONSTER_UNLOCK	
EMENUEVENT_WXKJ

EMENUEVENT_BORNPOINT!
EMENUEVENT_UNLOCK_CLOSEAUTOUP
EMENUEVENT_COLLEGE_GIFT
EMENUEVENT_SKILL_LEVEL_LIMIT 
EMENUEVENT_EQUIP_LEVEL_LIMIT
EMENUEVENT_ELITE_REPAIR
EMENUEVENT_DAILYACTIVITY
EMENUEVENT_MAX�N*S
ECgType
ECGTYPE_MIN 
ECGTYPE_NORMAL
ECGTYPE_REPAIR
ECGTYPE_MAX*�

ECGCAMERAMODE_MIN 
ECGCAMERAMODE_BLANK_SCREEN
ECGCAMERAMODE_TRANSITION
ECGCAMERAMODE_DOWNSHEAR
ECGCAMERAMODE_MAX*�
EInteractiveOperType
EINTERACTIVEOPER_MIN 
EINTERACTIVEOPER_PICK
EINTERACTIVEOPER_THROW
EINTERACTIVEOPER_ACTIVE
EINTERACTIVEOPER_VALID
EINTERACTIVEOPER_TICK
EINTERACTIVEOPER_GIVEUP
EINTERACTIVEOPER_USE
EINTERACTIVEOPER_CANCEL_USE
EINTERACTIVEOPER_ON_VEHICLE	 
EINTERACTIVEOPER_OFF_VEHICLE
!
EINTERACTIVEOPER_LOCALDUNGEON
EINTERACTIVEOPER_RECEIVE 
EINTERACTIVEOPER_TASKTRIGGER
EINTERACTIVEOPER_OPEN
EINTERACTIVEOPER_CLOSE
EINTERACTIVEOPER_GETNPC
EINTERACTIVEOPER_REPAIR
EINTERACTIVEOPER_COLLECT
EINTERACTIVEOPER_DELAYGET
EINTERACTIVEOPER_SUBMIT
EINTERACTIVEOPER_SEAT_EAT
EINTERACTIVEOPER_INFO#
EINTERACTIVEOPER_COLLECT_WEAPON
EINTERACTIVEOPER_MAX*�
EInteractionType
EINTERACTION_TYPE_MIN 
EINTERACTION_TYPE_PICKUP
EINTERACTION_TYPE_PUTDOWN
EINTERACTION_TYPE_THROW
EINTERACTION_TYPE_ONVEHICLE 
EINTERACTION_TYPE_OFFVEHICLE
EINTERACTION_TYPE_MEND 
EINTERACTION_TYPE_SCANOBJECT
EINTERACTION_TYPE_TRACE 
EINTERACTION_TYPE_CONNECTION	*�
LotteryType
ELOTTERYTYPE_MIN 
ELOTTERYTYPE_PARTNER
ELOTTERYTYPE_EQUIP
ELOTTERYTYPE_MIX
ELOTTERYTYPE_GMZ
ELOTTERYTYPE_GM_PARTNER[
ELOTTERYTYPE_GM_EQUIP\
ELLOTERYTYPE_MAXd*�
EAsideOrientation
EASIDEORIENTATION_MIN 
EASIDEORIENTATION_UP
EASIDEORIENTATION_MIDDLE
EASIDEORIENTATION_DOWN
EASIDEORIENTATION_MAX*�
EPartnerSourceType
EPARTNERSOURCETYPE_MIN 
EPARTNERSOURCETYPE_LOTTERY
EPARTNERSOURCETYPE_ITEM
EPARTNERSOURCETYPE_NONE
EPARTNERSOURCETYPE_GM
EPARTNERSOURCETYPE_MISSION
EPARTNERSOURCETYPE_MAXc*�
EAddPartnerExpResult
EADDPARTNEREXPRESULT_MIN *
&EADDPARTNEREXPRESULT_INVALID_FIGHTERID$
 EADDPARTNEREXPRESULT_ADD_FAILURE#
EADDPARTNEREXPRESULT_NOT_ENOUGH(
$EADDPARTNEREXPRESULT_IS_MAIN_FIGHTER 
EADDPARTNEREXPRESULT_SUCCESS
EADDPARTNEREXPRESULT_MAX*�
GotoType
GOTO_TRUEQUEST 
GOTO_COMMONREPAIR
GOTO_ELITEREPAIR
GOTO_DAILYQUEST
GOTO_SOCIALQUEST
GOTO_WXKJQUEST
GOTO_ACCESSOBJECT
GOTO_ACTIVEDATING
GOTO_CLUBCHALLENGE
GOTO_MAPLIST	
GOTO_DATINGROOM

GOTO_DATINGSCENE

DailyActivityState
DAILYACTIVITY_INIT 
DAILYACTIVITY_OPEN
DAILYACTIVITY_COMPLETE
DAILYACTIVITY_END*�
DailyActivityRewardType
DAILYACTIVITY_TYPE_NONE 
DAILYACTIVITY_TYPE_PROP
DAILYACTIVITY_TYPE_LEVEL
DAILYACTIVITY_TYPE_SKILL
DAILYACTIVITY_TYPE_BIGSKILL
DAILYACTIVITY_TYPE_ELITE
DAILYACTIVITY_TYPE_GOLD
DAILYACTIVITY_TYPE_DATING*�
DailyActivityPropRewardType
DAILYACTIVITY_PROP_MAXHP 
DAILYACTIVITY_PROP_ATK
DAILYACTIVITY_PROP_DEF
DAILYACTIVITY_PROP_MDEF 
DAILYACTIVITY_PROP_HPRECOVER*�
DailyActivityType
DAILYACTIVITY_TYPE &
"LEAGUEACTIVITY_TYPE_CHALLENGE_LEFT'
#LEAGUEACTIVITY_TYPE_CHALLENGE_RIGHT
LEAGUEACTIVITY_TYPE_WXKJ*�
DailyActivityErrorType
DAILYACTIVITY_ERROR_NONE !
DAILYACTIVITY_ERROR_NOT_EXIST 
DAILYACTIVITY_ERROR_NOT_OPEN$
 DAILYACTIVITY_ERROR_NOT_COMPLETEBZ.;Cmdbproto3