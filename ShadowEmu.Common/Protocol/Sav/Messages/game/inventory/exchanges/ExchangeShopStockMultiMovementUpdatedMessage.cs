


















// Generated on 07/24/2016 18:36:00
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class ExchangeShopStockMultiMovementUpdatedMessage : NetworkMessage
{

public const uint Id = 6038;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemToSell[] objectInfoList;
        

public ExchangeShopStockMultiMovementUpdatedMessage()
{
}

public ExchangeShopStockMultiMovementUpdatedMessage(Types.ObjectItemToSell[] objectInfoList)
        {
            this.objectInfoList = objectInfoList;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)objectInfoList.Length);
            foreach (var entry in objectInfoList)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            objectInfoList = new Types.ObjectItemToSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectInfoList[i] = new Types.ObjectItemToSell();
                 objectInfoList[i].Deserialize(reader);
            }
            

}


}


}