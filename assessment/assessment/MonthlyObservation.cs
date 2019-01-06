using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    public class MonthlyObservation
    {
        // All the objects required for the task
        int idNum;
        double maxTemp;
        double minTemp;
        int numDaysFrost;
        double milRain;
        double hoursSun;

        // Constructor
        public MonthlyObservation(int idIn, double maxTempIn, double minTempIn, int numDaysFrostIn, double milRainIn, double hoursSunIn)
        {
            idNum = idIn;
            minTemp = minTempIn;
            maxTemp = maxTempIn;
            numDaysFrost = numDaysFrostIn;
            milRain = milRainIn;
            hoursSun = hoursSunIn;
        }
        
        //

        // Set month id number
        public void SetIDNum(int idIn)
        {
            idNum = idIn;
        }

        // Set maximum temperature
        public void SetMaxTemp(double maxTempIn)
        {
            maxTemp = maxTempIn;
        }

        // Set minimum temperature
        public void SetMinTemp(double minTempIn)
        {
            minTemp = minTempIn;
        }

        // Set number of days air frost
        public void SetNumDaysFrost(int numDaysFrostIn)
        {
            numDaysFrost = numDaysFrostIn;
        }

        // Set millimeters of rainfall
        public void SetMilRain(double milRainIn)
        {
            milRain = milRainIn;
        }

        // Set hours of sunshine
        public void SetHoursSun(double hoursSunIn)
        {
            hoursSun = hoursSunIn;
        }

        //

        // Get month id number
        public int GetIDNum()
        {
            return idNum;
        }

        // Get maximum temperature
        public double GetMaxTemp()
        {
            return maxTemp;
        }

        // Get minimum temperature
        public double GetMinTemp()
        {
            return minTemp;
        }

        // Get number of days air frost
        public int GetNumDaysFrost()
        {
            return numDaysFrost;
        }

        // Get millimeters of rainfall
        public double GetMilRain()
        {
            return milRain;
        }

        // Get hours of sunshine
        public double GetHoursSun()
        {
            return hoursSun;
        }

    }
}
