


















// Generated on 07/24/2016 18:35:53
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class PartyDeletedMessage : AbstractPartyMessage
{

public const uint Id = 6261;
public uint MessageId
{
    get { return Id; }
}



public PartyDeletedMessage()
{
}

public PartyDeletedMessage(uint partyId)
         : base(partyId)
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