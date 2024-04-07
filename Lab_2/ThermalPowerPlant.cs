namespace Lab_2
{
    public class ThermalPowerPlant : PowerStation
    {
        public string ReactorType { get; set; }
        public string TypeOfEnergyReleased { get; set; }

        public int NumberOfReactors { get; set; }

        public ThermalPowerPlant(BaseInform baseInfo, string reactortype, string typeofenergyreleased, int numberofreactors) : base(baseInfo)
        {
            ReactorType=reactortype;
            TypeOfEnergyReleased=typeofenergyreleased;
            NumberOfReactors=numberofreactors;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Reactor Type: {ReactorType}, Type Of Energy Released: {TypeOfEnergyReleased}, Number Of Reactors {NumberOfReactors}";
        }
    }
}