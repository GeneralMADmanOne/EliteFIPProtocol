using System;
using System.Text.Json;

namespace EliteFIPProtocol
{
    public class ReservoirReplenishedData
    {
        public DateTime Timestamp { get; set; }
        public string Event { get; set; }
        public double FuelMain { get; set; }      
        public double FuelReservoir { get; set; }

        public static FIPPacket CreateFIPPacket(ReservoirReplenishedData reservoirReplenishedData)
        {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.ReservoirReplenished.ToString();
            gameData.Data = JsonSerializer.Serialize(reservoirReplenishedData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }
    }
}
