#include <vector>
#include <math.h>
#include <utility>

class FuelCalc{

public:
	float EstFuelCons; //Estimated fuel fonsumption
	float TTF; //Time til race finish
	int FIC; //Current fuel in car
	std::vector<float> Laptime; 
	
	int FinalCalculation() {
		return 0;
	}
	void LapToSeconds(int minuit, float seconds, std::vector<float> Laptimes) { 
		float result = 0;
		while (Laptime.size() <= 5) {
			minuit *= 60;
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
		for (int i = 0; i <= Laptimes.size(); i++) {
			sumOfAll =+ Laptimes[i];
			
		}
		average = sumOfAll / Laptimes.size();
		
		return average;
	}
	
	int ProjectedLaps() {
		int numLaps = 0;
		numLaps = TTF / AvgCalc(Laptime);
		return numLaps;
	}

	int FuelForStint(int numLaps) {
		int LitersReq = 0;
		LitersReq = numLaps * EstFuelCons;
		return LitersReq;
	}
	

	void nums(float EstFuelCons, float TTF, int FIC ) {
		this->EstFuelCons = EstFuelCons;
		this->TTF = TTF;
		this->FIC = FIC;
	}
};

