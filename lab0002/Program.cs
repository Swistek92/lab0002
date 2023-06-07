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
        else if (zadanie == 4)
        {
            zadanie4();
            Main();
        }
        else if(zadanie == 5)
        {
            zadanie5();
            Main();
        }
        else if (zadanie == 6)
        {
            zadanie6();
            Main();
        }
        else if (zadanie == 7)
        {
            zadanie7();
            Main();
        }
        else if (zadanie == 8)
        {
            zadanie8();
            Main();
        }
        else if (zadanie == 9)
        {
            zadanie9();
            Main();
        }
        else if (zadanie == 10)
        {
            zadanie10();
            Main();
        }
        else if (zadanie == 0)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("narazie mamy tylko zadania od 1 do 8 jesli chcesz wyjsc wścisnij 0, powodzenia");
            Main();
        }
    }



    private static void zadanie1()
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


    private static void zadanie2()
    {
        Console.WriteLine("Program do obliczania obwodu koła");
        double promien, obwod;
        Console.WriteLine("podaj pole koła:");
        double pole = inputValue();
        promien = Math.Sqrt(pole / Math.PI);
        obwod = promien * Math.PI * 2;
        Console.WriteLine("Obwod Koła to " + obwod);
        
    }

    private static void zadanie3()
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

    private static void zadanie4()
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
        else if (b == d)
        {
            int x = a + c;
            Console.WriteLine("Twój licznik to: " + x);
            Console.WriteLine("Twój mianownik to: " + d);
            Console.ReadKey();
        }
        else if (b != d)
        {
            int y = b * d;
            a = a * d;
            c = c * b;
            int x = a + c;
            Console.WriteLine("Twój licznik to: " + x);
            Console.WriteLine("Twój mianownik to: " + y);
            Console.ReadKey();
        }


    }

    private static void zadanie5()
    {

        Console.WriteLine("Podaj 5 liczby a znajde najwieksza:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());



        int[] tablica = { a, b, c, d };

        Console.WriteLine("największa wartość to " + tablica.Max());

    }
    private static void zadanie6()
    {
        Console.WriteLine("podaj 3 wartosci długości boków trójkąta:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if(a==b && b==c && c == a)
        {
            Console.WriteLine("gratulacje, powstanie trójkąt równoboczny");
        }
        else
        {
            Console.WriteLine("nie powstanie trójkąt równoboczny :( ");

        }
    }
    private static void zadanie7() {
        double x, y, r;

        Console.WriteLine("podaj x");
        x = inputValue();
        Console.WriteLine("podaj y");
        y= inputValue();
        Console.WriteLine("podaj r");
        r = inputValue();

        if (x * x + y * y <= r * r) {
            Console.WriteLine("wpisane współrzedne znajduja sie w obrębie koła");

                }else
        {
            Console.WriteLine("wspisane współrzędne NIE  znajduja sie obrębie koła");
        }


    }

    private static void zadanie8() {
        Console.WriteLine("wprowadź dwie liczby ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("wybierz typ działania: 1- dodawanie, 2- odejmowanie, 3- mnożenie, 4- dzielenie");
        int d = Convert.ToInt32(Console.ReadLine());
        int wynik;
        if (d == 1)
        {
            wynik = x + y;
            Console.WriteLine("Wynik dodawania wynosi: " + wynik);
            Console.ReadKey();
        }
        else if (d == 2)
        {
            wynik = x - y;
            Console.WriteLine("Wynik odejmowania wynosi: " + wynik);
            Console.ReadKey();
        }
        else if (d == 3)
        {
            wynik = x * y;
            Console.WriteLine("Wynik mnożenia wynosi: " + wynik);
            Console.ReadKey();
        }
        else if (d == 4)
        {
            if (y == 0)
            {
                Console.WriteLine("Wynik dzielenia wynosi: " + x + " / " + y);
                Console.ReadKey();
            }
            else
            {
                wynik = x / y;
                Console.WriteLine("Wynik dzielenia wynosi: " + wynik);
                Console.ReadKey();
            }
        }


    }

    private static void zadanie9()
    {
        Console.WriteLine("wprowadź  3 liczby ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        a = a + b + c;
        b = a - (b + c);
        c = a - (b + c);
        a = a - (b + c);

        Console.WriteLine("a=" +a + " b=" + b + " c=" + c);

    }
    private static void zadanie10()
    {
        Console.WriteLine("wprowadź liczbe ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = a % 10;

        Console.WriteLine("ostatnia cyfra to" + b);


    }

    private static void zadanie11()
    {
        
        int x, y;
        x = 1;
        y = 1;
        if (x <= -2) {
            y = -1;
        }if (x > -2 && x > -1)
        {
            y = x - y;
        }
    }




    static private int GetPow(int baseNum, int powNum)

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
