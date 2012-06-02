using System;

namespace MCForge.Remote.Packets {
    public class PacketMessage : Packet {
        public PacketMessage(IRemote remote) :base(remote) {
        }

        public override PacketID PacketID {
            get { return Remote.PacketID.Chat; }
        }

        public override void ReadPacket(Networking.PacketData data) {
            throw new NotImplementedException();
        }

        public override Networking.PacketData WritePacket() {
            throw new NotImplementedException();
        }
    }
}

