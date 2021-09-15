// ACCpitstopcalc.cpp : This file contains the 'main' function. Program execution begins and ends there.
#include "Header.h"
#include <iostream>
//#include "ACCPitstopCalculatorGUI.cs"
//place holders in main until I can make gui in c#
int main()
{
	int minuit;
	float seconds;
	std::cout << "enter laptime minuit:" << std::endl;
	std::cin >> minuit;
	std::cout << "enter seconds after the minuit (seconds.xxx)" << std::endl;
	std::cin >> seconds;
	FuelCalc fuelCalc;

	int refuel = fuelCalc.FinalCalculation();
}

// Run program: Ctrl + F5 or Debug > Start Withou
// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu
