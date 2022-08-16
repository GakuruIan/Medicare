using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medcare
{
    public  class Appointments
    {
        public int? AppointmentID { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public int? Doctor { get; set; }
        public string Day { get; set; }
        public string DoctorName { get; set; }

        
    }
}
