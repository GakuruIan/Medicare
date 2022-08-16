using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medcare.Resources
{
    class Childforms
    {
        protected Form activeForm;
        public void openChildForms(Form childForm,Panel mainPanel)
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
    }
}
