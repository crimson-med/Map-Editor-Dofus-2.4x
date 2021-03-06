


















// Generated on 07/24/2016 18:35:56
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class LeaveDialogMessage : NetworkMessage
{

public const uint Id = 5502;
public uint MessageId
{
    get { return Id; }
}

public sbyte dialogType;
        

public LeaveDialogMessage()
{
}

public LeaveDialogMessage(sbyte dialogType)
        {
            this.dialogType = dialogType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(dialogType);
            

}

public void Deserialize(IDataReader reader)
{

dialogType = reader.ReadSByte();
            if (dialogType < 0)
                throw new System.Exception("Forbidden value on dialogType = " + dialogType + ", it doesn't respect the following condition : dialogType < 0");
            

}


}


}