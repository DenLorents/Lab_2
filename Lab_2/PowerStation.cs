namespace Lab_2
{
    public class PowerStation
    {
        public BaseInform BaseInfo { get; set;}

        public PowerStation(BaseInform baseInfo)
        {
            BaseInfo = baseInfo;
        }

        public override string ToString()
        {
            return BaseInfo.ToString();
        }
    }
}