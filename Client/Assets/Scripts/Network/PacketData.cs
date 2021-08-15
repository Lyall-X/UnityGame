using Client.Define;
using LiteNetLib.Utils;

namespace Client.Network
{
    public class PacketData
    {
        public ProtoType protocal;
        public NetDataWriter writer;

        public PacketData() { }

        public void Reset()
        {
            writer = null;
            protocal = ProtoType.CSProtoMsg;
        }
    }
}

