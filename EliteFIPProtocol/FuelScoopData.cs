using System;
using System.Text.Json;

namespace EliteFIPProtocol
{
    public class FuelScoopData
    {
        public DateTime Timestamp { get; set; }
        public string Event { get; set; }
        public double Scooped { get; set; }      
        public double Total { get; set; }

        public static FIPPacket CreateFIPPacket(FuelScoopData fuelScoopData)
        {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.FuelScoop.ToString();
            gameData.Data = JsonSerializer.Serialize(fuelScoopData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }
    }
}
