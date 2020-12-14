using System;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine();
        Console.WriteLine("----Welcome to our Currency Converter----");
        Console.WriteLine();
        Console.WriteLine();
                
        Console.Write("Please insert the name of the actual currency in your country: ");
        Converter.currencyName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();
                
        Console.Write("Please insert how much one dollar is in your currency today (commercial quotation): $ ");
        Converter.dollarQuotation = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Please insert how much one euro is in your currency today (commercial quotation): $ ");            
        Converter.euroQuotation = float.Parse(Console.ReadLine());
        
        Console.Clear();

    do {

        Console.WriteLine();        
        Console.WriteLine("-----Currency Conversion Menu-----");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("[1] Convert dollars(U$) to your currency($)");
        Console.WriteLine();
        Console.WriteLine("[2] Convert your currency($) to dollars(U$)");
        Console.WriteLine();
        Console.WriteLine("[3] Convert euros(E$) to your currency($)");
        Console.WriteLine();
        Console.WriteLine("[4] Convert your currency($) to euros(E$)");
        Console.WriteLine();
        Console.WriteLine("[5] Exit Menu");
        Console.WriteLine();
        Console.WriteLine();
                
        Console.Write("Please choose an option above: ");
        Converter.choice = int.Parse(Console.ReadLine());

        
        
    switch (Converter.choice)
        
    {
                
        
        case 1:

        Console.Clear();                
        Console.WriteLine();
        Console.Write("Please insert amount of dollars: U$");
        Converter.dollarAmount = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Converter.Convert_Dollar_To_Currency(Converter.dollarAmount);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"U${Converter.dollarAmount.ToString("F")} = ${Converter.result1.ToString("F")} {Converter.currencyName}");
        Console.ResetColor();
        break;
                
        
        case 2:

        Console.Clear();            
        Console.WriteLine();
        Console.Write("Please insert amount of your currency: $");
        Converter.currencyAmount = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Converter.Convert_Currency_To_Dollar(Converter.currencyAmount);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"${Converter.currencyAmount.ToString("F")} {Converter.currencyName} = U${Converter.result2.ToString("F")}");
        Console.ResetColor();
        break;
                
        
        case 3:

        Console.Clear();            
        Console.WriteLine();
        Console.Write("Please insert amount of euros: E$");
        Converter.euroAmount = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Converter.Convert_Euro_To_Currency(Converter.euroAmount);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"E${Converter.euroAmount.ToString("F")} = ${Converter.result3.ToString("F")} {Converter.currencyName}");
        Console.ResetColor();
        break;
                
        
        case 4:

        Console.Clear();            
        Console.WriteLine();
        Console.Write("Please insert amount of your currency: $");
        Converter.currencyAmount = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Converter.Convert_Currency_To_Euro(Converter.currencyAmount);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"${Converter.currencyAmount.ToString("F")} {Converter.currencyName} = E${Converter.result4.ToString("F")}");
        Console.ResetColor();
        break;
                    
        
        case 5:
                    
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Thank you for using our Currency Converter");
        Console.WriteLine();
        break;
                
        
        default:

        Console.Clear();

        break;
        
    }

        
    } while (Converter.choice != 5);
        
        
        
        }
        
    }
}
