using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    class Year
    {
        // All the objects required for the task
        int yearID;
        string description;
        private MonthlyObservation[] monthObs = new MonthlyObservation[12];

        // Constructor
        public Year(string descriptionIn, int idIn)
        {
            yearID = idIn;
            description = descriptionIn;
        }

        //

        // Set year id
        public void SetYearID(int idIn)
        {
            yearID = idIn;
        }

        // Set year description
        public void SetDescription(string descriptionIn)
        {
            description = descriptionIn;
        }

        // Set a single monthly obsevation
        public void SetMonthObs(MonthlyObservation monthIn, int currentMonth)
        {
            monthObs[currentMonth] = monthIn;
        }

        //

        // Get year id
        public int GetYearID()
        {
            return yearID;
        }

        // Get year description
        public string GetDescription()
        {
            return description;
        }

        // Get a monthly observation
        // note for self: will need a loop elsewhere
        public MonthlyObservation GetMonthObs(int currentMonth)
        {
            return monthObs[currentMonth];
        }

    }
}
