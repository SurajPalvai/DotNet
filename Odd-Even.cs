
        int number, remainder;
        Console.Writeline("p]s Enter an Integer Value");
        number = Convert.ToInt32(Console.ReadLine());
        remainder = number % 2;
        if (remainder == 0)
            Console.Writeline("(0) is an Even Number", number);
        else
            Console.Writeline("(0) is an Odd Number", number);
        Console.Writeline("Press any key to exit");
        Console.ReadKey();