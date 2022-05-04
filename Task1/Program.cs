using System;
using System.Linq;
using static System.Console;

Clear();
int[] array = askNumbers();
int count = countAboveZero(array);
WriteLine($"{string.Join(", ", array)} -> {count}");

int[] askNumbers() {
    Write("Введите числа через пробел: ");
    return ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}

int countAboveZero(int[] array) {
    return array.Where(x => x > 0).Count();
}