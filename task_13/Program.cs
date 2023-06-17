/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей 
цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */ 
Console.WriteLine("Enter a number =>  ");
int number = Convert.ToInt32(Console.ReadLine());

/*if (number < 100) Console.WriteLine("number < 100 ");

/* static void Main(string[] args)
 {
    int n = number;
    int d = GetSecondDigit(n);
    Console.WriteLine(d);
    Console.ReadKey();
}*/
/*Console.WriteLine("Введите трехзначное число");*/
        int k = number;
        int.TryParse(Console.ReadLine()!, out int k);
    
        if (k>999 || k<100)
        {
        Console.WriteLine("Не трехзначное число!!!");
        return;
        }
        int GetSecond(int k)
        {
        while (k >= 100) k /= 10;
        int d = k % 10;
        return d;
        }
        Console.WriteLine(GetSecond(k));

 
 /*static void Main(string[number] args);

 /*int d = GetSecondDigit(number);*/

 /**if (number > 100) Console.WriteLine(d);

/*Console.WriteLine("three number  {ThirdDigit(int d)} ");

/* int d = GetSecondDigit(number);

/*int ThirdDigit(int d)
/*if (number > 100) 
static void Main(string[] args)
/*{
    int n = 534534623;
     int d = GetSecondDigit(n);
    Console.WriteLine(d);
    Console.ReadKey();
}

static int GetSecondDigit(int k)
{
    while (k >= 100) k /= 10;
    int d = k % 10;
    return d;
}
*/



 /*{number = number

int result = -1;
if (number >= 100)
     {
    while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }*/
