


















// Generated on 07/24/2016 18:35:50
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class MapComplementaryInformationsDataMessage : NetworkMessage
{

public const uint Id = 226;
public uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public int mapId;
        public Types.HouseInformations[] houses;
        public Types.GameRolePlayActorInformations[] actors;
        public Types.InteractiveElement[] interactiveElements;
        public Types.StatedElement[] statedElements;
        public Types.MapObstacle[] obstacles;
        public Types.FightCommonInformations[] fights;
        public bool hasAggressiveMonsters;
        

public MapComplementaryInformationsDataMessage()
{
}

public MapComplementaryInformationsDataMessage(uint subAreaId, int mapId, Types.HouseInformations[] houses, Types.GameRolePlayActorInformations[] actors, Types.InteractiveElement[] interactiveElements, Types.StatedElement[] statedElements, Types.MapObstacle[] obstacles, Types.FightCommonInformations[] fights, bool hasAggressiveMonsters)
        {
            this.subAreaId = subAreaId;
            this.mapId = mapId;
            this.houses = houses;
            this.actors = actors;
            this.interactiveElements = interactiveElements;
            this.statedElements = statedElements;
            this.obstacles = obstacles;
            this.fights = fights;
            this.hasAggressiveMonsters = hasAggressiveMonsters;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteInt(mapId);
            writer.WriteUShort((ushort)houses.Length);
            foreach (var entry in houses)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)actors.Length);
            foreach (var entry in actors)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)interactiveElements.Length);
            foreach (var entry in interactiveElements)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)statedElements.Length);
            foreach (var entry in statedElements)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)obstacles.Length);
            foreach (var entry in obstacles)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)fights.Length);
            foreach (var entry in fights)
            {
                 entry.Serialize(writer);
            }
            writer.WriteBoolean(hasAggressiveMonsters);
            

}

public void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            if (subAreaId < 0)
                throw new System.Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            mapId = reader.ReadInt();
            if (mapId < 0)
                throw new System.Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
            var limit = reader.ReadUShort();
            houses = new Types.HouseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 houses[i] = ProtocolTypeManager.GetInstance<Types.HouseInformations>(reader.ReadShort());
                 houses[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            actors = new Types.GameRolePlayActorInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 actors[i] = ProtocolTypeManager.GetInstance<Types.GameRolePlayActorInformations>(reader.ReadShort());
                 actors[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            interactiveElements = new Types.InteractiveElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 interactiveElements[i] = ProtocolTypeManager.GetInstance<Types.InteractiveElement>(reader.ReadShort());
                 interactiveElements[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            statedElements = new Types.StatedElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 statedElements[i] = new Types.StatedElement();
                 statedElements[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            obstacles = new Types.MapObstacle[limit];
            for (int i = 0; i < limit; i++)
            {
                 obstacles[i] = new Types.MapObstacle();
                 obstacles[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            fights = new Types.FightCommonInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 fights[i] = new Types.FightCommonInformations();
                 fights[i].Deserialize(reader);
            }
            hasAggressiveMonsters = reader.ReadBoolean();
            

}


}


}