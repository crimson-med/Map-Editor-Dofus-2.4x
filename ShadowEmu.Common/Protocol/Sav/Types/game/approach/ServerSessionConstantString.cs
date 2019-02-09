


















// Generated on 07/24/2016 18:36:05
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Types
{

public class ServerSessionConstantString : ServerSessionConstant
{

public const short Id = 436;
public override short TypeId
{
    get { return Id; }
}

public string value;
        

public ServerSessionConstantString()
{
}

public ServerSessionConstantString(uint id, string value)
         : base(id)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadUTF();
            

}


}


}