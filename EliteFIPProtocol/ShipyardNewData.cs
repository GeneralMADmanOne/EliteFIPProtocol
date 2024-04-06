using System;
using System.Text.Json;

namespace EliteFIPProtocol
{
    public class ShipyardNewData
    {
        public DateTime Timestamp { get; set; }
        public string Event { get; set; }
        public string ShipType { get; set; }
        public string NewShipId { get; set; }
        

        public static FIPPacket CreateFIPPacket(ShipyardNewData shipyardNewData)
        {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.ShipyardNew.ToString();
            gameData.Data = JsonSerializer.Serialize(shipyardNewData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }
    }
}
