﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject.CommandPackets
{
    [PacketHeader("$Unban", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class UnbanPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public string CharacterName { get; set; }

        public static string ReturnHelp()
        {
            return "$Unban CHARACTERNAME";
        }

        #endregion
    }
}