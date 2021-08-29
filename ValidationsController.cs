using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Validationform.Controllers
{
    public class ValidationsController : ApiController
    {
        [HttpGet]
        [(Route("api/tblValidation")]
        public List<validationvad> GettblValidation()
        {
            List<validationvad> v = new List<validationvad>();
            validationvad validation = new validationvad();
            SqlConnection con = new SqlConnection("data source=.;database=company,integrated security=SSPI");
            con.Open();
            string query = "select * from tblValidation";
            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                validation = new validationvad();
                validation.Id = Convert.ToInt32(dr["Id"]);
                validation.Firstname = dr["validation"].ToString();
                validation.Lastname = dr["Lastname"].ToString();
                validation.Username = dr["Username"].ToString();
                validation.City = dr["City"].ToString()
                validation.State = dr["State"].ToString();
                validation.Zip = Convert.ToInt32(dr["Zip"]);
                validation.Country = dr["Country"].ToString();

                v.Add(validation);

            }

            return v;
        }




        // GET: api/Validations
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Validations/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Validations


        [HttpPost]
        [Route("api/inserttblValidation")]

        public string insertblValidation([FromBody] validationvad validate)

        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source =.;database=company,integrated security=SSPI");
                con.Open();
                SqlCommand cm = new SqlCommand("insert into tblValidation values(" + validate.Id + ",'" + validate.Firstname + "'," + validate.Lastname + ",'" + validate.Username + "','" + validate.City + "','" + validate.State + "'," + validate.Zip + ",'" + validate.Country + "');", con);
                SqlDataReader dr = cm.ExecuteReader();


            }
            catch (Exception ex)
            {

            }
            return "inserted data successfully";


        }



        // PUT: api/Validations/5
        [HttpPut]
        [Route("api/updatetblValidation")]

        public string updatetblValidation(int id, [FromBody] tblValidation valiaddata)
        {
            SqlConnection con = new SqlConnection("data source=.;database=company,integrated security=SSPI");
            con.Open();
            SqlCommand cm = new SqlCommand("update valiaddata set Firstname='" + valiaddata.Firstname + "',lastname = '" + valiaddata.lastname + "' where id=2", con);
            cm.ExecuteNonQuery();
            con.Close();
            return "updated";
        }
        public void Put(int id, [FromBody]string value)
        {
            [HttpDelete]
            [Route("api/tblValidation")]
            public string tblValidation(int Personid)
            {

                SqlConnection con = null;
                try
                {
                    con = new SqlConnection("data source=.;database=Task,integrated security=SSPI");
                    con.Open();
                    string query = "delete from tblValidation where Id='" + Id + "' ";
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

        // DELETE: api/Validations/5
        public void Delete(int id)
        {
        }
    }
}
