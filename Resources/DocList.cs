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
    public partial class DocList : Form
    {
        private Childforms form;
        private int ID;
        private DataAccess data;
        public  DocList()
        {
            data = new DataAccess();
            form = new Childforms();
            InitializeComponent();
          
            this.ID = 0;
            
        }
       
        private void gunaAdvenceButton4_Click_1(object sender, EventArgs e)
        {
            btnPanel.Dispose();
            form.openChildForms(new Doctors(), subPanel);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            int rowno = DoctorList.CurrentRow.Index;
            this.ID = int.Parse(DoctorList.Rows[rowno].Cells[0].Value.ToString());
            if (this.ID == 0)
            {
                MessageBox.Show("Please Select Doctor to Delete", "Delete information");
                return;
            }
            data.DeleteDoctor(this.ID);
            MessageBox.Show("Doctor Deleted Successfully", "Delete information");
            form.openChildForms(new Resources.DocList(), subPanel);
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            int rowno = DoctorList.CurrentRow.Index;
            this.ID = int.Parse(DoctorList.Rows[rowno].Cells[0].Value.ToString());
            if (this.ID == 0)
            {
                MessageBox.Show("Please Select Doctor to Update", "Update information");
                return;
            }
            form.openChildForms(new Resources.EditDoc(this.ID), subPanel);
        }

        private async void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            var Doctors = await data.ListAllDoctors();
            DoctorList.DataSource = Doctors;
            number.Text = Doctors.Count.ToString();
                
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            if(searchText.Text == "")
            {
                MessageBox.Show("Search String is Empty", "Empty input",MessageBoxButtons.OK);
                return;
            }
            var Doctors= await data.ListAllDoctors(searchText.Text);
            DoctorList.DataSource = Doctors;
            number.Text = Doctors.Count.ToString();

        }
    }
}
