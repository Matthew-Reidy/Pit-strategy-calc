using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FuelCalculatorDLL
{
    public static class FuelCalc
    {
		static float EstFuelCons; //Estimated fuel fonsumption
		static float TTF; //Time til race finish
		static int FIC; //Current fuel in car
		static System.Collections.Generic.List<string> LaptimesString = new System.Collections.Generic.List<string>();
		static List<int> LapTimesNumber = new List<int>();

		static int FinalCalculation()
		{
			return 0;
		}
		static void LapToSeconds(List<string> LaptimesString)
		{
			List<int> result = new List<int>();
			while (LaptimesString.Count <= 5)
			{
				for (int i = 0; i <= LaptimesString.Count; i++)
                {
					string[] SplitLapTime;
					SplitLapTime = LaptimesString[i].Split(':');
					for (int h = 0; h < SplitLapTime.Length; h++)
                    {
                        if (int.TryParse(SplitLapTime[h], out int j))
                        {
                            result[i] = j * 60;
                        }
                    }
					if(int.TryParse(SplitLapTime[SplitLapTime.Count()-1], out int k))
                    {
						result[i] = result[i] + 60;
                    }
                }
			}
			LapTimesNumber = result;
		}
		static double AvgCalc()
		{
			double sumOfAll = 0;
			double average = 0;
			for (int i = 0; i <= LapTimesNumber.Count; i++)
			{
				sumOfAll += LapTimesNumber[i];

			}
			average = sumOfAll / LapTimesNumber.Count;

			return average;
		}

		static int ProjectedLaps()
		{
			int numLaps = 0;
			numLaps = (int)Math.Round(TTF / AvgCalc(),0);
			return numLaps;
		}

		static int FuelForStint(int numLaps)
		{
			int LitersReq = 0;
			LitersReq = numLaps * (int)Math.Round(EstFuelCons, 0);
			return LitersReq;
		}


		static void nums(float EstFuelCons, float TTF, int FIC)
		{
			FuelCalc.EstFuelCons = EstFuelCons;
			FuelCalc.TTF = TTF;
			FuelCalc.FIC = FIC;
		}
	}
}
