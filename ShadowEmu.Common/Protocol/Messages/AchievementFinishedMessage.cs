


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class AchievementFinishedMessage : NetworkMessage
{

public const uint Id = 6208;
public uint MessageId
{
    get { return Id; }
}

public uint id;
        public byte finishedlevel;
        

public AchievementFinishedMessage()
{
}

public AchievementFinishedMessage(uint id, byte finishedlevel)
        {
            this.id = id;
            this.finishedlevel = finishedlevel;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)id);
            writer.WriteByte(finishedlevel);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhShort();
            if (id < 0)
                throw new System.Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            finishedlevel = reader.ReadByte();
            if (finishedlevel < 0 || finishedlevel > 206)
                throw new System.Exception("Forbidden value on finishedlevel = " + finishedlevel + ", it doesn't respect the following condition : finishedlevel < 0 || finishedlevel > 206");
            

}


}


}