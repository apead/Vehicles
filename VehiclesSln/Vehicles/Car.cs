using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Car
    {
        public int NoOfWheels;
        public int NoOfDoors;
        public double speed;
        public bool HasGps;
        double FuelLevel;
        public string VinNumber;

        public bool HasRegistrationLicense;

        public Driver CurrentDriver = new Driver();


        public Car(int noOfWheels, int noOfDoors, bool hasGps, bool hasRegistrationLicense, string vinNumber, Driver driver)
        {
            NoOfWheels = noOfWheels;
            NoOfDoors = noOfDoors;
            HasGps = hasGps;
            HasRegistrationLicense = hasRegistrationLicense;
            VinNumber = vinNumber;
            CurrentDriver = driver;
        }


        public void StartEngine()
        {
            speed = 1;    
        }   

        public void StopEngine()
        {
            speed = 0;
        }

        public void Accelerate(double speedAmount)
        {
            speed += speedAmount;
        }

        public void Decelerate(double speedAmount)
        {
            speed -= speedAmount;
        
            if (speed < 0)
            {
                speed = 0;
            }
        }

        public double GetCurrentSpeed()
        {
            return speed;
        }

    }
}
