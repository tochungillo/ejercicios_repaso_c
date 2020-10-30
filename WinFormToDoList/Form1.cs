using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            preference.Maximum = doList.Items.Count + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doList.Items.Add((doList.Items.Count+1).ToString()+": "+description.Text.ToString());
            preference.Maximum = doList.Items.Count +1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Decimal.ToInt32(preference.Value) <= doList.Items.Count)
            {
                List<string> save = new List<string>();
                for (int i = 0; i < doList.Items.Count; i++)
                {
                    if (Decimal.ToInt32(preference.Value) - 1 != i)
                    {
                        string[] s = doList.Items[i].ToString().Split(':');
                        save.Add(s[1].Substring(1));
                    }
                }
                //para borrar lo seleccionado en la lista
                //doList.Items.RemoveAt(index);
                doList.Items.Clear();
                for (int i = 0; i < save.Count; i++)
                    doList.Items.Add((1 + i).ToString() + ": " + save[i].ToString());
                preference.Maximum = doList.Items.Count + 1;
            }
            else MessageBox.Show("la preferencia debe ser una posicion de la tarea");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Decimal.ToInt32(preference.Value) > doList.Items.Count)
                MessageBox.Show("la preferencia debe ser una posicion de la tarea");
            else
                doList.Items[Decimal.ToInt32(preference.Value) - 1] = Decimal.ToInt32(preference.Value).ToString() + ": " + description.Text.ToString();
        }

        private void doList_SelectedIndexChanged(object sender, EventArgs e)
        {
            preference.Maximum = doList.Items.Count + 1;
            if (doList.SelectedIndex + 1 == 0) preference.Value = 1;
            else preference.Value = doList.SelectedIndex + 1;
            if (doList.SelectedItem != null)
            {
                string[] s = doList.SelectedItem.ToString().Split(':');
                description.Text = s[1].Substring(1);
            }
            else description.Text = "";
        }

        private void preference_ValueChanged(object sender, EventArgs e)
        {
            preference.Maximum = doList.Items.Count + 1;
        }
    }
}
