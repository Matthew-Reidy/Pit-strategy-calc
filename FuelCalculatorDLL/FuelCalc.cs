using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FuelCalculatorDLL
{
    public static class FuelCalc
    {
        /// <summary>
        /// Calculate how much fuel is needed for minimum and maximum and average laps
        /// </summary>
        /// <param name="timeRemainingMilliseconds">session time remaining in ms</param>
        /// <param name="lapTime">list of lap times set in session</param>
        /// <param name="fuelPerLap">fuel used per lap in session</param>
        /// <param name="currentFuel">fuel at time of calculation</param>
        /// <param name="fuelTankSize">max size of the fuel tank</param>
        /// <returns>composite list of all fuel data</returns>
        public static List<decimal> CalculateFuel(decimal timeRemainingMilliseconds, decimal lapTime, decimal fuelPerLap, decimal currentFuel, decimal fuelTankSize)
        {
            List<decimal> fuelData = new List<decimal>();
            decimal estimatedLaps = ProjectedLaps(timeRemainingMilliseconds, lapTime);
            decimal fillTo = FinalCalculation(fuelPerLap, (int)estimatedLaps, currentFuel);
            decimal fuelDuration = currentFuel != 0 ?  Math.Floor(currentFuel / fuelPerLap) : Math.Floor(fillTo/fuelPerLap);
            
            if (fillTo > fuelTankSize)
            {
                fillTo = (int)fuelTankSize;
            }
            decimal fuelAtEnd = fillTo + currentFuel - (estimatedLaps * fuelPerLap);
            fuelData.Add(fuelDuration);
            fuelData.Add(fillTo);
			fuelData.Add(fuelAtEnd);
            return fuelData;
        }
        public static int FinalCalculation(decimal estFuelCons, int estimatedLaps, decimal currentFuel)
		{
			return (int)Math.Ceiling(estFuelCons * estimatedLaps - currentFuel); //can also use math.floor or ceil to avoid type casting
		}
		public static decimal LapToSeconds(decimal minutes, decimal seconds)
		{
            minutes *= 60;
            decimal result = minutes + seconds;
			return result;
        }

		public static int ProjectedLaps(decimal timeRemaining, decimal averageLapTime)
		{
			int numLaps = averageLapTime != 0 ? (int)Math.Ceiling(timeRemaining /averageLapTime) : 0; //can also use math.floor or ceil to avoid type casting
			return (int)numLaps;
		}

	}
}
