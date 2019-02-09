


















// Generated on 01/12/2017 03:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class KrosmasterPlayingStatusMessage : NetworkMessage
{

public const uint Id = 6347;
public uint MessageId
{
    get { return Id; }
}

public bool playing;
        

public KrosmasterPlayingStatusMessage()
{
}

public KrosmasterPlayingStatusMessage(bool playing)
        {
            this.playing = playing;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(playing);
            

}

public void Deserialize(IDataReader reader)
{

playing = reader.ReadBoolean();
            

}


}


}