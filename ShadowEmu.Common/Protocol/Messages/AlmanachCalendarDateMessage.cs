


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class AlmanachCalendarDateMessage : NetworkMessage
{

public const uint Id = 6341;
public uint MessageId
{
    get { return Id; }
}

public int date;
        

public AlmanachCalendarDateMessage()
{
}

public AlmanachCalendarDateMessage(int date)
        {
            this.date = date;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(date);
            

}

public void Deserialize(IDataReader reader)
{

date = reader.ReadInt();
            

}


}


}