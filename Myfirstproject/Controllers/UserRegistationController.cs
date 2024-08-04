using Myfirstproject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Myfirstproject.Controllers
{
    public class UserRegistationController : Controller
    {
        // GET: UserRegistation
        public ActionResult Index()
        {
            return View("Signup");
        }
       AppSettingsReader aps = new AppSettingsReader();
        [HttpPost]
        public string Sdfetch(Sdata fetch)
        {
            SqlConnection con = new SqlConnection(aps.GetValue("ConnectionString", typeof(System.String)).ToString());
            if (fetch.Password == fetch.RePassword)
            {


                con.Open();
                string sql = "insert into Firstproject(FName, LName, Email, Phone, UserName, Password, Repassword) Values (@name, @lastname, @email, @phone, @username, @password,@repassword)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", fetch.Name);
                cmd.Parameters.AddWithValue("@lastname", fetch.LastName);
                cmd.Parameters.AddWithValue("@email", fetch.Email);
                cmd.Parameters.AddWithValue("@phone", fetch.Phone);
                cmd.Parameters.AddWithValue("@username", fetch.UserName);
                cmd.Parameters.AddWithValue("@password", fetch.Password);
                cmd.Parameters.AddWithValue("@repassword", fetch.RePassword);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return "true";
            


            //string name = fetch.Name;
            //if (fetch.Password != fetch.RePassword)
            //{
            //    return "false";
            //}
            //if(fetch.UserName.Length> 0)
            //{
            //    return "true";
            //}
            //else
            //{
            //    return "false";
            //}
              


            


           // string lastName = fetch.LastName;)
            //string email = fetch.Email;
           // string phone = fetch.Phone;
            //string userName = fetch.UserName;
            //string password = fetch.Password;
            //string RePassword = fetch.RePassword;
            //Logindata newdata = new Logindata();
            //newdata.Username = fetch.UserName;
           // return View("~/Views/Home/Information.cshtml",newdata);


            
        }
        [HttpPost]
        public string AJAXTEST(string UserName, string Password)
        {
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                return "Got user name and password";
            }
            else
            {
                return "Did not get username and password";
            }
        }
    }
    public class Sdata
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }




    }

}