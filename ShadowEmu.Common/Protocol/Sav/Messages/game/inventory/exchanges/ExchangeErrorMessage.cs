


















// Generated on 07/24/2016 18:35:59
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class ExchangeErrorMessage : NetworkMessage
{

public const uint Id = 5513;
public uint MessageId
{
    get { return Id; }
}

public sbyte errorType;
        

public ExchangeErrorMessage()
{
}

public ExchangeErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(errorType);
            

}

public void Deserialize(IDataReader reader)
{

errorType = reader.ReadSByte();
            

}


}


}