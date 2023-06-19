/* Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите числo =>  ");
int n = Convert.ToInt32(Console.ReadLine());
Dictionary<int, string> map = new Dictionary<int, string>() /*считываем словарь*/
{
    { 1, "Pn"},
    { 2, "Vt"},
    { 3, "Sr"},
    { 4, "Cht"},
    { 5, "Pt"},
    { 6, "Sb"},
    { 7, "Vs"},
};
if (n > 0 && n < 6) Console.WriteLine("No");
if (n > 5 && n < 8) Console.WriteLine("Yes");
if (n < 1 || n > 7) Console.WriteLine("Нет такого дня недели");

