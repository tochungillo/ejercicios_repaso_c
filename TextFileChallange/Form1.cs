using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileChallange
{
    public partial class Form1 : Form
    {
        // ruta del documento
        string filepath = @"C:\Users\andy9\Documents\DVI Miguel\Tema1\ejercicios_repaso_c\ejercicios_repaso_c\TextFileChallange\textfilechallenge.txt";
        // donde se guardaran las linas del documento
        List<string> lineas = new List<string>();
        List<User> users = new List<User>();
        public Form1()
        {
            // obtener todas las lineas del archivo de texto
            lineas = File.ReadAllLines(filepath).ToList();
            foreach (string l in lineas) 
            {
                string[] parte1 = l.Split(new string[] { ", " }, StringSplitOptions.None);
                string[] parte2 = parte1[1].Split(new string[] { " has an age of " }, StringSplitOptions.None);
                string[] parte3 = parte2[1].Split(new string[] { " and is " }, StringSplitOptions.None);
                users.Add(new User(parte1[0], parte2[0], Int32.Parse(parte3[0]), parte3[1]));
            }
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string pulse = "undead";
            if (alive.Checked)
                pulse = "alive";
            else
                pulse = "dead";
            User u = new User(firstName.Text.ToString(),LastName.Text.ToString(),Decimal.ToInt32(age.Value),pulse);
            lineas.Add(u.firstName + ", " + u.lastName + " has an age of " + u.age.ToString() + " and is " + u.pulse);
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // guardar en el archivo de texto las lineas
            File.WriteAllLines(filepath, lineas);
            usersList.Items.Clear();
            foreach (string l in lineas)
                usersList.Items.Add(l);
        }
    }
}
