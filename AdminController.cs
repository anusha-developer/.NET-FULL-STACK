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
    public class AdminController : ApiController
    {

        [HttpGet]
        [Route("api/getadmin")]
        public List<Admins> Getadmin(string email,string password)
        {
            List<Admins> Admin = new List<Admins>();
            Admins Admindata = new Admins();
            SqlConnection con = new SqlConnection("data source=.; database=employee;integrated security=SSPI");
            try
            {
                con.Open();
                string query = "select * from admin where email="+ email + ",password="+ password + "" ;
                SqlCommand cm = new SqlCommand(query, con);
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Admindata = new Admins();
                    Admindata.email = Convert.ToString(dr["email"]);
                    Admindata.password = Convert.ToString(dr["password"]);

                    Admin.Add(Admindata);
                }


            }
            catch (Exception ex)
            {

            }
            return Admin;
        }
            // GET: api/Admin
            public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Admin/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Admin
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Admin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Admin/5
        public void Delete(int id)
        {
        }
    }
}
