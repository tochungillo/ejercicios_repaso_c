using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace DateTimeChallenge
{
    class Program
    {
        public static void date()
        {
            String respuesta = "", fecha = "";
            Boolean correcto = false;
            while (correcto == false)
            {
                Console.WriteLine("what date format you want to use? (dd/MM || MM/dd)");
                respuesta = Console.ReadLine();
                if (respuesta.Equals("dd/MM") || respuesta.Equals("MM/dd"))
                {
                    while (!correcto)
                    {
                        try
                        {
                            Console.WriteLine("Give me a date in format: " + respuesta);
                            fecha = Console.ReadLine();
                            double diferencia = 0.0;
                            /*int year = Int32.Parse(date.Substring(date.IndexOf("/", date.IndexOf("/") + 2) + 1));
                            int sec = Int32.Parse(date.Substring(date.IndexOf("/") + 1, 2));
                            int frs = Int32.Parse(date.Substring(0, 2));
                            diferencia = (DateTime.Today - new DateTime(year, sec, frs)).TotalDays;
                            */
                            DateTime dt = DateTime.ParseExact(fecha, respuesta+"/yyyy", CultureInfo.InvariantCulture);
                            diferencia = (DateTime.Today - dt).TotalDays;
                            Console.WriteLine(diferencia.ToString()+" days since "+fecha);
                            correcto = true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Has introducido una fecha incorrecta");
                            correcto = false;
                        }
                    }

                }
                else
                    Console.WriteLine("Has introducido un formato incorrecto");
            }
        }

        public static void time()
        {
            String respuesta = "", time = "", formato = "";
            Boolean correcto = false;
            while (correcto == false)
            {
                Console.WriteLine("what time format you want to use? (HH for 24 || hh form 12)");
                respuesta = Console.ReadLine();
                if (respuesta.Equals("HH") || respuesta.Equals("hh"))
                {
                    while (!correcto)
                    {
                        Console.WriteLine("Give me a time");
                        time = Console.ReadLine();
                        try
                        {
                            DateTime tm = DateTime.ParseExact(time, respuesta+":mm:ss", CultureInfo.InvariantCulture);
                            var diferencia = DateTime.Now.TimeOfDay - tm.TimeOfDay;
                            Console.WriteLine(diferencia+" time since "+time);
                            correcto = true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Has introducido una hora incorrecta");
                            correcto = false;
                        }
                    }
                }
                else
                    Console.WriteLine("Has introducido un formato incorrecto");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("write 1 to compare date, write 2 to compare time");
            String r = Console.ReadLine();
            if (r.Equals("1"))
                date();
            if (r.Equals("2"))
                time();
        }
    }
}
