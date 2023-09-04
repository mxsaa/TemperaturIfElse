using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturIfElseWhile
double temp;

while (true)
{
    Console.Write("Skriv inn temperatur: ");

    if (double.TryParse(Console.ReadLine(), out temp))
    {
        if (temp > 0)
        {
            Console.WriteLine("Temperaturen er positiv.");
        }
        else if (temp < 0)
{
    Console.WriteLine("Temperaturen er negativ.");
}
else
{
    Console.WriteLine("Temperaturen er null.");
}

break;
    }
    else
{
    Console.WriteLine("Ugyldig verdi er inntastet. Prøv igjen.");
}
}

