


















// Generated on 07/24/2016 18:35:47
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class CharacterSelectedForceReadyMessage : NetworkMessage
{

public const uint Id = 6072;
public uint MessageId
{
    get { return Id; }
}



public CharacterSelectedForceReadyMessage()
{
}



public void Serialize(IDataWriter writer)
{



}

public void Deserialize(IDataReader reader)
{



}


}


}