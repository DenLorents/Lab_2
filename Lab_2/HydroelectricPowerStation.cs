namespace Lab_2
{
    public class HydroelectricPowerStation : PowerStation
    {
        public int WaterPressure { get; set; }
        public string Type { get; set; }
        public string PowerClass { get; set; }

        public HydroelectricPowerStation(BaseInform baseInfo, int waterpressure, string type, string powerclass): base(baseInfo)
        {
            WaterPressure = waterpressure;
            Type = type;
            PowerClass = powerclass;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, WaterPressure: {WaterPressure} Pa, Type: {Type}, PowerClass: {PowerClass} mw";
        }
    }
}