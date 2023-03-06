// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно 
// палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число, а я проверю палиндром ли оно: ");
int polin = Convert.ToInt32(Console.ReadLine());

if (polin > 9999 && polin < 100000);
{
    PolinNumberp(polin);
}

void PolinNumberp(int pa)
{
    string palin = Convert.ToString(polin);
    if(palin[0] == palin[4] && palin[1] == palin[3])
{
       Console.WriteLine(polin + " палиндром!");
}else {
     Console.WriteLine(polin + " не палиндром!");
}
}

