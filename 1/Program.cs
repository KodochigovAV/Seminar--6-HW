//  Задача 1: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 
//  ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int Prompt(string FORuser)
{
    System.Console.Write(FORuser);
    string FROMuser = Console.ReadLine();
    return int.Parse(FROMuser);
}
int A = Prompt("Enter 1/3 -> ");
int B = Prompt("Enter 2/3 -> ");
int C = Prompt("Enter 3/3 -> ");

int[] mass = new int[3];
mass[0] = A;
mass[1] = B;
mass[2] = C;

int Positive(int[] mass)
{
    int answer = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > 0) answer++;
    }
    return answer;
}
System.Console.WriteLine(Positive(mass));