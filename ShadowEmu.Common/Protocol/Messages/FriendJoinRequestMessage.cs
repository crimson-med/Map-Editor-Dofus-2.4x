


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class FriendJoinRequestMessage : NetworkMessage
{

public const uint Id = 5605;
public uint MessageId
{
    get { return Id; }
}

public string name;
        

public FriendJoinRequestMessage()
{
}

public FriendJoinRequestMessage(string name)
        {
            this.name = name;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            

}

public void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            

}


}


}