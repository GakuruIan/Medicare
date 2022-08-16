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
    public partial class Edit : Form
    {
        private int? AppointmentID;
        private DataAccess data;
        public Edit(int? id)
        {
            InitializeComponent();
            this.AppointmentID = id;
            data = new DataAccess();
            doctorList.DataSource = data.ListAllDoctors();
            doctorList.DisplayMember = "Fullname";
            doctorList.ValueMember = "DoctorID";
            var Data = data.GetAppointment(this.AppointmentID);
            foreach(var info in Data)
            {
                Fullname.Text=info.Fullname;
                email.Text = info.Email;
            }
         
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if ((Fullname.Text != "") && (email.Text != "") && (doctorList.SelectedValue.ToString() != "") && (dayofAppointment.Text != ""))
            {

                data.UpdateAppointment(Fullname.Text, email.Text, int.Parse(doctorList.SelectedValue.ToString()), dayofAppointment.Text,this.AppointmentID);
                MessageBox.Show("Appointment Updated succefully", "Appointment Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Fullname.Text = "";
                email.Text = "";
                doctorList.SelectedItem = "";
                dayofAppointment.Text = "";
            }
            else
            {
                MessageBox.Show("Filling in all the field", "Empty Input");
            }
        }
    }
}
