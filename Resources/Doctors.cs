using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medcare.Resources
{
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            if ((fullname.Text != "") && (email.Text != "") && (profession.Text != "") && (contact.Text != ""))
            {
                StringBuilder name = new StringBuilder();
                name.Append($"Dr {fullname.Text}");
               data.InsertDoctor(name.ToString(), email.Text, profession.Text, contact.Text);
                MessageBox.Show("Doctor Added successfully","Confirmation Message");
                fullname.Text = "";
                email.Text = "";
                profession.Text = "";
                contact.Text = "";
            }
            else
            {
                MessageBox.Show("Fill in all inputs","Empty input");
            }
        }
    }
}
