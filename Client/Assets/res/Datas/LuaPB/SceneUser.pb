
ù¡
SceneUser.protoCmdProtoCommon.proto"7
UserAttrSvr
type (Rtype
value (Rvalue"5
SetUserDataCmd#
datas (2.Cmd.UserDataRdatas"@
SetNineDataCmd.

entrydatas (2.Cmd.EntryDataR
entrydatas")
UserGMCommand
command (	Rcommand"c
UserLevelUpSyncCmd
guid (Rguid
newlv (Rnewlv#
attrs (2.Cmd.UserAttrRattrs"g
AttrsChangeSyncCmd
npcid (Rnpcid
source (Rsource#
attrs (2.Cmd.UserAttrRattrs"†
UserAttrChangeShowCmd
guid (Rguid4

changetype (2.Cmd.EAttrChangeTypeR
changetype#
attrs (2.Cmd.UserAttrRattrs"©
CmdExitPoint
id (Rid
pos (2.Cmd.ScenePosRpos#
range (2.Cmd.ScenePosRrange)
rotation (2.Cmd.ScenePosRrotation
tomapid (Rtomapid"R
NpcIcon
npcid (Rnpcid
pos (2.Cmd.ScenePosRpos
dir (Rdir"“
ChangeSceneUserCmd
mapID (RmapID
mapName (	RmapName
pos (2.Cmd.ScenePosRpos
dmapID (RdmapID
preview (Rpreview
resource
 (	Rresource
minimap (	Rminimap#
eps (2.Cmd.CmdExitPointReps0
monstericons (2.Cmd.NpcIconRmonstericons
dir (Rdir,
	gomaptype (2.Cmd.GoMapTypeR	gomaptype
	scenetype (R	scenetype7
localDungeonPos (2.Cmd.ScenePosRlocalDungeonPos.
localDungeonRadius (RlocalDungeonRadius&
localDungeonID (RlocalDungeonID*
localDungeonName (	RlocalDungeonName*
localDungeonType (RlocalDungeonType 
artresource (	Rartresource$
logicresource (	Rlogicresource(
clientloaderror (Rclientloaderror
relogin (Rrelogin
isnewmap (Risnewmap"
RaidBackCmd"M

RaidWinCmd

nextraidid (R
nextraidid
pos (2.Cmd.ScenePosRpos"T
ShareDamTarget
charid (Rcharid
damage (Rdamage
type (Rtype"Ô
	PhaseData
number (Rnumber
pos (2.Cmd.ScenePosRpos"
hitedTargets (RhitedTargets'
movepos (2.Cmd.ScenePosRmovepos
dir (Rdir
skilldir (Rskilldir 
blacksanend (Rblacksanend
pickitem (Rpickitem.
accumulate_end_time	 (RaccumulateEndTime%
curpos
 (2.Cmd.ScenePosRcurpos"¿
SkillBroadcastUserCmd
charid (Rcharid
skillID (RskillID
skilllv (Rskilllv
	reinforce (R	reinforce"
data (2.Cmd.PhaseDataRdata
randseed (Rrandseed
	chanttime (R	chanttime/

damagedata	 (2.Cmd.DamageDataR
damagedata)
movedata
 (2.Cmd.MoveDataRmovedata 
mainskillid (Rmainskillid&
passivetrigger (Rpassivetrigger
	timestamp (R	timestamp
uniqueid (Runiqueid"¥
BreakSkillUserCmd
charid (Rcharid
skillid (Rskillid(
type (2.Cmd.ESkillBreakTypeRtype
damage (Rdamage
actionid (Ractionid
	time_axis (RtimeAxis
	breakerid (R	breakerid$
breakstrength (Rbreakstrength
pos	 (2.Cmd.ScenePosRpos"¬
MoveEffectUserCmd
charid (Rcharid
skillid (Rskillid
skilllv (Rskilllv)
movedata (2.Cmd.MoveDataRmovedata 
mainskillid (Rmainskillid"•
BattleObjectData
effectid (Reffectid
	time_axis (RtimeAxis&
eConditionType (ReConditionType 
eResultType (ReResultType"ª
BattleObjectEffectUserCmd
charid (Rcharid
skillid (Rskillid
skilllv (RskilllvA
battleObjectdata (2.Cmd.BattleObjectDataRbattleObjectdata"î
DamageEffectUserCmd
charid (Rcharid
skillid (Rskillid
skilllv (Rskilllv
	timestamp (R	timestamp/

damagedata (2.Cmd.DamageDataR
damagedata 
mainskillid (Rmainskillid
uniqueid (Runiqueid"T
MissileTarget
charid (Rcharid+
	targetpos (2.Cmd.ScenePosR	targetpos"‚
MissileData
effectid (Reffectid
	time_axis (RtimeAxis:
missiletargets (2.Cmd.MissileTargetRmissiletargets"–
MissileEffectUserCmd
charid (Rcharid
skillid (Rskillid
skilllv (Rskilllv2
missiledata (2.Cmd.MissileDataRmissiledata"^
SpecialRandActorPosData+
	targetpos (2.Cmd.ScenePosR	targetpos
rotate (Rrotate"3
SpecialSelectByAttrData
targets (Rtargets"¢
SpecialThunderDataA
thunders (2%.Cmd.SpecialThunderData.ThunderTargetRthundersI
ThunderTarget
	thunderid (R	thunderid
targetid (Rtargetid"­
SpecialData
effectid (Reffectid
	time_axis (RtimeAxis
datas (Rdatas8
randdata (2.Cmd.SpecialRandActorPosDataRranddata<

selectdata (2.Cmd.SpecialSelectByAttrDataR
selectdata
	targetids (R	targetids9
thunderdata (2.Cmd.SpecialThunderDataRthunderdata"–
SpecialEffectUserCmd
charid (Rcharid
skillid (Rskillid
skilllv (Rskilllv2
specialdata (2.Cmd.SpecialDataRspecialdata"¸
BuffData
effectid (Reffectid
	time_axis (RtimeAxis
targets (Rtargets+
	targetpos (2.Cmd.ScenePosR	targetpos,
buff_effect_layers (RbuffEffectLayers"Š
BuffEffectUserCmd
charid (Rcharid
skillid (Rskillid
skilllv (Rskilllv)
buffdata (2.Cmd.BuffDataRbuffdata"4
UpdateSkillRandSeedCmd
randseed (Rrandseed"]
SkillResultUserCmd
charid (Rcharid/

damagedata (2.Cmd.DamageDataR
damagedata"ˆ
AnimMoveSyncPosData
charid (Rcharid
pos (2.Cmd.ScenePosRpos
dir (Rdir
moveid (Rmoveid)
state (2.Cmd.EAnimMoveStateRstate
action_name (	R
actionName
action_time (R
actionTime!
motion_scale (RmotionScale"D
AnimMoveSyncPosCmd.
infos (2.Cmd.AnimMoveSyncPosDataRinfos"H
CDTimeUserCmd
guid (Rguid#
list (2.Cmd.CDTimeItemRlist"5
ReliveUserCmd$
type (2.Cmd.EReliveTypeRtype"œ
GoToUserCmd
pos (2.Cmd.ScenePosRpos
charid (Rcharid
isgomap (Risgomap
rotate (Rrotate"
type (2.Cmd.GoMapTypeRtype"*
GoToExitPosUserCmd
mapid (Rmapid"&
CVisitNpcUserCmd
guid (Rguid"N
RetVisitNpcUserCmd
guid (Rguid$
shiplocaltalk (Rshiplocaltalk"*
CStopVisitNpcUserCmd
guid (Rguid",
RetStopVisitNpcUserCmd
guid (Rguid"°
SShowDialogUserCmd
guid (Rguid
dialogid (Rdialogid
type (Rtype
text (	Rtext
emoji (Remoji
action (	Raction
voice	 (	Rvoice",
ChoosePartnerUserCmd
index (Rindex"P
TeamMemberData
index (Rindex
cfgid (Rcfgid
guid (Rguid"t
TeamDataCmd
charid (Rcharid+
member (2.Cmd.TeamMemberDataRmember 
leaderindex (Rleaderindex"~
SetTeamUserCmd2
member (2.Cmd.SetTeamUserCmd.MemberRmember8
Member
index (Rindex
fighter (Rfighter"l
	LayerData
id (Rid
time (Rtime
pos (2.Cmd.ScenePosRpos
targetid (Rtargetid"Ü

BufferData
id (Rid
layer (Rlayer
time (Rtime
active (Ractive
fromname (	Rfromname
fromid (Rfromid
level (Rlevel,
	layerdata (2.Cmd.LayerDataR	layerdata 
fromskillid	 (Rfromskillid&
fromeffecttime
 (Rfromeffecttime&
shielddefvalue (Rshielddefvalue
hide (Rhide"h
UserBuffNineSyncCmd
guid (Rguid)
updates (2.Cmd.BufferDataRupdates
dels (Rdels"µ
UserActionNineSyncCmd
guid (Rguid
actionid (Ractionid
looptime (Rlooptime0

actiontype (2.Cmd.EActionTypeR
actiontype
force (Rforce
	isprivate (R	isprivate
islookat	 (Rislookat
isbase
 (Risbase
isstop (Risstop

actionname (	R
actionname"å
UserExpressionNineSyncCmd
guid (Rguid&
expressionname (	Rexpressionname
looptime (Rlooptime$
type (2.Cmd.EActionTypeRtype
force (Rforce
	isprivate (R	isprivate
isstop	 (Risstop"ä
UserMouthNineSyncCmd
guid (Rguid
idleid (Ridleid 
mouthaction (	Rmouthaction&
mouthactionend (Rmouthactionend
looptime (Rlooptime$
type (2.Cmd.EActionTypeRtype
force (Rforce"m
UserShowBubbleCmd
guid (Rguid
name (	Rname
lasttime (Rlasttime
force (Rforce"Æ
UserEffectNineSyncCmd
pos (2.Cmd.ScenePosRpos
guid (Rguid
name (	Rname

attachname (	R
attachname
looptime (Rlooptime
isstop (Risstop
dir	 (Rdir"“
UserSoundNineSyncCmd
pos (2.Cmd.ScenePosRpos
guid (Rguid
name (	Rname
looptime (Rlooptime
isstop (Risstop"L
NotifyHideCloseUserCmd
guid (Rguid

closeguids (R
closeguids"*
UnlockingMenuCmd
menuID (RmenuID"€
UnlockedMenuDataCmd#
type (2.Cmd.EMenuEventRtype 
unlockedIDs (RunlockedIDs"
unlockedstrs (	Runlockedstrs"1
ReqMapLinkUserCmd
	maplinkid (R	maplinkid"l
BroadCastMapLinkUserCmd
	maplinkid (R	maplinkid
guid (Rguid
pos (2.Cmd.ScenePosRpos"$
GoMapUserCmd
mapid (Rmapid"á
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
giftids (Rgiftids"-
UserUseUniqueSkillCmd
index (Rindex"
WeatherChange
id (Rid
	direction (R	direction(
strengthcurveid (Rstrengthcurveid
inquest (Rinquest"*
CBossShowUpFinishCmd
guid (Rguid"x
ShakeScreenCmd
	curvename (	R	curvename
scale (Rscale
lasttime (Rlasttime
isstop (Risstop"µ
NpcPlayDialog
guid (Rguid
id (Rid
lasttime (Rlasttime

openrandom (R
openrandom"
intervaltime (Rintervaltime 
talkContent (	RtalkContent"×
InteractionWithEntryCmd
guid (Rguid
beguid (Rbeguid
	entrytype (R	entrytype5
opertype (2.Cmd.EInteractiveOperTypeRopertype
tgtid (Rtgtid%
tgtpos (2.Cmd.ScenePosRtgtpos"±
InteractionCmd
guid (Rguid
beguid (Rbeguid
socketid (Rsocketid
opertype (	Ropertype
tgtid (Rtgtid%
tgtpos (2.Cmd.ScenePosRtgtpos"Z
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
pos (2.Cmd.ScenePosRpos"w
PutDownResultCmd
guid (Rguid
beguid (Rbeguid
result (Rresult
pos (2.Cmd.ScenePosRpos"+
ThrowCmd
pos (2.Cmd.ScenePosRpos"u
ThrowResultCmd
guid (Rguid
beguid (Rbeguid
result (Rresult
pos (2.Cmd.ScenePosRpos".
CatapultCmd
pos (2.Cmd.ScenePosRpos"W
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
OffVehicleCmd
pos (2.Cmd.ScenePosRpos"z
OffVehicleResultCmd
guid (Rguid
beguid (Rbeguid
result (Rresult
pos (2.Cmd.ScenePosRpos"X
InteractionEventCmd
beguid (Rbeguid)
type (2.Cmd.EInteractionTypeRtype"2
ChatMsgClientToGateCmd
content (Rcontent"2
ChatMsgGateToClientCmd
content (Rcontent"ª
MiniMapsInfoCmdE
minimapinfo (2#.Cmd.MiniMapsInfoCmd.OneMiniMapInfoRminimapinfoP
OneMiniMapInfo
mapid (Rmapid(
npcicons (2.Cmd.NpcIconRnpcicons"P

LotteryCmd
type (Rtype
times (Rtimes
batchid (Rbatchid"Þ
SendLotteryResultCmdO
lotteryresults (2'.Cmd.SendLotteryResultCmd.LotteryResultRlotteryresultsu
LotteryResult
itemid (Ritemid
	itemcount (R	itemcount
type (Rtype
brandnew (Rbrandnew"û
SendGMLotteryResultCmdQ
lotteryresults (2).Cmd.SendGMLotteryResultCmd.LotteryResultRlotteryresults
LotteryResult
itemid (Ritemid
times (Rtimes

convertnum (R
convertnum
type (Rtype
brandnew (Rbrandnew"F
UserSpecialActionCmd
beguid (Rbeguid
action (Raction"’
AsideUserCmd
npcid (Rnpcid
textid (Rtextid
showtime (Rshowtime8
orientation (2.Cmd.EAsideOrientationRorientation"m
SendPartnerSourceCmd
	partnerid (R	partnerid7

sourcetype (2.Cmd.EPartnerSourceTypeR
sourcetype"@
SceneRaidResultCmd
rank (Rrank
result (Rresult"€
C2SBuffSyncCmd
charid (Rcharid
buffid (Rbuffid
active (Ractive&
shielddefvalue (Rshielddefvalue"(
AcceptRepairTask
cfgid (Rcfgid"Š
AddPartnerExpFromExpPoolCmd
	fighterid (R	fighterid
expvalue (Rexpvalue1
result (2.Cmd.EAddPartnerExpResultRresult"+
PlayItemAnimation
itemid (Ritemid"–
WXKJAsideUserCmd
npcid (Rnpcid
textid (Rtextid
showtime (Rshowtime8
orientation (2.Cmd.EAsideOrientationRorientation"x
BlackSanCmd
guid (Rguid
start (Rstart%
hitpos (2.Cmd.ScenePosRhitpos
skillid (Rskillid"»
GoToCommonTraceCmd
id (Rid$
clientrequest (Rclientrequest"
serveranswer (Rserveranswer
pos (2.Cmd.ScenePosRpos
type (Rtype
strkey (	Rstrkey"Ñ
SummonEffectUserCmd
charid (Rcharid
skillid (Rskillid
skilllv (Rskilllv
effectid (Reffectid
	time_axis (RtimeAxis
pos (2.Cmd.ScenePosRpos
index (Rindex"?
ClubChallengeInfo
level (Rlevel
npcid (Rnpcid"‰
DailyActivityInfo
id (Rid 
characterid (Rcharacterid
endtime (Rendtime
status (Rstatus
uid (Ruid"è
LeagueActivity
id (Rid
endtime (Rendtime
status (Rstatus"
refreshfield (Rrefreshfield
level (Rlevel2
clubInfo (2.Cmd.ClubChallengeInfoRclubInfo
uid (Ruid
alias (	Ralias"î
ActiveDatingInfo
id (Rid 
characterid (Rcharacterid
endtime (Rendtime
status (Rstatus"
refreshfield (Rrefreshfield
uid (Ruid
fvalue (Rfvalue
type (Rtype
alias	 (	Ralias"ª
DailyActivityCmd<
dailyactivity (2.Cmd.DailyActivityInfoRdailyactivity;
leagueactivity (2.Cmd.LeagueActivityRleagueactivity2
nextQuestRefreshTime (RnextQuestRefreshTime9
activedating (2.Cmd.ActiveDatingInfoRactivedating,
allcompletestatus (Rallcompletestatus")
DailyActivityAwardCmd
uid (Ruid"r
ClubChallengeCGCmd
cg (	Rcg
showid1 (Rshowid1
showid2 (Rshowid2
showid3 (Rshowid3"
DailyActivityCompleteAwardCmd"<
WeakSyncSwitchCmd'
weaksync_switch (RweaksyncSwitch"B
RootMotionSwitchCmd+
rootmotion_switch (RrootmotionSwitch"G
StressTestResponseCmd
ret (Rret
	timestamp (R	timestamp"C
SetRobotCmd
set (Rset"
isplayerwalk (Risplayerwalk"c
SyncActionListCmd
guid (Rguid

actionlist (R
actionlist
needloop (Rneedloop",
NpcBubblePerceptionCmd
guid (Rguid*¤
EAttrChangeType
EATTRCHANGETYPE_MIN 
EATTRCHANGETYPE_EQUIP"
EATTRCHANGETYPE_EQUIP_STRENGTH 
EATTRCHANGETYPE_EQUIP_UPSTAR
EATTRCHANGETYPE_MAX*w
ELocalDungeonType
ELOCALDUNGEON_TYPE_NORMAL $
 ELOCALDUNGEON_TYPE_CLUBCHALLENGE
ELOCALDUNGEON_TYPE_REPAIR*¾
ESkillPhaseType
ESKILLPHASE_TYPE_MIN 
ESKILLPHASE_TYPE_CHANT
ESKILLPHASE_TYPE_RUN#
ESKILLPHASE_TYPE_ACCUMULATE_END
ESKILLPHASE_TYPE_CORRECT
ESKILLPHASE_TYPE_END*¹
ESkillBreakType
ESKILLBREAK_TYPE_MIN 
ESKILLBREAK_TYPE_CORRECT
ESKILLBREAK_TYPE_CHANT
ESKILLBREAK_TYPE_RUN
ESKILLBREAK_TYPE_LEADSKILL
ESKILLBREAK_TYPE_MAX*Ó

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
DAMAGE_TYPE_THUNDER
DAMAGE_TYPE_EARTH
DAMAGE_TYPE_CUT
DAMAGE_TYPE_STRIKE
DAMAGE_TYPE_SPIKE
DAMAGE_TYPE_INVINCIBLE
DAMAGE_TYPE_MAX*
EAnimMoveState
EANIMMOVESTATE_MIN 
EANIMMOVESTATE_START
EANIMMOVESTATE_MOVING
EANIMMOVESTATE_END
EANIMMOVESTATE_MAX*Ú
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
EACTIONTYPE_MAX*ê

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
EMENUEVENT_COLLEGE_GIFT 
EMENUEVENT_SKILL_LEVEL_LIMIT 
EMENUEVENT_EQUIP_LEVEL_LIMIT
EMENUEVENT_ELITE_REPAIR
EMENUEVENT_DAILYACTIVITY
EMENUEVENT_MAXN*S
ECgType
ECGTYPE_MIN 
ECGTYPE_NORMAL
ECGTYPE_REPAIR
ECGTYPE_MAX*˜
ECgCameraMode
ECGCAMERAMODE_MIN 
ECGCAMERAMODE_BLANK_SCREEN
ECGCAMERAMODE_TRANSITION
ECGCAMERAMODE_DOWNSHEAR
ECGCAMERAMODE_MAX*ý
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
EINTERACTIVEOPER_TASKTRIGGER
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
EINTERACTIVEOPER_MAX*Ç
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
EINTERACTION_TYPE_CONNECTION	*Î
LotteryType
ELOTTERYTYPE_MIN 
ELOTTERYTYPE_PARTNER
ELOTTERYTYPE_EQUIP
ELOTTERYTYPE_MIX
ELOTTERYTYPE_GMZ
ELOTTERYTYPE_GM_PARTNER[
ELOTTERYTYPE_GM_EQUIP\
ELLOTERYTYPE_MAXd*
EAsideOrientation
EASIDEORIENTATION_MIN 
EASIDEORIENTATION_UP
EASIDEORIENTATION_MIDDLE
EASIDEORIENTATION_DOWN
EASIDEORIENTATION_MAX*á
EPartnerSourceType
EPARTNERSOURCETYPE_MIN 
EPARTNERSOURCETYPE_LOTTERY
EPARTNERSOURCETYPE_ITEM
EPARTNERSOURCETYPE_NONE
EPARTNERSOURCETYPE_GM
EPARTNERSOURCETYPE_MISSION
EPARTNERSOURCETYPE_MAXc*•
EAddPartnerExpResult
EADDPARTNEREXPRESULT_MIN *
&EADDPARTNEREXPRESULT_INVALID_FIGHTERID$
 EADDPARTNEREXPRESULT_ADD_FAILURE#
EADDPARTNEREXPRESULT_NOT_ENOUGH(
$EADDPARTNEREXPRESULT_IS_MAIN_FIGHTER 
EADDPARTNEREXPRESULT_SUCCESS
EADDPARTNEREXPRESULT_MAX* 
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
GOTO_NPCALIAS*w
DailyActivityState
DAILYACTIVITY_INIT 
DAILYACTIVITY_OPEN
DAILYACTIVITY_COMPLETE
DAILYACTIVITY_END*Š
DailyActivityRewardType
DAILYACTIVITY_TYPE_NONE 
DAILYACTIVITY_TYPE_PROP
DAILYACTIVITY_TYPE_LEVEL
DAILYACTIVITY_TYPE_SKILL
DAILYACTIVITY_TYPE_BIGSKILL
DAILYACTIVITY_TYPE_ELITE
DAILYACTIVITY_TYPE_GOLD
DAILYACTIVITY_TYPE_DATING*²
DailyActivityPropRewardType
DAILYACTIVITY_PROP_MAXHP 
DAILYACTIVITY_PROP_ATK
DAILYACTIVITY_PROP_DEF
DAILYACTIVITY_PROP_MDEF 
DAILYACTIVITY_PROP_HPRECOVER*š
DailyActivityType
DAILYACTIVITY_TYPE &
"LEAGUEACTIVITY_TYPE_CHALLENGE_LEFT'
#LEAGUEACTIVITY_TYPE_CHALLENGE_RIGHT
LEAGUEACTIVITY_TYPE_WXKJ*¡
DailyActivityErrorType
DAILYACTIVITY_ERROR_NONE !
DAILYACTIVITY_ERROR_NOT_EXIST 
DAILYACTIVITY_ERROR_NOT_OPEN$
 DAILYACTIVITY_ERROR_NOT_COMPLETEBZ.;Cmdbproto3