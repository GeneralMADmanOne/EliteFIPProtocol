using System;
using System.Text.Json;

namespace EliteFIPProtocol
{
    public class RefuelPartialData
    {
        public DateTime Timestamp { get; set; }
        public string Event { get; set; }
        public long Cost { get; set; }      
        public double Amount { get; set; }

        public static FIPPacket CreateFIPPacket(RefuelPartialData refuelPartialData)
        {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.RefuelPartial.ToString();
            gameData.Data = JsonSerializer.Serialize(refuelPartialData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }
    }
}
