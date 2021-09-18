//Fuel Calculation Header - Declares the functions for Fuel Calculation
#pragma once
#include <vector>
#include "Fuel.cpp"
#ifdef ACCpitstopcalc_EXPORTS
#define ACCpitstopcalc_API __declspec(dllexport)
#else
#define ACCpitstopcalc_API __declspec(dllimport)
#endif

extern "C" ACCpitstopcalc_API int FinalCalculation();
extern "C" ACCpitstopcalc_API void nums(double EstFuelCons, double TTF, int FIC);
extern "C" ACCpitstopcalc_API void LapToSeconds(int minuit, float seconds, std::vector<float> Laptime);
extern "C" ACCpitstopcalc_API int AvgCalc(std::vector<float> Laptimes);
extern "C" ACCpitstopcalc_API int ProjectedLaps();
extern "C" ACCpitstopcalc_API int FuelForStint(int numLaps);