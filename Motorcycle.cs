using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
   /* static void Main(string[] args)
    {
        string fromArray = GetVowels(new[] { "apple", "banana", "pear" });
        Console.WriteLine($"Vowels from array :'{fromArray}'");

        string fromMultipleArguments = GetVowels("apple", "banana", "pear");
        Console.WriteLine($"Vowels from multiple arguments : '{fromMultipleArguments}'");

        string fromNull = GetVowels(null);
        Console.WriteLine($"Vowels from null : '{fromNull}'");

        string fromNoValue = GetVowels();
        Console.WriteLine($"Vowels from no value : '{fromNoValue}'");

        Console.ReadKey();
    }
   */
    abstract class Motorcycle
    {

        double miles = 10;
        double speed = 100;
        public void StarEngine()
        {
        }
        protected void AddGas (int gallons)
        {
        }
        public virtual int Drive(int miles, int speed)
        {
            return (int)Math.Round(((double)miles)/speed,0);
        }
        public virtual int Drive(TimeSpan time, int speed)
        {
           return 0;
        }

         public abstract double GetTopSpeed();
           
    }

    class SportsMotorCycle : Motorcycle
    {

        double _weightRatio = 1.2;

        public override int Drive(int miles, int speed)
        {
            return (int)Math.Round(((double)miles) / speed, 0) * (int)_weightRatio;
        }
        public override double GetTopSpeed()
        {
            return 70.05;
        }
    }

    class SportsMotorCycleWithSideCar : Motorcycle
    {

        double _weightRatio = 0.8;

        public override int Drive(int miles, int speed)
        {
            return base.Drive(miles,speed)*(int)_weightRatio;
        }
        public override double GetTopSpeed()
        {
            return 70.05;
        }
    }
}
