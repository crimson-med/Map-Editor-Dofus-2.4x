


















// Generated on 07/24/2016 18:35:58
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class InteractiveUseRequestMessage : NetworkMessage
{

public const uint Id = 5001;
public uint MessageId
{
    get { return Id; }
}

public uint elemId;
        public uint skillInstanceUid;
        

public InteractiveUseRequestMessage()
{
}

public InteractiveUseRequestMessage(uint elemId, uint skillInstanceUid)
        {
            this.elemId = elemId;
            this.skillInstanceUid = skillInstanceUid;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)elemId);
            writer.WriteVarInt((int)skillInstanceUid);
            

}

public void Deserialize(IDataReader reader)
{

elemId = reader.ReadVarUhInt();
            if (elemId < 0)
                throw new System.Exception("Forbidden value on elemId = " + elemId + ", it doesn't respect the following condition : elemId < 0");
            skillInstanceUid = reader.ReadVarUhInt();
            if (skillInstanceUid < 0)
                throw new System.Exception("Forbidden value on skillInstanceUid = " + skillInstanceUid + ", it doesn't respect the following condition : skillInstanceUid < 0");
            

}


}


}