System.Console.WriteLine("Ведите число: ");
String stringValue = Console.ReadLine();
int a = Convert.ToInt32(stringValue);

if(a%2==0)
    System.Console.WriteLine($"Это число является четным");
else
    System.Console.WriteLine($"Это число является нечетным");