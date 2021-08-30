#include <vector>
class MyClass{
public:
	float EstFuelCons; //Estimated fuel fonsumption
	float TTF; //Time til race finish
	int FIC; //Current fuel in car
	std::vector<float> Laptimes; 
	
	void LapToSeconds(int minuit, float seconds) { //inputs Minuit(whole integer), seconds.tht (float number) puts results into vector array
		float result = 0;
		while (Laptimes.size() == 5) {

			if (minuit < 1) { //if the minuit value entered is less than 1 stop program
				break;
			}
			else {  //minuit > 1 implied here , convert 
				minuit = *60;
				result = minuit + seconds;
				continue;
			}
		}
	}
	void AvgCalc(std::vector<float> Laptimes, ) { //input previous 5 laps from vector
						     //median avg formula: sum of all lap times / number of laps 
		float sumOfAll = 0;
		for (i = 0, i <= Laptimes.size(); i++) {
			sumOfAll =+ Laptimes[i];
		}
		return sumOfAll / Laptimes.size;
	}
	
	void ProjectedLaps() {

	}
	
	int FinalCalculation() {

	}

	nums(float EstFuelCons, float TTF, int FIC ) {
		EstimatedFuelConsumption = EstFuelCons;
		TimeTilFinish = TTF;
		FuelInCar = FIC;
	}
};

