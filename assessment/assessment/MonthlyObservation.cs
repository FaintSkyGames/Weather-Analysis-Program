using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    class MonthlyObservation
    {
        // All the objects required for the task
        int idNum;
        double maxTemp;
        double minTemp;
        int numDaysFrost;
        double milRain;
        double hoursSun;

        // Constructor
        public MonthlyObservation(int idIn, double minTempIn, double maxTempIn, int numDaysFrostIn, double milRainIn, double hoursSunIn)
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
        public void GetIDNum()
        {

        }

        // Get maximum temperature
        public void GetMaxTemp()
        {

        }

        // Get minimum temperature
        public void GetMinTemp()
        {

        }

        // Get number of days air frost
        public void GetNumDaysFrost()
        {

        }

        // Get millimeters of rainfall
        public void GetMilRain()
        {

        }

        // Get hours of sunshine
        public void GetHoursSun()
        {

        }

    }
}
