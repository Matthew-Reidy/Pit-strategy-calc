#include <vector>
#include <math.h>
class FuelCalc{
public:
	double EstFuelCons; //Estimated fuel fonsumption
	double TTF; //Time til race finish
	int FIC; //Current fuel in car
	std::vector<float> Laptime; 
	
	void LapToSeconds(int minuit, double seconds, std::vector<float> Laptimes) { 
		double result = 0;
		while (Laptime.size() <= 5) {
			minuit =* 60;
			result = minuit + seconds;
			    continue;
			if (minuit < 1) {
				break;
			}
		}
	}
	int AvgCalc(std::vector<float> Laptimes) { 
		double sumOfAll = 0;
		double average = 0;
		for (i = 0, i <= Laptimes.size; i++) {
			sumOfAll =+ Laptimes[i];
			
		}
		average = sumOfAll / Laptimes.size;
		
		return average;
	}
	
	void ProjectedLaps(int numLaps) {
		int numLaps = 0;
		numLaps = TTF / AvgCalc;

	}
	int FuelForStint(int numLaps) {
		int LitersReq = 0;
		litersReq = numLaps * EstFuelCons;

		return litersReq;
	}
	

	FuelCalc(double EstFuelCons, double TTF, int FIC ) { //constructor
		EstimatedFuelConsumption = EstFuelCons;
		TimeTilFinish = TTF;
		FuelInCar = FIC;
	}
	
};

