using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    public class Location
    {
        // All the objects required for the task
        string name;
        string streetAddress;
        string country;
        string postCode;
        string latitude;
        string longitude;
        int numOfYears;
        private Year[] years;

        // Constructor
        public Location(string nameIn, string streetIn, string countryIn, string postcodeIn, string latitudeIn, string longitudeIn, int numOfYearsIn)
        {
            name = nameIn;
            streetAddress = streetIn;
            country = countryIn;
            postCode = postcodeIn;
            latitude = latitudeIn;
            longitude = longitudeIn;
            numOfYears = numOfYearsIn;
            years = new Year[numOfYears];
        }

        // 

        // Set location name
        public void SetName(string nameIn)
        {
            name = nameIn;
        }

        // Set street name and number
        public void SetStreetName(string stNameIn)
        {
            streetAddress = stNameIn;
        }

        // Set country
        public void SetCountry(string countryIn)
        {
            country = countryIn;
        }

        // Set postcode
        public void SetPostCode(string postcodeIn)
        {
            postCode = postcodeIn;
        }

        // Set latitude
        public void SetLatitude(string latitudeIn)
        {
            latitude = latitudeIn;
        }

        // Set longitude
        public void SetLongitude(string longitudeIn)
        {
            longitude = longitudeIn;
        }

        //Set number of years in location
        public void SetNumOfYears(int numOfYearsIn)
        {
            numOfYears = numOfYearsIn;
            // Resize the array to match the number of years
            Array.Resize(ref years, (numOfYears));
        }

        // Set a year
        public void SetYears(Year yearIn, int currentYear)
        {
            years[currentYear] = yearIn;
        }

        public void SetMonths(int currentYear, MonthlyObservation monthIn, int currentMonth)
        {
            years[currentYear].SetMonthObs(monthIn, currentMonth);
        }

        //

        // Get location name
        public string GetName()
        {
            return name;
        }

        // Get street name and number
        public string GetStreetName()
        {
            return streetAddress;
        }

        // Get country
        public string GetCountry()
        {
            return country;
        }

        // Get postcode
        public string GetPostCode()
        {
            return postCode;
        }

        // Get latitude
        public string GetLatitude()
        {
            return latitude;
        }

        // Get longitude
        public string GetLongitude()
        {
            return longitude;
        }

        // Get number of years in location
        public int GetNumOfYears()
        {
            return numOfYears;
        }

        // Get a year
        // note for self: will need a loop
        public Year[] GetYears()
        {
            return years;
        }       

    }

}
