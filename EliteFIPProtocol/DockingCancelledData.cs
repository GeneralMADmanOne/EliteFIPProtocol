using System;
using System.Text.Json;

namespace EliteFIPProtocol
{
    public class DockingCancelledData
    {
        public DateTime Timestamp { get; set; }
        public string Event { get; set; }
        public string MarketId { get; set; }
        public string StationName { get; set; }
        public string StationType { get; set; }

        public static FIPPacket CreateFIPPacket(DockingCancelledData dockingCancelledData)
        {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.DockingCancelled.ToString();
            gameData.Data = JsonSerializer.Serialize(dockingCancelledData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }
    }
}
