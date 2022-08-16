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
    public partial class EditDoc : Form
    {
        private int ID;
        private Childforms form;
        private DataAccess data;
        public EditDoc(int id)
        {
            this.ID = id;
            InitializeComponent();
            data = new DataAccess();
            var information = data.GetDoctorByID(this.ID);
            foreach(var info in information)
            {
                fullname.Text = info.Fullname;
                email.Text = info.Email;
                contact.Text = info.Contact;
                profession.Text = info.Profession;
            }
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if ((fullname.Text != "") && (email.Text != "") && (profession.Text != "") && (contact.Text != ""))
            {
                data.UpdateDoctor(fullname.Text, email.Text, profession.Text, contact.Text,this.ID);
                MessageBox.Show("Doctor Updated successfully", "Confirmation Message");
            }
            else
            {
                MessageBox.Show("Fill in all inputs", "Empty input");
            }
        }
    }
}
