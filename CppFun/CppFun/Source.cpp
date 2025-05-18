#include<iostream>
#include"Student.h"

double Add(double a, double b){
	return a + b;
} 

int main(){
	Student *pStu = new Student(); 
	double x = 3.0;
	double y = 5.0;
	double result = pStu->Add(x, y);
	std::cout << "Hello World";

	std::cout << x << "+" << y << "=" << result;
	pStu->SayHello();

	return 0;
}