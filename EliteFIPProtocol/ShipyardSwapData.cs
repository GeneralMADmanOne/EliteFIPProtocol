using System;
using System.Text.Json;


namespace EliteFIPProtocol
{
    public class ShipyardSwapData
    {
        public DateTime Timestamp { get; set; }
        public string Event { get; set; }
        public string ShipType { get; set; }
        public string ShipId { get; set; }        
        public string StoreOldShip { get; set; }
        public string StoreShipId { get; set; }
        public string MarketId { get; set; }

        public static FIPPacket CreateFIPPacket(ShipyardSwapData shipyardSwapData)
        {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.ShipyardSwap.ToString();
            gameData.Data = JsonSerializer.Serialize(shipyardSwapData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }
    }
}
