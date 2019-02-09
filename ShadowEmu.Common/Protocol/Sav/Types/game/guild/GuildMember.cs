


















// Generated on 07/24/2016 18:36:08
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Types
{

public class GuildMember : CharacterMinimalInformations
{

public const short Id = 88;
public override short TypeId
{
    get { return Id; }
}

public sbyte breed;
        public bool sex;
        public uint rank;
        public double givenExperience;
        public sbyte experienceGivenPercent;
        public uint rights;
        public sbyte connected;
        public sbyte alignmentSide;
        public ushort hoursSinceLastConnection;
        public uint moodSmileyId;
        public int accountId;
        public int achievementPoints;
        public Types.PlayerStatus status;
        

public GuildMember()
{
}

public GuildMember(double id, string name, byte level, sbyte breed, bool sex, uint rank, double givenExperience, sbyte experienceGivenPercent, uint rights, sbyte connected, sbyte alignmentSide, ushort hoursSinceLastConnection, uint moodSmileyId, int accountId, int achievementPoints, Types.PlayerStatus status)
         : base(id, name, level)
        {
            this.breed = breed;
            this.sex = sex;
            this.rank = rank;
            this.givenExperience = givenExperience;
            this.experienceGivenPercent = experienceGivenPercent;
            this.rights = rights;
            this.connected = connected;
            this.alignmentSide = alignmentSide;
            this.hoursSinceLastConnection = hoursSinceLastConnection;
            this.moodSmileyId = moodSmileyId;
            this.accountId = accountId;
            this.achievementPoints = achievementPoints;
            this.status = status;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteVarShort((int)rank);
            writer.WriteVarLong(givenExperience);
            writer.WriteSByte(experienceGivenPercent);
            writer.WriteVarInt((int)rights);
            writer.WriteSByte(connected);
            writer.WriteSByte(alignmentSide);
            writer.WriteUShort(hoursSinceLastConnection);
            writer.WriteVarShort((int)moodSmileyId);
            writer.WriteInt(accountId);
            writer.WriteInt(achievementPoints);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            rank = reader.ReadVarUhShort();
            if (rank < 0)
                throw new System.Exception("Forbidden value on rank = " + rank + ", it doesn't respect the following condition : rank < 0");
            givenExperience = reader.ReadVarUhLong();
            if (givenExperience < 0 || givenExperience > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on givenExperience = " + givenExperience + ", it doesn't respect the following condition : givenExperience < 0 || givenExperience > 9.007199254740992E15");
            experienceGivenPercent = reader.ReadSByte();
            if (experienceGivenPercent < 0 || experienceGivenPercent > 100)
                throw new System.Exception("Forbidden value on experienceGivenPercent = " + experienceGivenPercent + ", it doesn't respect the following condition : experienceGivenPercent < 0 || experienceGivenPercent > 100");
            rights = reader.ReadVarUhInt();
            if (rights < 0)
                throw new System.Exception("Forbidden value on rights = " + rights + ", it doesn't respect the following condition : rights < 0");
            connected = reader.ReadSByte();
            if (connected < 0)
                throw new System.Exception("Forbidden value on connected = " + connected + ", it doesn't respect the following condition : connected < 0");
            alignmentSide = reader.ReadSByte();
            hoursSinceLastConnection = reader.ReadUShort();
            if (hoursSinceLastConnection < 0 || hoursSinceLastConnection > 65535)
                throw new System.Exception("Forbidden value on hoursSinceLastConnection = " + hoursSinceLastConnection + ", it doesn't respect the following condition : hoursSinceLastConnection < 0 || hoursSinceLastConnection > 65535");
            moodSmileyId = reader.ReadVarUhShort();
            if (moodSmileyId < 0)
                throw new System.Exception("Forbidden value on moodSmileyId = " + moodSmileyId + ", it doesn't respect the following condition : moodSmileyId < 0");
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new System.Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            achievementPoints = reader.ReadInt();
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadShort());
            status.Deserialize(reader);
            

}


}


}