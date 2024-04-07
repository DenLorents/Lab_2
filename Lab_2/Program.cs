using System;

namespace Lab_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PowerStationManager manager = new PowerStationManager();
            
            BaseInform infoThermalPowerPlant = new BaseInform(name: "ThermalPowerPlant", yearOfFoundation: 1969, workers: 2000, power: 600, country: "Ukraine");
            PowerStation thermalPowerPlant = new ThermalPowerPlant(infoThermalPowerPlant, reactortype: "TP-10,TP-92", typeofenergyreleased: "heat-electricity", numberofreactors: 3);

            BaseInform infoNuclearPowerPlant = new BaseInform(name: "NuclearPowerStation", yearOfFoundation: 1986, workers: 4000, power: 5442, country: "France");
            PowerStation nuclearPowerPlant = new NuclearPowerPlant(infoNuclearPowerPlant, loadSchedule: "ВВЭР-1000/320", connectionType: "overhead line", steamTurbine: true);

            BaseInform infoHydroelectricPowerStation = new BaseInform(name: "HydroelectricPowerStation", yearOfFoundation: 2003, workers: 10000, power: 22500, country: "China");
            PowerStation hydroelectricPowerStation = new HydroelectricPowerStation(infoHydroelectricPowerStation, waterpressure: 950, type: "high-pressure", powerclass: "powerful");
//додавання
            manager.AddPowerStation(thermalPowerPlant);
            manager.AddPowerStation(nuclearPowerPlant);
            manager.AddPowerStation(hydroelectricPowerStation);
                //показ списку
            Console.WriteLine("Initial power station list:");
            manager.DisplayAllPowerStation();
//редагування
            BaseInform infoEditThermalPowerPlant = new BaseInform(name: "ThermalPowerPlant", yearOfFoundation: 1979, workers: 2000, power: 424, country: "Ukraine");
            ThermalPowerPlant editedThermalPowerPlant = new ThermalPowerPlant(infoEditThermalPowerPlant, reactortype: "TP-10x6,TP-92x2", "heat-electricity", numberofreactors: 4);
            manager.EditPowerStation(index:0,editedThermalPowerPlant );

            Console.WriteLine("\n List after edition");
            manager.DisplayAllPowerStation();
            //видалення     
            manager.RemovePowerStation(nuclearPowerPlant);
//вивід після видалення
            Console.WriteLine("\n Power station list after remove:");
            manager.DisplayAllPowerStation();
        }
    }
}