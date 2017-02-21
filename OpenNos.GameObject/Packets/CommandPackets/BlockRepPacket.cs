﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject
{
    [PacketHeader("$BlockRep", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class BlockRepPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public string CharacterName { get; set; }

        [PacketIndex(1)]
        public int Duration { get; set; }

        [PacketIndex(2, SerializeToEnd = true)]
        public string Reason { get; set; }

        public override string ToString()
        {
            return $"BlockRep Command CharacterName: {CharacterName} Duration: {Duration} Reason: {Reason}";
        }

        #endregion
    }
}