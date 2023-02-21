// Задача 2
//  Console.WriteLine("Введите целое число");
//  int numA = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите целое число");
//  int numB = Convert.ToInt32(Console.ReadLine());
//  if (numA > numB)
//  {
//     Console.WriteLine("Максимальное число" +numA);
//     Console.WriteLine("Минимальное число" +numB);
//  }
//  else 
//  {
//      Console.WriteLine("Максимальное число: " +numB);
//      Console.WriteLine("Минимальное число: " +numA);
//  }

//Задача 4 
// Console.WriteLine("Введите целое число");
//  int numA = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите целое число");
//  int numB = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите целое число");
//  int numC = Convert.ToInt32(Console.ReadLine());
// int max = numA;
// if (numB > max)
// {
//     max = numB;
// }
// if (numC > max)
// {
//     max = numC;
// }
// Console.WriteLine("Наибольшее из чисел: " + max);

//Задача 6 
// Console.WriteLine("Введите целое число");
//  int num = Convert.ToInt32(Console.ReadLine());
// if (num%2==0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача 8
int k = 1; 
Console.Write("Введите число: ");
int num= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + num);
while (k<=num)
{
    if (k%2 == 0)
    {
        Console.Write(k + ", ");
    }
    k=k+1;
}
