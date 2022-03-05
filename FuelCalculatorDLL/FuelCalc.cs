using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FuelCalculatorDLL
{
    public static class FuelCalc
    {
		static double EstFuelCons; //Estimated fuel fonsumption
		static double TTF; //Time til race finish
		static int FIC; //Current fuel in car
		static List<string> LaptimesString = new List<string>();
		static List<int> LapTimesNumber = new List<int>();

		public int FinalCalculation(double estFuelCons, int estimatedLaps)
		{
			return (int)Math.Round(estFuelCons * estimatedLaps,0); //can also use math.floor or ceil to avoid type casting
		}
		public double LapToSeconds(double minutes, double seconds)
		{
            minutes *= 60;
            double result = minutes + seconds;
			return result;
        }
		public double AvgCalc(List<double> lapTimes)
		{
			decimal sumOfAll = 0;
			decimal average = 0;
			foreach(double lapTime in lapTimes)
            {
				sumOfAll += lapTime;
            }
			average = sumOfAll / lapTimes.Count;

			return average;
		}

		public int ProjectedLaps(double timeRemaining, double averageLapTime)
		{
			int numLaps = 0;
			numLaps = (int)Math.Round(timeRemaining /averageLapTime,0); //can also use math.floor or ceil to avoid type casting
			return numLaps;
		}

		public int FuelForStint(int numLaps)
		{
			int LitersReq = 0;
			LitersReq = numLaps * (int)Math.Round(EstFuelCons, 0); //can also use math.floor or ceil to avoid type casting
			return LitersReq;
		}


		public static void nums(double EstFuelCons, double TTF, int FIC)
		{
			FuelCalc.EstFuelCons = EstFuelCons;
			FuelCalc.TTF = TTF;
			FuelCalc.FIC = FIC;
		}
	}
}
