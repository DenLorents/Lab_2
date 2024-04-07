using System;
using System.Collections.Generic;

namespace Lab_2
{
    public class PowerStationManager
    {
        private List<PowerStation> powerstationlist;

        public PowerStationManager()
        {
            powerstationlist = new List<PowerStation>();
        }
 
        public void AddPowerStation(PowerStation powerStation)
        {
            powerstationlist.Add(powerStation);
        }
        public bool RemovePowerStation(PowerStation powerStation)
        {
            return powerstationlist.Remove(powerStation);
        }
        public void EditPowerStation(int index, PowerStation newPowerStation)
        {
            if(index < 0  || index >= powerstationlist.Count)
            {
                throw new ArgumentOutOfRangeException(paramName: "Index is outside the bounds of the powerStation list.");
            }
            powerstationlist[index] = newPowerStation;

        }
 
        public void DisplayAllPowerStation()
        {
            foreach(var powerstation in powerstationlist)
            {
                Console.WriteLine(powerstation);

            }
        }

    }
}