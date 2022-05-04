using System;
using System.Linq;
using static System.Console;

Clear();
WriteLine("y = k1 * x + b1");
WriteLine("y = k2 * x + b2");
printResult(askNumbers());

int[] askNumbers() {
    Write("Введите b1, k1, b2, k2 по порядку через пробел: ");
    return ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}

void printResult(int[] array) {
    double x = ((double) array[2] - array[0]) / ((double) array[1] - array[3]);
    double y = array[3] * x + array[2];
    WriteLine($"b1 = {array[0]}, k1 = {array[1]}, b2 = {array[2]}, k2 = {array[3]} -> ({x}; {y})");
}