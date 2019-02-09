


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class ExchangeBidPriceMessage : NetworkMessage
{

public const uint Id = 5755;
public uint MessageId
{
    get { return Id; }
}

public uint genericId;
        public int averagePrice;
        

public ExchangeBidPriceMessage()
{
}

public ExchangeBidPriceMessage(uint genericId, int averagePrice)
        {
            this.genericId = genericId;
            this.averagePrice = averagePrice;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)genericId);
            writer.WriteVarInt((int)averagePrice);
            

}

public void Deserialize(IDataReader reader)
{

genericId = reader.ReadVarUhShort();
            if (genericId < 0)
                throw new System.Exception("Forbidden value on genericId = " + genericId + ", it doesn't respect the following condition : genericId < 0");
            averagePrice = reader.ReadVarInt();
            

}


}


}