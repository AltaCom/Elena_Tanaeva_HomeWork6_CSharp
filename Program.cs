/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3


int[] PosiNum (int m)
{
    int[] newArray = new int [m];

    for (int i = 0; i < m; i++)
    {
        
    Console.Write("Input number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    newArray[i] = number;
              
    }
    
return newArray;
}
void ShowArray (int[] array)

{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();

}

int Current (int[] array)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] > 0) current++;

return current;
}

Console.Write("How many numbers do you want to input? ");
int m = Convert.ToInt32(Console.ReadLine());

int[] result = PosiNum (m);
ShowArray(result);
int posinum = Current(result);

Console.Write($"The number of positive numbers is {posinum}.");
Console.WriteLine();
*/


/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


string Point (int b1, int k1, int b2, int k2)
{
    string point = string.Empty;
int x = (b2 - b1) / (k1 - k2);
int y = (k1 * b2 - k2 * b1) / (k1 - k2);
point = "A (" + x.ToString() + ", " + y.ToString() + ")";


return point;
}

Console.Write("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

string point2 = Point(k1, b1, k2, b2);
Console.Write($"The intersection point is {point2}");
Console.WriteLine();

*/
