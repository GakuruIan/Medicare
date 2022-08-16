# Medicare
Medicare is a simple hospital appointment reservation built using C# and Guna Framework.

## Resources
1)Guna framework -> For UI components.

2)Dapper -> For Object-Relational Mapper.

3)SQL Server -> Storage.

## Project structure
The Resource folder contains all the sub forms used in the project.

The DB connection string is found in the app.config file.

Helper class provides static method for connecting with the database.

DataAccess class contains methods that provide interaction with the database i.e Inserting an appointment to the database.

Appointments and Doctor class provide the structure used by Dapper for mapping.

## installing depencies 
Under the project in vs click on nuget manager and search for dapper.


