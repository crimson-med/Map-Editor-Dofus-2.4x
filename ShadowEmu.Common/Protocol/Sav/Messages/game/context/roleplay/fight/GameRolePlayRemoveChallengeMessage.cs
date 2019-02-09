


















// Generated on 07/24/2016 18:35:51
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class GameRolePlayRemoveChallengeMessage : NetworkMessage
{

public const uint Id = 300;
public uint MessageId
{
    get { return Id; }
}

public int fightId;
        

public GameRolePlayRemoveChallengeMessage()
{
}

public GameRolePlayRemoveChallengeMessage(int fightId)
        {
            this.fightId = fightId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(fightId);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadInt();
            

}


}


}