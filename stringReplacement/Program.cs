using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace stringReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\andy9\Documents\DVI Miguel\Tema1\ejercicios_repaso_c\ejercicios_repaso_c\stringReplacement\stringReplacement.txt";
            List<string> lineas = File.ReadAllLines(filepath).ToList();
            Console.WriteLine("palabra a buscar");
            string palabra = Console.ReadLine();
            Console.WriteLine("palabra sustituidora");
            string sustituidora = Console.ReadLine();
            // extra muestra el texto actual
            foreach(string l in lineas) Console.WriteLine(l);
            // recorrer la lista
            for (int i = 0; i < lineas.Count; i++)
            {
                // obtiene las palabras
                string[] l = lineas[i].Split(' ');
                // mira si es una palabra para sustituir
                for (int j = 0; j < l.Length; j++)
                    if (l[j].Equals(palabra)) l[j] = sustituidora;
                // guarda la linea
                string nueva = "";
                foreach (string s in l) nueva += s+" ";
                lineas[i] = nueva;
            }
            Console.WriteLine("se sustituyo "+palabra+" por "+sustituidora);
            // guardar en el archivo de texto las lineas
            File.WriteAllLines(filepath, lineas);
            foreach (string l in lineas) Console.WriteLine(l);
        }
    }
}
