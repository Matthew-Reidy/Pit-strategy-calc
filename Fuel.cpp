#include <vector>
#include <math.h>
class FuelCalc{
public:
	float EstFuelCons; //Estimated fuel fonsumption
	float TTF; //Time til race finish
	int FIC; //Current fuel in car
	std::vector<float> Laptime; 
	
	void LapToSeconds(int minuit, float seconds, std::vector<float> Laptimes) { 
		float result = 0;
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
		average = sumOfAll/Laptimes.size
		
		return average;
	}
	
	void ProjectedLaps(int numLaps) {
		int numLaps = 0;
		numLaps = TTF / AvgCalc;

	}
	int FuelForStint(int numLaps) {
		int LitersReq = 0;
		litersReq = numLaps * EstFuelCons;
	}
	

	FuelCalc(float EstFuelCons, float TTF, int FIC ) {
		EstimatedFuelConsumption = EstFuelCons;
		TimeTilFinish = TTF;
		FuelInCar = FIC;
	}
	
};

