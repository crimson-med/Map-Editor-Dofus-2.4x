


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class GameCautiousMapMovementMessage : GameMapMovementMessage
{

public const uint Id = 6497;
public uint MessageId
{
    get { return Id; }
}



public GameCautiousMapMovementMessage()
{
}

public GameCautiousMapMovementMessage(short[] keyMovements, double actorId)
         : base(keyMovements, actorId)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}