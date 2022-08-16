using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medcare
{
    public partial class Dashboard : Form
    {
        private Form activeForm;
        private Panel MainPanel;
        public Dashboard()
        {
            this.MainPanel = mainPanel;
            InitializeComponent();
        }
        public void openChildForms(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
       
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            openChildForms(new Resources.Appointments());
        }

        private void gunaAdvenceButton3_Click_1(object sender, EventArgs e)
        {
            int ID = 1;
            openChildForms(new Resources.DocList());
        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            this.activeForm.Dispose();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
