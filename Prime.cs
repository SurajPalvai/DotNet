
int i;
Console.WriteLine("Enter the value");
i = Convert.ToInt32(Console.ReadLine());
for (int i; i <= 100)
{
  bool isPrimeNumber = true;
    for (var j = 2; j <= i; j++)
    {
        if (i % j == 0)
        {
            isPrimeNumber = false;
            Console.Write("Not a Prime Number", int i);
            break;
        }
    }
            if (isPrimeNumber)
         Console.Write("Yes It is a Prime Number", int i);
        
 }
        