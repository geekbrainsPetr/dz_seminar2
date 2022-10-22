// показать вторую цифру в трехзначном числе

/*

int ShowDig(int num)
{
int des = num / 10;
int res = des % 10;
return res;

}

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int res = ShowDig(num);

Console.WriteLine($"вторая цифра в числе {num} является  {res} ");

*/

//Ввод цифры обозначающий день недели



bool Tru(int num) 
{
    if (num > 5)
    {
    Console.WriteLine("Это выходной");    
    return true;
    }

    else

    {
    Console.WriteLine("Это рабочий день");
    return false;
    
    }
}
Console.WriteLine("Введите порядковый номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());

bool con = Tru(num);
Console.WriteLine(con);
// немного криво, но как смог. 


//вывод третьей цифры, думаю, пропустим.


 