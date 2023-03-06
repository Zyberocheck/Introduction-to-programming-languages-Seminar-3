// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно 
// палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Введите пятизначное число, а я проверю палиндром ли оно: ");
// int polin = Convert.ToInt32(Console.ReadLine());

// if (polin > 9999 && polin < 100000)
// {
//     PolinNumberp(polin);
// }

// void PolinNumberp(int palin)
// {
//     string polin = palin.ToString();
//     if(polin[0] == polin[4] && polin[1] == polin[3])
// {
//        Console.WriteLine(polin + " палиндром!");
// }else {
//      Console.WriteLine(polin + " не палиндром!");
// }
// }

// Более простой вариант !!!!

Console.WriteLine("Введите пятизначное число, а я проверю палиндром ли оно: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 9999 && a < 100000)
{
    String ap = Convert.ToString(a);
    if (ap[0] == ap[4] && ap[1] == ap[3])
{
    Console.WriteLine( a + " палиндром");
}else{
    Console.WriteLine( a + " не палиндром");
}

}else{
    Console.WriteLine( "Не верный ввод");
}
