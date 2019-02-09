


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class AchievementRewardErrorMessage : NetworkMessage
{

public const uint Id = 6375;
public uint MessageId
{
    get { return Id; }
}

public short achievementId;
        

public AchievementRewardErrorMessage()
{
}

public AchievementRewardErrorMessage(short achievementId)
        {
            this.achievementId = achievementId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(achievementId);
            

}

public void Deserialize(IDataReader reader)
{

achievementId = reader.ReadShort();
            

}


}


}