namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            driver.Name = "Steve";
            driver.HasDriversLicense = false ;


            Car volvo = new Car(4,5,true,true, "JHKJHKJSJSGJGJHG100", driver);
            volvo.StartEngine();
            volvo.Accelerate(50);

            Console.WriteLine("Volvo: " + volvo.speed);

            driver = new Driver();
            driver.Name = "Lucas";
            driver.HasDriversLicense = false;

            Car bmw = new Car(4,5,false, false, "ZGHFATSFYUS100", driver);
            bmw.StartEngine();
            bmw.Accelerate(330);
            
            Console.WriteLine("BMW: " + bmw.speed);

            volvo.Decelerate(20);

            Console.WriteLine("Volvo: " + volvo.speed);

            driver = new Driver();
            driver.Name = "Lee";
            driver.HasDriversLicense = true;

            Car mazda = new Car(4,3,false,true,"IUOIUIOUOIUIO222",driver);
            mazda.StartEngine();
            mazda.Accelerate(10);

            double mazdaSpeed = mazda.GetCurrentSpeed();

            Console.WriteLine("Mazda: " + mazdaSpeed);

            Console.WriteLine("VOLVO HAVE GPS? : " + volvo.HasGps);
            Console.WriteLine("BMW HAVE GPS? : " + bmw.HasGps);
            Console.WriteLine("MAZDA HAVE GPS? : " + mazda.HasGps);

            Console.WriteLine("VOLVO DOORS? : " + volvo.NoOfDoors);
            Console.WriteLine("BMW DOORS? : " + bmw.NoOfDoors);
            Console.WriteLine("MAZDA DOORS? : " + mazda.NoOfDoors);

            volvo.Decelerate(400);

            Console.WriteLine("Volvo Current: " + volvo.speed);

            mazda.Decelerate(500);

            Console.WriteLine("Mazda Current: " + mazda.speed);


            Console.WriteLine("VOLVO VIN? : " + volvo.VinNumber);
            Console.WriteLine("BMW VIN? : " + bmw.VinNumber);
            Console.WriteLine("MAZDA VIN? : " + mazda.VinNumber);

            bmw.StopEngine();
            volvo.StopEngine();
            mazda.StopEngine();

            Console.WriteLine("VOLVO Driver? : " + volvo.CurrentDriver.Name);
            Console.WriteLine("VOLVO Driver License? : " + volvo.CurrentDriver.HasDriversLicense);

            Console.WriteLine("BMW Driver? : " + bmw.CurrentDriver.Name);
            Console.WriteLine("BMW Driver License? : " + bmw.CurrentDriver.HasDriversLicense);

            Console.WriteLine("Mazda Driver? : " + mazda.CurrentDriver.Name);
            Console.WriteLine("Mazda Driver License? : " + mazda.CurrentDriver.HasDriversLicense);

        }
    }
}
