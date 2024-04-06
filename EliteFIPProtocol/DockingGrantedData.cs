using System;
using System.Text.Json;

namespace EliteFIPProtocol
{
    public class DockingGrantedData
    {
        public DateTime Timestamp { get; set; }
        public string Event { get; set; }
        public long LandingPad { get; set; }
        public string MarketId { get; set; }
        public string StationName { get; set; }
        public string StationType { get; set; }

        public static FIPPacket CreateFIPPacket(DockingGrantedData dockingGrantedData)
        {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.DockingGranted.ToString();
            gameData.Data = JsonSerializer.Serialize(dockingGrantedData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }
    }
}
