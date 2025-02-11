using System;  // Importing the System namespace

public class temperature  // Beskrivelse på oppgaven
{  
    public static void Main()  // Begynnelsen på programmet
    {
        int tmp;  // Stadfester ka temraturer skal vere i veri ( her er the inter)
        Console.Write("\n\n");  // Printer nye linjer i consollen
        Console.Write("Accept a temperature in centigrade and display a suitable message:\n");  // Viser funskjonen til programmet
        Console.Write("--------------------------------------------------------------------");  // Sepperator ( mellom rom I)
        Console.Write("\n\n");

        Console.Write("Input days temperature : ");  // Her skriver brukeren tempraturen, som skal bli målt
        tmp = Convert.ToInt32(Console.ReadLine());  // Leser av tallet brukeren har skrevet

        // Sjekker tempraturer gjennom de neste faktorane
        if (tmp < 0)
            Console.Write("Det er så kaldt det fryser.\n");  // Melding om at de er Det er så kaldt det fryser
        else if (tmp < 10)
            Console.Write("Det er veldig kaldt.\n");  //  Melding om at de er Det er veldig kaldt
        else if (tmp < 20)
            Console.Write("Det er kaldt.\n");  //  Melding om at de er Det er kaldt
        else if (tmp < 30)
            Console.Write("Det er normal tempratur.\n");  //  Melding om at de er normal temperatur.
        else if (tmp < 40)
            Console.Write("Det ar varmt.\n");  //  Melding om at de er Det ar varmt.
        else
            Console.Write("Det er veldig varmt.\n");  //  Melding om at de er Det er veldig varmt.
    }
}