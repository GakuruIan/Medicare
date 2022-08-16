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
    public partial class Appointments : Form
    {
        private Childforms form;
        private DataAccess data;
        private int? ID;
        public Appointments()
        {
            data = new DataAccess();
            form = new Childforms();
            InitializeComponent();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            btnPanel.Dispose();
            form.openChildForms(new Create(), subPanel);
        }

        private void subPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Appointments_Load(object sender, EventArgs e)
        {
            var appointments = await data.GetAppointments();
            AppointmentList.DataSource = appointments;
            filterList.DataSource = await data.ListAllDoctors(); ;
            filterList.DisplayMember = "Fullname";
            filterList.ValueMember = "DoctorID";
            number.Text= appointments.Count.ToString();
        }

        private async void Filterbtn_Click(object sender, EventArgs e)
        {
            // data.GetAppointments();
            var appointments= await data.GetAppointments(int.Parse(filterList.SelectedValue.ToString()));
            AppointmentList.DataSource = appointments;
            number.Text = appointments.Count.ToString();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            btnPanel.Dispose();
            topPanel.Dispose();
            int rowno = AppointmentList.CurrentRow.Index;
            this.ID = int.Parse(AppointmentList.Rows[rowno].Cells[0].Value.ToString());
            if (ID == null)
           {
                MessageBox.Show("Please Select Appointment to Update","Update");
               return;
            }
            form.openChildForms(new Edit(this.ID), subPanel);
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            int rowno = AppointmentList.CurrentRow.Index;
            this.ID = int.Parse(AppointmentList.Rows[rowno].Cells[0].Value.ToString());
            if (this.ID == null)
            {
                MessageBox.Show("Please Select Appointment to Delete", "Delete information");
                return;
            }
            data.DeleteAppointment(this.ID);
            MessageBox.Show("Appointment Deleted", "Delete information");
            form.openChildForms(new Resources.Appointments(), subPanel);
        }
    }
}
