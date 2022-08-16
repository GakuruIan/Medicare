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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }
        private DataAccess data;
        private void Create_Load(object sender, EventArgs e)
        {
            data = new DataAccess();
            doctorSelection.DataSource = data.ListAllDoctors();
            doctorSelection.DisplayMember = "Fullname";
            doctorSelection.ValueMember = "DoctorID";
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
             data = new DataAccess();
            if((fullname.Text != "") && (email.Text != "") && (doctorSelection.SelectedValue.ToString() != "") && (dayofAppointment.Text !=""))
            {
               
                data.InsertAppointment(fullname.Text, email.Text, int.Parse(doctorSelection.SelectedValue.ToString()),dayofAppointment.Text);
                MessageBox.Show("Appointment reserved","Appointment Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                fullname.Text = "";
                email.Text = "";
                doctorSelection.SelectedItem = "";
                dayofAppointment.Text = "";
            }
            else
            {
                MessageBox.Show("Filling in all the field", "Empty Input");
            }
        }
    }
}
