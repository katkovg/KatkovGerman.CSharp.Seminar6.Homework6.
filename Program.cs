// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void findTheIntersectionPoint (double k1, double b1, double k2, double b2)
{
    double X = ((b2 - b1) / (k1 - k2));
    double Y = k1 * X + b1;

   Console.WriteLine($"The intersection point is: X({X}); Y({Y})");
}


Console.WriteLine("Input a numeric coefficient K1 to set the first line:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a numeric coefficient B1 to set the first line:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a numeric coefficient K2 to set the first line:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a numeric coefficient B2 to set the first line:");
double b2 = Convert.ToDouble(Console.ReadLine());

findTheIntersectionPoint (k1, b1, k2, b2);
*/

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Input a quantity of numbers:");
int quantity = Convert.ToInt32(Console.ReadLine());

int number = 0;
int countNumbers = 0;
int greaterThanZeroCounter = 0;
int numberOfFiguresInText = 1;

while(countNumbers < quantity)
{
    Console.WriteLine($"Input a number {numberOfFiguresInText}:");
    number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        greaterThanZeroCounter++;
        countNumbers++;
        numberOfFiguresInText++;
    }
    else if (number <= 0) {countNumbers++; numberOfFiguresInText++;}
}
Console.WriteLine($"The quantity of numbers greater than zero is: {greaterThanZeroCounter}.");
*/
