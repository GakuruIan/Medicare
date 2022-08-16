using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Medcare
{
     public class DataAccess
    {
        //getting a list of all appointments && filter using doctor 
        public async Task<List<Appointments>> GetAppointments(int doctorID=0)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Connval("medwinDB")))
            {
                if (doctorID == 0)
                {
                    return await Task.Run(()=> connection.Query<Appointments>("dbo.GetAppointments").ToList());  
                }
                return await Task.Run(()=> connection.Query<Appointments>("dbo.GetAppointmentsByDoctor @Doctor", new { Doctor = doctorID }).ToList());
            }
        }
        //getting a single appointment
        public List<Appointments> GetAppointment(int? id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Connval("medwinDB")))
            {
                return connection.Query<Appointments>("dbo.GetAppointment @appointmentID ",new {AppointmentID =id }).ToList();
            }
        }

        
        //Inserting Appointment
        public void InsertAppointment(string fullname,string email,int doctor,string date)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Connval("medwinDB")))
            {
                List<Appointments> appointment = new List<Appointments>();
                appointment.Add(new Appointments { Fullname=fullname,Email=email, Doctor=doctor,Day=date});
                connection.Execute("dbo.Insert_Appointment @Fullname,@Email,@Doctor,@Day",appointment);
            }
        }
        //Updating Appointment
        public void UpdateAppointment(string fullname,string email,int doctor,string date,int? id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Connval("medwinDB")))
            {
                List<Appointments> appointment = new List<Appointments>();
                appointment.Add(new Appointments { Fullname = fullname, Email = email, Doctor = doctor, Day = date,AppointmentID=id});
                connection.Execute("dbo.UpdateAppointment @fullname,@email,@doctor,@day,@appointmentID", appointment);
            }
        }
        //Delete An appointment
        public void DeleteAppointment(int? ID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Connval("medwinDB")))
            {
                connection.Execute("dbo.DeleteAppointment @appointmentID",new { AppointmentID=ID });
            }
        }

        //Adding doctor to DB
        public void InsertDoctor(string fullname,string email,string profession,string contact)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Connval("medwinDB")))
            {
                List<Doctor> doctor = new List<Doctor>();
                doctor.Add(new Doctor { Fullname = fullname, Email = email, Profession = profession, Contact = contact });
                connection.Execute("dbo.Insert_Doctor @Fullname ,@Email,@Profession,@Contact", doctor);
            }
              
        }
        //getting a list of Doctors && and a single Doctor
        public async Task<List<Doctor>> ListAllDoctors(string name=null)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Connval("medwinDB")))
            {
                if (name == null)
                {
                    return await Task.Run(()=>connection.Query<Doctor>("dbo.GetDoctors").ToList());
                }
                return await Task.Run(() => connection.Query<Doctor>("dbo.GetDoctorByName @Fullname", new { Fullname = name }).ToList());
            }
        }
        public List<Doctor> GetDoctorByID(int id = 0)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Connval("medwinDB")))
            {
                return connection.Query<Doctor>("dbo.GetDoctor @doctorID", new { DoctorID = id }).ToList();
            }
        }
        //Deleting a Doctor
        public void DeleteDoctor(int? id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Connval("medwinDB")))
            {
                connection.Execute("DeleteDoctor @doctorID", new { doctorID = id });
            }
        }
        public void UpdateDoctor(string fullname, string email, string profession, string contact,int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Connval("medwinDB")))
            {
                List<Doctor> doctor = new List<Doctor>();
                doctor.Add(new Doctor { Fullname = fullname, Email = email, Profession = profession, Contact = contact,DoctorID=id });
                connection.Execute("UpdateDoctor @fullname,@email,@profession,@contact,@doctorID", doctor);
            }
        }

    }

}
