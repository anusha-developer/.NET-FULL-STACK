using Employee.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Employee.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/getEmployee")]
        public List<Employeedata> GetEmployee()
        {
            List<Employeedata> employee = new List<Employeedata>();
            Employeedata employeedata = new Employeedata();
            SqlConnection con = new SqlConnection("data source=.; database=employee;integrated security=SSPI");
            try
            {
                con.Open();
                string query = "select * from Employee";
                SqlCommand cm = new SqlCommand(query, con);
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    employeedata = new Employeedata();
                    employeedata.EmployeeId = Convert.ToInt32(dr["EmployeeId"]);
                    employeedata.EmployeeName = Convert.ToString(dr["EmployeeName"]);
                    employeedata.EmployeeDesignation = Convert.ToString(dr["EmployeeDesignation"]);
                    employeedata.EmployeeSalary = Convert.ToInt32(dr["EmployeeSalary"]);
                    employee.Add(employeedata);
                }


            }
            catch (Exception ex)
            {

            }
            return employee;
        }

            // GET: api/Employee
            public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        [HttpPost]
        [Route("api/insertEmployee")]
        public string insertEmployeedata([FromBody] Employeedata employee)
        {

            try
            {
                SqlConnection con = new SqlConnection("data source=.; database=employee;integrated security=SSPI");
                con.Open();
                SqlCommand cm = new SqlCommand("insert into Employee values(" + employee.EmployeeId + ", '" + employee.EmployeeName + "'," +
                    "'" + employee.EmployeeDesignation + "','" + employee.EmployeeSalary + "');", con);
                SqlDataReader dr = cm.ExecuteReader();
            }
            catch (Exception ex)
            {

            }
            return " insert data sucessfully";
        }


        // PUT: api/Employee/5
        [HttpPut]
        [Route("api/UpdateEmployee")]
        public string UpdateEmployee(int EmployeeId, [FromBody] Employeedata empdata)
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=.; database=employee;integrated security=SSPI");
                con.Open();
                SqlCommand cm = new SqlCommand("Update Employee empdata set  EmployeeName='" + empdata.EmployeeName + "',EmployeeDesignation='" + empdata.EmployeeDesignation + "'," +
                    "EmployeeSalary='" + empdata.EmployeeSalary + "' where Id=2", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

            }
            return "data updated";
        }

        // DELETE: api/Employee/5
        [HttpDelete]
        [Route("api/DeleteEmployee")]
        public string Employeedata(int EmployeeId)
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=.; database=employee;integrated security=SSPI");
                con.Open();
                string query = "delete from Employee where EmployeeId=" + EmployeeId + "";
                SqlCommand cm = new SqlCommand(query, con);
                SqlDataReader dr = cm.ExecuteReader();
            }
            catch (Exception ex)
            {

            }
            return "deleted";
        }
    }
}
