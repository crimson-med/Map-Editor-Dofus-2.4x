


















// Generated on 07/24/2016 18:35:56
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class IgnoredGetListMessage : NetworkMessage
{

public const uint Id = 5676;
public uint MessageId
{
    get { return Id; }
}



public IgnoredGetListMessage()
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