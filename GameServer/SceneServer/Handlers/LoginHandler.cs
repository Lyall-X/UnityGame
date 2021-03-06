using log4net;
using Server.Handler;
using Server;
using GameLibs.SceneServer.Defines;
using GameLibs.SceneServer.Model;
using PbUser;
using Common.Utility;
using Common.Define;
using Common.Data;

namespace GameLibs.SceneServer.Handlers
{
    public class LoginHandler : BaseHandler
    {
        private static readonly ILog logger = LogManager.GetLogger(AppServer.repository.Name, typeof(LoginHandler));

        public override void OnMessage(ClientPeer peer, byte[] bytes)
        {
            var person = ReqLogin.Parser.ParseFrom(bytes);

            var resData = new ResLogin();
            resData.Result = PbCommon.ResultCode.Failed;
            var userModel = modelMgr.GetModel(ModelNames.User) as UserModel;
            if (userModel != null)
            {
                var uid = AppUtil.NewGuidId();
                //var uid = userModel.ExistUser(person.Name, person.Pass);
                resData.Result = PbCommon.ResultCode.Success;
                resData.Userinfo = new PbCommon.UserInfo()
                {
                    Name = person.Name,
                    Money = 10000,
                    Userid = uid.ToString(),
                };
            }
            netMgr.SendData(peer, ProtoType.LuaProtoMsg, Protocal.ResLogin, resData);

            logger.Info(person.Name + " " + person.Pass);
        }
    }
}
