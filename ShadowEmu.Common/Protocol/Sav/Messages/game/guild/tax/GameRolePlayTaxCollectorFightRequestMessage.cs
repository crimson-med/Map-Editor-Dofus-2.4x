


















// Generated on 07/24/2016 18:35:57
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class GameRolePlayTaxCollectorFightRequestMessage : NetworkMessage
{

public const uint Id = 5954;
public uint MessageId
{
    get { return Id; }
}

public int taxCollectorId;
        

public GameRolePlayTaxCollectorFightRequestMessage()
{
}

public GameRolePlayTaxCollectorFightRequestMessage(int taxCollectorId)
        {
            this.taxCollectorId = taxCollectorId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(taxCollectorId);
            

}

public void Deserialize(IDataReader reader)
{

taxCollectorId = reader.ReadInt();
            

}


}


}