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

namespace SearchingForDataChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string patron = match.Text;

            string filepath = @"C:\Users\andy9\Documents\DVI Miguel\Tema1\ejercicios_repaso_c\ejercicios_repaso_c\SearchingForDataChallenge\primary.txt";
            linebox.Items.Clear();
            List<string> lineas = File.ReadAllLines(filepath).ToList();
            foreach (string l in lineas)
            {
                bool contains = false;
                string[] palabras = l.Split(' ');
                int i = 0;
                while (contains == false && (i < palabras.Count()))
                {
                    if (palabras[i].ToUpper().Contains(patron.ToUpper())) contains = true;
                    i++;
                }
                if (contains) linebox.Items.Add(l);
            }
        }
    }
}
