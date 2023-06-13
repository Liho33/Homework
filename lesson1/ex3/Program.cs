// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

System.Console.Write("введите число -> ");
int num1 = System.Convert.ToInt32(System.Console.ReadLine());

int num = num1 % 2;

if (num == 0)
{
    System.Console.WriteLine($"да число {num1} являеться четным");
}
else 
{
    System.Console.WriteLine($"нет число {num1} не являеться четным");
}