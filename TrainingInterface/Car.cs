using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingInterface
{

    public class Car : Vechile, IEnableAirCondition, IEnableEnte
    {
        public void DecreaseTemprature()
        {
            Console.WriteLine("Decreasing Temp");
        }

        public void IncreaseTemprature()
        {
            Console.WriteLine("Increas Temp");
        }

        public void PlayMusic()
        {
            Console.WriteLine("playing music");
        }

        public void StopMusic()
        {
            Console.WriteLine("stoping music");
        }

        public void SwitchoffAC()
        {
            Console.WriteLine("switch off AC");
        }
    }
}
