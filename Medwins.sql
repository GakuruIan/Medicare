--create a database called medwins

--switch to medwins
use Medwins

 --to give information of the table created
exec sp_help Doctors

--creating Appointments table
create table TrialAppointments (AppointmentID int identity(1,1),Fullname varchar(60) not null,Email varchar(60) not null,Doctor int,Day varchar(40) not null,primary key(AppointmentID) ,foreign key(Doctor) references Doctors(DoctorID) on delete cascade);

--create Doctors table
create table TrailDoctors (DoctorID int identity(1,1),Fullname varchar(100) not null,Email varchar(60) not null,profession varchar(60) not null,Contact varchar(60) not null,primary key(DoctorID));

--Stored procedures 

--To create the stored procedures you have to put each on their own separate files for them to work
--each file should contain only one procedure otherwise it will produce an error


       --Insert Doctor procedure-- 

/*create procedure Insert_Doctors
--parameters of procedure
       @Fullname varchar(60),
       @Email varchar(30),
       @profession varchar(60),
       @Contact varchar(30)
as
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;

    -- Insert statements for procedure here
         INSERT INTO Doctors
         (Fullname, Email, profession, Contact)
     VALUES
         (@Fullname, @Email, @profession,  @Contact)
END

          --Getting a Doctor procedure 
/*
create procedure GetDoctor
--parameters of procedure
    @doctorID int
as
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;

    -- select statements for procedure here
         select * from Doctors
  where DoctorID = @doctorID
END

         --getting all doctors

create procedure GetDoctors
--parameters of procedure
    @doctorID int
as
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;

    -- select statements for procedure here
         select * from Doctors
END

              --Getting all Doctor by name procedure 

create procedure GetDoctorByName
--parameters of procedure
   @name varchar(60)
as
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;

    -- select statements for procedure here
select * 
from 
Doctors 
where Fullname like '%'+ @name +'%';
END

           --Updating Doctor

create procedure UpdateDoctor
--parameters of procedure
 @fullname varchar(60),
@email varchar(30),
@profession varchar(60),
@contact varchar(30),
@doctorID int
as
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;

    -- select statements for procedure here
update Doctors 
  set Fullname= @fullname ,Email =@email,profession =@profession ,Contact= @contact
  where DoctorID = @doctorID
END

      --Deleting a Doctor  procedure 

create procedure DeleteDoctor
--parameters of procedure
 @doctorID int
as
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;

    -- Delete statement
 delete Doctors
  where DoctorID = @doctorID
END


      --Getting an appointment  procedure 

create procedure GetAppointment
--parameters of procedure
 @appointmentID int
as
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;

    -- select statement
select * from Appointments where AppointmentID = @appointmentID
END


      --Getting all appointments  procedure 

create procedure GetAppointments
--parameters of procedure
 @appointmentID int
as
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;

    -- select statement
select AppointmentID,Appointments.Fullname,Appointments.Email,Appointments.Day , Doctors.Fullname as DoctorName
	  from Appointments 
	  join Doctors 
	  on Doctor = DoctorID;
END

     --insert procedure 

create procedure Insert_Appointments
--parameters of procedure
       @Fullname varchar(60),
       @Email varchar(60),
       @Doctor int,
       @Day varchar(60)
as
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;

    -- Insert statements for procedure here
       INSERT INTO Appointments
              (Fullname, Email, Doctor, Day)
       VALUES
              (@Fullname, @Email, @Doctor, @Day)
END

         --Getting appointmentsByDoctor

create procedure GetAppointmentsByDoctor
--parameters of procedure
@doctorID int
as
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;

    -- select statement
select AppointmentID,Appointments.Fullname,Appointments.Email,Appointments.Day ,Doctor, Doctors.Fullname as DoctorName
	  from Appointments 
	  join Doctors 
	  on DoctorID = Appointments.Doctor  
	  where  Doctor = @doctorID;

END

         --updating Appointment

create procedure UpdateAppointment
--parameters of procedure
@fullname varchar(60),
@email varchar(60),
@doctor int,
@day varchar(40),
@appointmentID int
as
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;

    -- select statement
update Appointments 
  set Fullname= @fullname ,Email=@email,Doctor=@doctor ,Appointments.Day=@day
  where AppointmentID =@appointmentID
END

       --Deleting appointments  procedure --

create procedure DeleteAppointment
--parameters of procedure
@appointmentID int
as
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;

    -- Delete statement
  delete Appointments
  where AppointmentID =@appointmentID
END

*/