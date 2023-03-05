// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно 
// палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int[] polina = new int[5];

Console.WriteLine("Введите число, а я проверю палиндром ли оно: ");
int polin = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < polina.Length; i++)
if (polina[0] == polina[4] && polina[1] == polina[3])
{
// Console.WriteLine(polin + " палиндром!");
Console.WriteLine(polina[0] + polina[4] + polina[1] + polina[3]);
} else {
    // Console.WriteLine(polin + " не палиндром!");
}

