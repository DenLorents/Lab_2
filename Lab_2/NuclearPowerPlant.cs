namespace Lab_2
{
    public class NuclearPowerPlant : PowerStation
    {
        public string LoadSchedule { get; set; }
        public string ConnectionType { get; set; }
        public bool SteamTurbine { get; set; }

        public NuclearPowerPlant(BaseInform baseInfo, string loadSchedule, string connectionType, bool steamTurbine) : base(baseInfo)
        {
            LoadSchedule = loadSchedule;
            ConnectionType = connectionType;
            SteamTurbine = steamTurbine;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Load Schedule: {LoadSchedule} , Connection Type: {ConnectionType}, Steam Turbine: {SteamTurbine}";
        }
    }
}