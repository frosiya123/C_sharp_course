// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowerNumb(int numA, int numB){
    if(numB == 0) return 1;
    return PowerNumb(numA, numB -1) * numA;
}
Console. Write(PowerNumb(3, 5));