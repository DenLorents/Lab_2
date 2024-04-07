namespace Lab_2
{
    public class BaseInform
    {
        public string Name { get; set; }
        public int YearOfFoundation { get; set; }
        public int Workers { get; set; }
        public int Power { get; set; }
        public string Country { get; set; }

        public BaseInform(string name, int yearOfFoundation, int workers, int power, string country) 
        {
            Name = name;
            YearOfFoundation = yearOfFoundation;
            Workers = workers;
            Power = power;
            Country = country;
        }
        public override string ToString()
        {
            return $" Name:{Name}, YearOfFoundation: {YearOfFoundation} year, Workers: {Workers}, Power:{Power} mw, Country:{Country} ";
        }
    }
}