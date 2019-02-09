


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class ChatSmileyRequestMessage : NetworkMessage
{

public const uint Id = 800;
public uint MessageId
{
    get { return Id; }
}

public uint smileyId;
        

public ChatSmileyRequestMessage()
{
}

public ChatSmileyRequestMessage(uint smileyId)
        {
            this.smileyId = smileyId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)smileyId);
            

}

public void Deserialize(IDataReader reader)
{

smileyId = reader.ReadVarUhShort();
            if (smileyId < 0)
                throw new System.Exception("Forbidden value on smileyId = " + smileyId + ", it doesn't respect the following condition : smileyId < 0");
            

}


}


}