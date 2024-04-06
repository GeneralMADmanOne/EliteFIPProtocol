using System;
using System.Text.Json;

namespace EliteFIPProtocol
{
    public class RefuelAllData
    {
        public DateTime Timestamp { get; set; }
        public string Event { get; set; }
        public long Cost { get; set; }      
        public double Amount { get; set; }

        public static FIPPacket CreateFIPPacket(RefuelAllData refuelAllData)
        {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.RefuelAll.ToString();
            gameData.Data = JsonSerializer.Serialize(refuelAllData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }
    }
}
