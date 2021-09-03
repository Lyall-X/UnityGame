// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: SysMsg.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cmd {

  /// <summary>Holder for reflection information generated from SysMsg.proto</summary>
  public static partial class SysMsgReflection {

    #region Descriptor
    /// <summary>File descriptor for SysMsg.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SysMsgReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxTeXNNc2cucHJvdG8SA0NtZCrCAwoJRVN5c01zZ0lEEhUKEUVTWVNURU1N",
            "U0dfSURfTUlOEAASKgomRVNZU1RFTU1TR19JRF9QQUNLX05PU1RPUkVBR0Vf",
            "V0lUSENBUkQQJRIlCiFFU1lTVEVNTVNHX0lEX01BSUxfQUNDT1VOVF9BVFRB",
            "Q0gQLhIfChpFU1lTVEVNTVNHX0lEX0NIQVRfT0ZGTElORRCmAxIcChdFU1lT",
            "VEVNTVNHX0lEX05BTUVFTVBUWRDuBxIgChtFU1lTVEVNTVNHX0lEX0dVSUxE",
            "X05BTUVMRU4Q7wcSIgodRVNZU1RFTU1TR19JRF9HVUlMRF9OQU1FRU1QVFkQ",
            "qxQSJAofRVNZU1RFTU1TR19JRF9HVUlMRF9OQU1FSU5WQUxJRBCsFBIeChlF",
            "U1lTVEVNTVNHX0lEX1FVRVJZX0NMT1NFENcGEiIKHUVTWVNURU1NU0dfSURf",
            "UVVFUllfTk9fRlJJRU5EENkGEhwKF0VTWVNURU1NU0dfSURfUEFDS19GVUxM",
            "EJ0YEh4KGEVTWVNURU1NU0dfSURfREVCVF9MT0dJThCIpAESHgoYRVNZU1RF",
            "TU1TR19JRF9ERUJUX1NUQVJUEImkAUIHWgUuO0NtZGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Cmd.ESysMsgID), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ESysMsgID {
    [pbr::OriginalName("ESYSTEMMSG_ID_MIN")] EsystemmsgIdMin = 0,
    /// <summary>
    /// 卡片不可放入仓库
    /// </summary>
    [pbr::OriginalName("ESYSTEMMSG_ID_PACK_NOSTOREAGE_WITHCARD")] EsystemmsgIdPackNostoreageWithcard = 37,
    /// <summary>
    /// 邮件已被领取
    /// </summary>
    [pbr::OriginalName("ESYSTEMMSG_ID_MAIL_ACCOUNT_ATTACH")] EsystemmsgIdMailAccountAttach = 46,
    /// <summary>
    /// 聊天对象已离线
    /// </summary>
    [pbr::OriginalName("ESYSTEMMSG_ID_CHAT_OFFLINE")] EsystemmsgIdChatOffline = 422,
    /// <summary>
    /// 名字空
    /// </summary>
    [pbr::OriginalName("ESYSTEMMSG_ID_NAMEEMPTY")] EsystemmsgIdNameempty = 1006,
    /// <summary>
    /// 工会名字长度
    /// </summary>
    [pbr::OriginalName("ESYSTEMMSG_ID_GUILD_NAMELEN")] EsystemmsgIdGuildNamelen = 1007,
    /// <summary>
    /// 工会名字空
    /// </summary>
    [pbr::OriginalName("ESYSTEMMSG_ID_GUILD_NAMEEMPTY")] EsystemmsgIdGuildNameempty = 2603,
    /// <summary>
    /// 工会名字不合法
    /// </summary>
    [pbr::OriginalName("ESYSTEMMSG_ID_GUILD_NAMEINVALID")] EsystemmsgIdGuildNameinvalid = 2604,
    [pbr::OriginalName("ESYSTEMMSG_ID_QUERY_CLOSE")] EsystemmsgIdQueryClose = 855,
    [pbr::OriginalName("ESYSTEMMSG_ID_QUERY_NO_FRIEND")] EsystemmsgIdQueryNoFriend = 857,
    /// <summary>
    /// 背包满
    /// </summary>
    [pbr::OriginalName("ESYSTEMMSG_ID_PACK_FULL")] EsystemmsgIdPackFull = 3101,
    [pbr::OriginalName("ESYSTEMMSG_ID_DEBT_LOGIN")] EsystemmsgIdDebtLogin = 21000,
    [pbr::OriginalName("ESYSTEMMSG_ID_DEBT_START")] EsystemmsgIdDebtStart = 21001,
  }

  #endregion

}

#endregion Designer generated code