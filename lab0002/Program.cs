using System;

public class Lab01
{
    public static void Main()
    {
        double zadanie;
        Console.WriteLine("ktory program chcesz rozwiazac? jesli chcesz wyjsc wybierz 0 ");
        zadanie = inputValue();
        if (zadanie == 1)
        {
            zadanie1();
            Main();
        }
        else if (zadanie == 2)
        {
            zadanie2();
            Main();
        }
        else if (zadanie == 3)
        {
            zadanie3();
            Main();
        }
        else if (zadanie == 0)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("narazie mamy tylko zadanie number 1");
            Main();
        }
    }



    public static void zadanie1()
    {

        double a, b, c;
        Console.WriteLine("Program do obliczania średniej arytmetycznej");
        Console.WriteLine("");
        Console.WriteLine("podaj 1 wartosć:");
        a = inputValue();
        Console.WriteLine("podaj 2 wartosć:");
        b = inputValue();
        Console.WriteLine("podaj 3 wartosć:");
        c = inputValue();

        double sredniaArytmetyczna;

        sredniaArytmetyczna = (a + b + c) / 3;
        Console.WriteLine("srednia arytmetyczna to " + sredniaArytmetyczna);
    }


    public static void zadanie2()
    {
        double a, b, promien, obwod;
        Console.WriteLine("Program do obliczania obwodu koła");
        Console.WriteLine("podaj pole koła:");
        // pole = pi * r^2
        // obwód 2 * pi * r
        a = inputValue();
        b = a / Math.PI;
        promien = Math.Sqrt(b / Math.PI);
        obwod = 2 * Math.PI * promien;
        Console.WriteLine("obwód koła to  " + obwod);
    }

    public static void zadanie3()
    {
        string val;
        int res;
        double waga, b;
        int bmi, wzrostINT, wzrost2, wagaInt;
        Console.WriteLine("Program do obliczania BMI");
        Console.WriteLine("podaj wage w kg");
        waga = inputValue();
        Console.WriteLine("podaj wzrost w metrach");
        b = inputValue();
        wzrostINT = Convert.ToInt32(b);
        wagaInt = Convert.ToInt32(waga);
        wzrost2 = GetPow(wzrostINT, 2);
        bmi = wagaInt / wzrost2;
        Console.WriteLine("twoje bmi to : " + bmi);

    }

    public static void zadanie4()
    {
        Console.WriteLine("Podaj 4 liczby:");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());

        if (b == 0 || d == 0)
        {
            Console.WriteLine("brak rozwiazania");
            Main();
        }

    }

    static int GetPow(int baseNum, int powNum)

    {
        int result = 1;
        for (int i = 0; i < powNum; i++)
        {
            result = result * baseNum;
        }
        return result;

    }



    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
