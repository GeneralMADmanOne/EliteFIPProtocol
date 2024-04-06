namespace EliteFIPProtocol {

    public enum GameDataType {
        Status,
        Target,
        Location,
        Navigation,
        Jump,
        DockingGranted,
        DockingDenied,
        DockingTimeout,
        DockingCancelled,
        LoadGame,
        Loadout,
        RefuelAll,
        RefuelPartial,
        ReservoirReplenished,
        FuelScoop,
        ShipyardSwap,
        ShipyardBuy,
        ShipyardNew
    }

    public class GameData {

        public string Type { get; set; }
        public string Data { get; set; }
    }
}
