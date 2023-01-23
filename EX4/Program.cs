System.Console.WriteLine("Ведите число (N): ");
String stringValue = Console.ReadLine();
int n = Convert.ToInt32(stringValue);

for(int i = 0 ; i<=n; i++)
    if (i%2==0)
        System.Console.WriteLine(i);