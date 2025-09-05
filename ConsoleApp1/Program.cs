//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello PV414");
//int a = 12;
//int b;
//string? name;
//const int a = 10;
Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.InputEncoding = System.Text.Encoding.UTF8;
//Console.WriteLine($"template for my text{DateTime.Now.ToShortTimeString()}");
//Console.Write("Введіть своє ім'я: ");
//string? name = Console.ReadLine();
//Console.Write("Введіть свій вік: ");
//int age = Convert.ToInt32( Console.ReadLine() );
//Console.WriteLine($"Привіт! {name}");
//int b = 100;
//byte a = b;
//if (true)
//{
//    Console.WriteLine();
//}
//else if (false)
//{
//}
//else { 
//}
//int num1 = 8;
//int num2 = 6;
//if (num1 > num2 && num2 == 6)
//{
//    Console.WriteLine("First num is bigger");
//}
//else if (num1 > num2 && num1 == 6) {

//}


Console.Write("Введіть 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введіть 2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Перше число більше");
}
else if (a < b)
{
    Console.WriteLine("Друге число більше");
}
else {
    Console.WriteLine("Вони рівні");
}
