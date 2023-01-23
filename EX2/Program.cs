System.Console.WriteLine("Ведите первое число");
String stringValue = Console.ReadLine();
int a = Convert.ToInt32(stringValue);

System.Console.WriteLine("Ведите второе число");
String stringValue1 = Console.ReadLine();
int b = Convert.ToInt32(stringValue1);

System.Console.WriteLine("Ведите третье число");
String stringValue2 = Console.ReadLine();
int c = Convert.ToInt32(stringValue2);

if(a>b && a>c)
    System.Console.WriteLine($"Максимальное число из двух {a}");
if(b>a && b>c)
    System.Console.WriteLine($"Максимальное число из двух {b}");
if(c>a && c>b)
    System.Console.WriteLine($"Максимальное число из двух {c}");