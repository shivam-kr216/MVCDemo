using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace BusinessLayer { 
{
    class EmployeeBusinessLayer
    {
        //string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        List<Employee> employees = new List<Employee>();

        /*using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Employee employee = new Employee();
                employee.ID = Convert.ToInt32(rdr["Id"]);
                employee.Name = rdr["Name"].ToString();
                employee.Gender = rdr["Gender"].ToString();
                employee.City = rdr["City"].ToString();
                //employee.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);
                employees.Add(employee);
            }*/
        }
    }
}
