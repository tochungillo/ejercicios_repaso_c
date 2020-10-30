using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileChallange
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int age = 0;
            User user = new User(firstName.Text.ToString(),LastName.Text.ToString(),age,alive.Checked);
            users.Add(user);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usersList.Items.Clear();
            foreach (User u in users)
                usersList.Items.Add(u.getFirstName() + " " + u.getLastName() + " " + u.getAge().ToString() + " and is " + u.getAlive());
        }
    }
}
