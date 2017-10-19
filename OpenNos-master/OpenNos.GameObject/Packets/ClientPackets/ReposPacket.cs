﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core;

namespace OpenNos.GameObject
{
    [PacketHeader("repos")]
    public class ReposPacket : PacketDefinition
    {
        #region Properties        

        [PacketIndex(0)]
        public byte OldSlot { get; set; }

        [PacketIndex(1)]
        public byte Amount { get; set; }

        [PacketIndex(2)]
        public byte NewSlot { get; set; }

        [PacketIndex(3)]
        public bool PartnerBackpack { get; set; }
        #endregion
    }
}