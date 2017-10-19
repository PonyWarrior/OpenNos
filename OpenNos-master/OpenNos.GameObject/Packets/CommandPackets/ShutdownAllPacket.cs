﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject.CommandPackets
{
    [PacketHeader("$ShutdownAll", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class ShutdownAllPacket : PacketDefinition
    {

        [PacketIndex(0)]
        public string WorldGroup { get; set; }

        public static string ReturnHelp()
        {
            return "$ShutdownAll WORLDGROUP(*)";
        }

        public override string ToString()
        {
            return $"ShutdownAll Command WorldGroup: {WorldGroup}";
        }

    }
}