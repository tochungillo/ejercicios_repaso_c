using System;

namespace DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "", b = "", c = "", d = "";
            Boolean correcto = false;
            while (correcto == false)
            {
                Console.WriteLine("what date format you want to use? (dd/MM/yy || MM/dd/yy)");
                a = Console.ReadLine();
                if (a.Equals("dd/MM/yy"))
                    correcto = true;
                if (a.Equals("MM/dd/yy"))
                    correcto = true;
            }
            correcto = false;
            while (correcto == false)
            {
                Console.WriteLine("Give me a date");
                b = Console.ReadLine();
            }
            
            correcto = false;
            while (correcto == false)
            {
                Console.WriteLine("what time format you want to use? (24 || 12)");
                c = Console.ReadLine();
            }
            
            correcto = false;
            while (correcto == false)
            {
                Console.WriteLine("Give me a time");
                d = Console.ReadLine();
            }

            Console.WriteLine(a+" "+b+" "+c+" "+d);
        }
    }
}
