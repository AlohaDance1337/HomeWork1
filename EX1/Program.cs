System.Console.WriteLine("Ведите первое число");
String stringValue = Console.ReadLine();
int a = Convert.ToInt32(stringValue);

System.Console.WriteLine("Ведите второе число");
String stringValue1 = Console.ReadLine();
int b = Convert.ToInt32(stringValue1);

if(a>b)
    System.Console.WriteLine($"Максимальное число из двух {a}");
else
    System.Console.WriteLine($"Максимальное число из двух {b}");