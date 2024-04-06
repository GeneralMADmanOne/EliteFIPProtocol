using System;
using System.Text.Json;

namespace EliteFIPProtocol {
    public class LoadGameData {
        
        public DateTime Timestamp { get; set; }

        
        public string Event { get; set; }

        
        public string Fid { get; set; }

        
        public string Commander { get; set; }

        
        public bool HasHorizons { get; set; }

        
        public bool HasOdyssey { get; set; }

        
        public string Ship { get; set; }

        
        public string ShipId { get; set; }

        
        public string ShipName { get; set; }

        
        public string ShipIdent { get; set; }

        
        public double FuelLevel { get; set; }

        
        public double FuelCapacity { get; set; }

        
        public bool IsLanded { get; set; }

        
        public string GameMode { get; set; }

        
        public string Language { get; set; }

        
        public string GameVersion { get; set; }

        
        public string Build { get; set; }

        
        public long Credits { get; set; }

        
        public long Loan { get; set; }

        
        public string Group { get; set; }

        
        public bool IsStartingDead { get; set; }


        public static FIPPacket CreateFIPPacket(LoadGameData loadGameData) {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.LoadGame.ToString();
            gameData.Data = JsonSerializer.Serialize(loadGameData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }

    }
}
