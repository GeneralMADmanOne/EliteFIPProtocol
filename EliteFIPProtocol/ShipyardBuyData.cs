using System;
using System.Text.Json;

namespace EliteFIPProtocol
{
    public class ShipyardBuyData
    {
        public DateTime Timestamp { get; set; }
        public string Event { get; set; }
        public string ShipType { get; set; }        
        public long ShipPrice { get; set; }        
        public string StoreOldShip { get; set; }       
        public string StoreShipId { get; set; }        
        public string MarketId { get; set; }
        public string SellOldShip { get; set; }        
        public string SellShipID { get; set; }
        public int SellPrice { get; set; }

        public static FIPPacket CreateFIPPacket(ShipyardBuyData shipyardBuyData)
        {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.ShipyardBuy.ToString();
            gameData.Data = JsonSerializer.Serialize(shipyardBuyData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }
    }
}
