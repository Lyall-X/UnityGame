
?$
SceneQuest.protoCmdProtoCommon.protoProtoItemCommon.proto"L
ClientEventCmd
func (	Rfunc&
args (2.Cmd.TemplateValueRargs"T
ClientEventCallbackCmd
func (	Rfunc&
args (2.Cmd.TemplateValueRargs"\
QuestVar
name (	Rname
valueint (Rvalueint 
valuestring (	Rvaluestring"?
QuestTraceInfo
trace (	Rtrace
mapid (Rmapid
pos (2.Cmd.ScenePosRpos
npcid (Rnpcid
	tracename (	R	tracename

npcgroupid (R
npcgroupid
alias (	Ralias$
showquestmenu (Rshowquestmenu

showheadui	 (R
showheadui

shownavbar
 (R
shownavbar
	spawnerid (	R	spawnerid"
Abandon_SignData
npcid (Rnpcid

npcgroupid (R
npcgroupid
pos (2.Cmd.ScenePosRpos
mapid (Rmapid"?
	QuestInfo
id (Rid
var (2.Cmd.QuestVarRvar)
trace (2.Cmd.QuestTraceInfoRtrace

createtime (R
createtime;
groupquestinfo (2.Cmd.GroupQuestInfoRgroupquestinfo@
Abandon_signdata	 (2.Cmd.Abandon_SignDataRabandonSigndata

tracecount
 (R
tracecount
	preloadcg (	R	preloadcg"<
QuestListCmd,
	questinfo (2.Cmd.QuestInfoR	questinfo"E
AddQuestCmd
show (Rshow"
info (2.Cmd.QuestInfoRinfo"'
DelQuestCmd
questid (Rquestid"4
UpdateQuestCmd"
info (2.Cmd.QuestInfoRinfo"Y
QuestNodeInfo
nodeid (	Rnodeid0
	childnode (2.Cmd.QuestNodeInfoR	childnode"S
QuestProgress
questid (Rquestid(
nodes (2.Cmd.QuestNodeInfoRnodes"q
SyncQuestProgressCmd-
synctype (2.Cmd.SyncDataTypeRsynctype*
quests (2.Cmd.QuestProgressRquests"N
UpdateVarQuestCmd
questid (Rquestid
var (2.Cmd.QuestVarRvar"o
ShowRewardOnDialog#
items (2.Cmd.ItemInfoRitems
words (	Rwords

showatonce (R
showatonce"z
GroupQuestInfo$
finishedcount (Rfinishedcount
allcount (Rallcount
name (	Rname
icon (	Ricon"w
ShowQuestCmd;
groupquestinfo (2.Cmd.GroupQuestInfoRgroupquestinfo
questid (Rquestid
add (Radd"-
GetRewardQuestCmd
questid (Rquestid"?
QuestListDialogCmd5
quests (2.Cmd.QuestListDialogCmd.QuestRquests
npcname (	Rnpcname
text (	Rtext5
events (2.Cmd.QuestListDialogCmd.EventRevents]
Quest
id (Rid
name (	Rname
flag (Rflag
	groupname (	R	groupnameK
Event
id (Rid
name (	Rname

dlgtextkey (R
dlgtextkey"K
RetQuestListDialogCmd
questid (Rquestid
eventid (Reventid"?
QuestPositionTrace
questid (Rquestid
npcid (Rnpcid

npcgroupid (R
npcgroupid)
location (2.Cmd.ScenePosRlocation
mapid (Rmapid#
flag (2.Cmd.EQuestFlagRflag"\
QuestPositionTraceListCmd?
questtraceinfo (2.Cmd.QuestPositionTraceRquesttraceinfo"S
SetQuestFilterCmd

openfilter (R
openfilter

filtername (	R
filtername"1
AddStageCmd"
info (2.Cmd.QuestInfoRinfo"'
DelStageCmd
questid (Rquestid"4
UpdateStageCmd"
info (2.Cmd.QuestInfoRinfo"N
UpdateVarStageCmd
questid (Rquestid
var (2.Cmd.QuestVarRvar"W
StageCountDownCmd
id (	Rid
lefttime (Rlefttime
status (Rstatus"/
CloseStarGuideCmd
questids (Rquestids"t
SendQuestNodesData
str_questid (	R
strQuestid
int_questid (R
intQuestid
	nodedatas (	R	nodedatas"?
ClientNodeCallbackCmd
str_questid (	R
strQuestid
int_questid (R
intQuestid
nodeid (	Rnodeid
result (Rresult"p
ClientStoryChooseCmd
questid (Rquestid
nodeid (	Rnodeid&
selectednodeid (	Rselectednodeid"?
QuestFinishDataH
questfinished (2".Cmd.QuestFinishData.QuestFinishedRquestfinishedI
QuestFinished
questid (Rquestid

finishtime (R
finishtime"I
SetUserCanMoveCmd
lasttime (Rlasttime
canmove (Rcanmove"
ChangeWXKJAuraCmd"L
UpdateQuestVarCmd
nodeid (	Rnodeid
var (2.Cmd.QuestVarRvar*Y
SyncDataType
SYNC_DATA_TYPE_ALL 
SYNC_DATA_TYPE_ADD
SYNC_DATA_TYPE_REMOVE*?
QuestTitleFlag
QUEST_TITLE_FLAG_NORMAL 
QUEST_TITLE_FLAG_ACCEPTABLE
QUEST_TITLE_FLAG_SUBMIT
QUEST_TITLE_FLAG_REPAIR*?
TimeEventStatusType
TIMEEVENT_STATUS_MIN 
TIMEEVENT_STATUS_START
TIMEEVENT_STATUS_PAUSE
TIMEEVENT_STATUS_END
TIMEEVENT_STATUS_MAX*?
QuestNpcSrouceType
QUEST_SROUCE_TYPE 
DAILYACTIVITY_SROUCE_TYPE
CLUBCHALLENGE_SROUCE_TYPE
DYNCIMACSTAGE_SROUCE_TYPE!
ACTIVEDATINGTRANS_SROUCE_TYPE
ACTIVEDATING_SROUCE_TYPE
WXKJ_SROUCE_TYPE"
CLUBCHALLENGE_COPY_SROUCE_TYPEBZ.;Cmdbproto3