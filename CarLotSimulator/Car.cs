using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{

    //Create a seperate class file called Car done
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable done
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() done
    //The methods should take one string parameter: the respective noise property   done         


    //Now that the Car class is created we can instanciate 3 new cars
    //Set the properties for each of the cars
    //Call each of the methods for each car

    public class Car
    {

        public Car()
        { }

        //public Car(string make, string model, int year, string enginNoise;
        //string honkNoise, bool IsDriveable)
        //{
        //    Make = make;
        //    }

        public Car(string make, string model, int year, string enginNoise,
                  string honkNoise, bool isDriveable)
        { 
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = enginNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }
        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"{engineNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

    }
}
