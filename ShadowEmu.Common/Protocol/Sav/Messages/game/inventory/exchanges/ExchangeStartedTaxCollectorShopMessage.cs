


















// Generated on 07/24/2016 18:36:00
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class ExchangeStartedTaxCollectorShopMessage : NetworkMessage
{

public const uint Id = 6664;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objects;
        public uint kamas;
        

public ExchangeStartedTaxCollectorShopMessage()
{
}

public ExchangeStartedTaxCollectorShopMessage(Types.ObjectItem[] objects, uint kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarInt((int)kamas);
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            objects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.ObjectItem();
                 objects[i].Deserialize(reader);
            }
            kamas = reader.ReadVarUhInt();
            if (kamas < 0)
                throw new System.Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0");
            

}


}


}