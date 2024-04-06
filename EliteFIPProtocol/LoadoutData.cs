using System;
using System.Collections.Generic;
using System.Text.Json;

namespace EliteFIPProtocol {
    public class LoadoutData {

        public DateTime Timestamp { get; set; }

        public string Event { get; set; }

        public string Ship { get; set; }

        public string ShipId { get; set; }

        public string ShipName { get; set; }

        public string ShipIdent { get; set; }

        public long HullValue { get; set; }

        public long ModulesValue { get; set; }

        public double HullHealth { get; set; }

        public double UnladenMass { get; set; }

        public long CargoCapacity { get; set; }

        public double MaxJumpRange { get; set; }

        public FuelCapacityInfo FuelCapacity { get; set; }

        public long Rebuy { get; set; }

        public ICollection<ModuleInfo> Modules { get; set; }

        public struct FuelCapacityInfo
        {
            public double Main { get; set; }

            public double Reserve { get; set; }
        }


        public struct ModuleInfo
        {
            public string Slot { get; set; }

            public string Item { get; set; }

            public bool IsOn { get; set; }

            public long Priority { get; set; }

            public long Value { get; set; }

            public double Health { get; set; }

            public long AmmoInClip { get; set; }

            public long AmmoInHopper { get; set; }

            public EngineeringInfo Engineering { get; set; }
        }


        public struct EngineeringInfo
        {
            public string Engineer { get; set; }

            public string EngineerId { get; set; }

            public string BlueprintId { get; set; }

            public string BlueprintName { get; set; }

            public string ExperimentalEffect { get; set; }

            public long Level { get; set; }

            public double Quality { get; set; }

            public ICollection<ModifierInfo> Modifications { get; set; }
        }


        public struct ModifierInfo
        {
            public string Label { get; set; }

            public double Value { get; set; }

            public double OriginalValue { get; set; }

            public long LessIsGood { get; set; }
        }

        public bool IsHot { get; set; }


        public static FIPPacket CreateFIPPacket(LoadoutData loadoutData) {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.Loadout.ToString();
            gameData.Data = JsonSerializer.Serialize(loadoutData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }

    }
}
