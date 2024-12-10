using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Runtime.CompilerServices;

class Prova
{
    private Thread Huston;
    private Thread CapeCanaveral;
    static int tempo1;
    static int tempo2;

    static void Main()
    {
        Thread houstonThread = new Thread(CountdownHouston);
        Thread capeThread = new Thread(CountdownCapeCanaveral);

        // Avvia i thread
        houstonThread.Start();
        capeThread.Start();
        
            

    }

    static void CountdownHouston()
    {
        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine($"Houston: {i}");
            Thread.Sleep(1000); // Pausa di 1 secondo
        }
        Console.WriteLine("Houston: Go!");
    }

    static void CountdownCapeCanaveral()
    {
        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine($"CapeCanaveral: {i}");
            Thread.Sleep(1000); // Pausa di 1 secondo
        }
        Console.WriteLine("CapeCanaveral: Go!");
    }
}