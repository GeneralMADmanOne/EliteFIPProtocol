using System;
using System.Text.Json;

namespace EliteFIPProtocol
{
    public class DockingDeniedData
    {
        public DateTime Timestamp { get; set; }
        public string Event { get; set; }
        public string Reason { get; set; }
        public string MarketId { get; set; }
        public string StationName { get; set; }
        public string StationType { get; set; }

        public static FIPPacket CreateFIPPacket(DockingDeniedData dockingDeniedData)
        {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.DockingDenied.ToString();
            gameData.Data = JsonSerializer.Serialize(dockingDeniedData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }
    }
}
