using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FuelCalculatorDLL
{
    public static class FuelCalc
    {
		static decimal EstFuelCons; //Estimated fuel fonsumption
		static decimal TTF; //Time til race finish
		static int FIC; //Current fuel in car
		static System.Collections.Generic.List<string> LaptimesString = new System.Collections.Generic.List<string>();
		static List<int> LapTimesNumber = new List<int>();

		public static int FinalCalculation(decimal estFuelCons, int estimatedLaps)
		{
			return (int)Math.Round(estFuelCons * estimatedLaps,0);
		}
		public static decimal LapToSeconds(decimal minutes, decimal seconds)
		{
            minutes *= 60;
            decimal result = minutes + seconds;
			return result;
        }
		public static decimal AvgCalc(List<decimal> lapTimes)
		{
			decimal sumOfAll = 0;
			decimal average = 0;
			foreach(decimal lapTime in lapTimes)
            {
				sumOfAll += lapTime;
            }
			average = sumOfAll / lapTimes.Count;

			return average;
		}

		public static int ProjectedLaps(decimal timeRemaining, decimal averageLapTime)
		{
			int numLaps = 0;
			numLaps = (int)Math.Round(timeRemaining /averageLapTime,0);
			return numLaps;
		}

		public static int FuelForStint(int numLaps)
		{
			int LitersReq = 0;
			LitersReq = numLaps * (int)Math.Round(EstFuelCons, 0);
			return LitersReq;
		}


		public static void nums(decimal EstFuelCons, decimal TTF, int FIC)
		{
			FuelCalc.EstFuelCons = EstFuelCons;
			FuelCalc.TTF = TTF;
			FuelCalc.FIC = FIC;
		}
	}
}
