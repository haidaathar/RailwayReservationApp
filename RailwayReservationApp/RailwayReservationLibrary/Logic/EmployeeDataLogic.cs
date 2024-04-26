
using RailwayReservationLibrary.DataAccess;
using RailwayReservationLibrary.Entities;
using System.Data.SqlClient;

namespace RailwayReservationLibrary.Logic
{
    public class EmployeeDataLogic
    {
        public int CreateEmployee(Employee employee)
        {
            using(SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                string query = $"Insert into Employees (FirstName, LastName, CNIC, DateOfBirth, Gender, Address, PostalCode, City, Country, Email, ContactNumber, Designation, Department, Password) VALUES ('{employee.FirstName}', '{employee.LastName}', '{employee.CNIC}', '{employee.DOB}', '{employee.Gender}', '{employee.Address}', '{employee.PostalCode}', '{employee.City}', '{employee.Country}', '{employee.Email}', '{employee.Contact}', '{employee.Designation}', '{employee.Department}', '{employee.Password}');";

                SqlCommand cmd = new SqlCommand(query, connection);
                
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
