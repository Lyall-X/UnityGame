
?%
SceneUser2.protoCmdSceneUser.protoProtoCommon.proto	Var.proto" 
MsgParam
param (	Rparam".
SysMsg
id (Rid
param (	Rparam")
CExitPosUserCmd
exitid (Rexitid")
CWorldJumpUserCmd
mapid (Rmapid">
CAskUnlockedMenuListCmd#
type (2.Cmd.EMenuEventRtype",
SUserDataCmd
data (2.Cmd.VarRdata"q
	CatHugCmd(
oper (2.Cmd.ECatInteractionRoper
catguid (Rcatguid 
partnerguid (Rpartnerguid"
TalkInfo
guid (Rguid
talkid (Rtalkid 
talkmessage (	Rtalkmessage%
params (2.Cmd.MsgParamRparams"?
EffectUserCmd0

effecttype (2.Cmd.EEffectTypeR
effecttype
charid (Rcharid
	effectpos (R	effectpos
pos (2.Cmd.ScenePosRpos
effect (	Reffect
msec (Rmsec
times	 (Rtimes
index
 (Rindex!
opt (2.Cmd.EEffectOptRopt
posbind (Rposbind
epbind (Repbind
delay (Rdelay
id (Rid
dir (Rdir"?
SoundEffectCmd
se (	Rse
pos (2.Cmd.ScenePosRpos
msec (Rmsec
times (Rtimes
delay (Rdelay"J
ChangeBgmCmd
bgm (	Rbgm
play (Rplay
times (Rtimes"Y
GameTimeCmd"
opt (2.Cmd.GameTimeOptRopt
sec (Rsec
speed (Rspeed"c
ShakeScreen"
maxamplitude (Rmaxamplitude
msec (Rmsec
	shaketype (R	shaketype"N
FollowerUser
userid (Ruserid&
eType (2.Cmd.EFollowTypeReType"Q
BeFollowUserCmd
userid (Ruserid&
eType (2.Cmd.EFollowTypeReType"c
UpyunUrl#
type (2.Cmd.EAlbumTypeRtype
char_url (	RcharUrl
acc_url (	RaccUrl"@
DownloadSceneryPhotoUserCmd!
urls (2.Cmd.UpyunUrlRurls"5
BuffForeverCmd#
buff (2.Cmd.BufferDataRbuff"?
	MusicItem
charid (Rcharid

demandtime (R
demandtime
mapid (Rmapid
npcid (Rnpcid
musicid (Rmusicid
	starttime (R	starttime
endtime (Rendtime
status (Rstatus
name	 (	Rname"1
ItemImageUserNtfUserCmd
userid (Ruserid"'
ChangeNameUserCmd
name (	Rname"5
UpyunAuthorizationCmd
	authvalue (	R	authvalue"L
UserRenameCmd
name (	Rname'
code (2.Cmd.ERenameErrCodeRcode":
ChangeUserPosInRapairCmd

repairguid (R
repairguid"?
SendLotteryPoolInfoCmd@
poolinfo (2$.Cmd.SendLotteryPoolInfoCmd.PoolInfoRpoolinfoj
PoolInfo
index (Rindex
	begintime (R	begintime
endtime (Rendtime
MMD (	RmMD"?
WXKJStagesInfoCmd4
info (2 .Cmd.WXKJStagesInfoCmd.StageInfoRinfo
times (Rtimes
	timesTamp (R	timesTamp>
	questinfo (2 .Cmd.WXKJStagesInfoCmd.StageInfoR	questinfo
bufflist (RbufflistJ
	StageInfo
id (Rid-
state (2.Cmd.EWXKJStageScheduleRstate",
WXKJChallengeCmd
questid (Rquestid"8
EliteRepairCmd
npcid (Rnpcid
ret (Rret"F

RedDotInfo
type (Rtype
id (Rid
isadd (Risadd"6
	RedDotCmd)
reddots (2.Cmd.RedDotInfoRreddots"=
RedDotConfirmCmd)
reddots (2.Cmd.RedDotInfoRreddots"?
FavorabilityInfo
	partnerid (R	partnerid
value (Rvalue"
rewardbitmap (Rrewardbitmap"
lastmeettime (Rlastmeettime"^
FavorabilityCmd+
infos (2.Cmd.FavorabilityInfoRinfos

updatetype (R
updatetype"3
WXKJSwitchMaterialCmd
material (	Rmaterial"h
DynamicMoveEffectEndCmd
charid (Rcharid
skillid (Rskillid
	time_axis (RtimeAxis"=
SendReloginServerReqCmd"
reconnectreq (Rreconnectreq*?
EMessageType
EMESSAGETYPE_MIN 
EMESSAGETYPE_FRAME
EMESSAGETYPE_GETITEM
EMESSAGETYPE_TOP
EMESSAGETYPE_REWARD
EMESSAGETYPE_3D
EMESSAGETYPE_CONFIRM 
EMESSAGETYPE_ADDPARTNER?
EMESSAGETYPE_WARN@
EMESSAGETYPE_DEBUG?
EMESSAGETYPE_FINISH?
EMESSAGETYPE_MAX?*Q
EMessageActOpt
EMESSAGEACT_FIRST 
EMESSAGEACT_ADD
EMESSAGEACT_DEL*?
ECatInteraction
ECATINTER_PICKUP 
ECATINTER_PUTDOWN
ECATINTER_PUTDOWN_END
ECATINTER_PICKUP_BROADCAST
ECATINTER_PUTDOWN_BROADCAST*c

EEffectOpt
EEFFECTOPT_FIRST 
EEFFECTOPT_PLAY
EEFFECTOPT_STOP
EEFFECTOPT_DELETE*?
EEffectType
EEFFECTTYPE_FIRST 
EEFFECTTYPE_NORMAL
EEFFECTTYPE_ACCEPTQUEST
EEFFECTTYPE_FINISHQUEST
EEFFECTTYPE_MVPSHOW
EEFFECTTYPE_SCENEEFFECT*U
GameTimeOpt
EGAMETIMEOPT_FIRST 
EGAMETIMEOPT_SYNC
EGAMETIMEOPT_ADJUST*J

EAlbumType
EALBUMTYPE_MIN 
EALBUMTYPE_PHOTO
EALBUMTYPE_MAX*u

EQueryType
EQUERYTYPE_MIN 
EQUERYTYPE_ALL
EQUERYTYPE_FRIEND
EQUERYTYPE_CLOSE
EQUERYTYPE_MAX*K
ERenameErrCode
ERENAME_SUCCESS 

ERENAME_CD
ERENAME_CONFLICT*Y

RedDotType
REDDOTTYPE_NONE 
REDDOTTYPE_NEW_PARTNER
REDDOTTYPE_UNLOCK_MENUBZ.;Cmdbproto3