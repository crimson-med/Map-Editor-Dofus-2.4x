


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class PartyInvitationDetailsRequestMessage : AbstractPartyMessage
{

public const uint Id = 6264;
public uint MessageId
{
    get { return Id; }
}



public PartyInvitationDetailsRequestMessage()
{
}

public PartyInvitationDetailsRequestMessage(uint partyId)
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