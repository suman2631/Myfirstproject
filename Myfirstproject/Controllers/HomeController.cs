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
    public class HomeController : Controller
    {
        AppSettingsReader aps = new AppSettingsReader();
        public ActionResult Information(string userName)
        {
            Logindata logindata = new Logindata();
            logindata.Username = userName;
            return View(logindata);
        }
        public ActionResult CHECKLOGIN(Logindata logindata)
        {
            SqlConnection con = new SqlConnection(aps.GetValue("ConnectionString", typeof(System.String)).ToString());
            string uname = logindata.Username;
            string password = logindata.Password;
            string usertype = logindata.Usertype;
            // if(uname == "suman" && password == "12345")
            //SqlConnection con = new SqlConnection(aps.GetValue("ConnectionString", typeof(System.String)).ToString());

            con.Open();
            string sql = "Select * From Firstproject where UserName=@uname and Password=@pass";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@pass", password);

            object objcount = cmd.ExecuteScalar();
            con.Close();
            int iCount = objcount == null ? 0 : (int)objcount;
            if(iCount > 0)
            { 


            List<ProductModel> pddetail = new List<ProductModel>();

        //SqlConnection con = new SqlConnection(aps.GetValue("ConnectionString", typeof(System.String)).ToString());
            con.Open();
                string sql1 = "Select * From ProductDetails";
                   
                SqlCommand cmd1 = new SqlCommand(sql1, con);

                using (SqlDataReader reader = cmd1.ExecuteReader())
                { // Read each record
                    while (reader.Read())
                    {
                        // Create a new Student object and set its properties
                        ProductModel pd = new ProductModel
                        {
                            SN = (int)reader["SN"], // Assuming Id is the first column
                            Image = (byte[])reader["Image"], // Assuming Name is the second column Age = reader.GetInt32(2) // Assuming Age is the third column }; // Add the student to the list students.Add(student); } }
                            Name = reader["Name"] as string,
                            price = (decimal)reader["Price"],
                            description = reader["Description"] as string
                        };
                        pddetail.Add(pd);
                    }
                }

                  
                con.Close();

                return View("Landingpage", pddetail);
            }
            else
            {
                return View("error");
            }
        }
        ////public school db = new school();
        //public ActionResult GetImage(int SN)
        //{
        //    // Fetch the image from the database using the provided id
        //    var imageData = db.ProductDetails.Find(SN)?.Image;

        //    if (imageData != null)
        //    {
        //        return File(imageData, "image/jpeg");
        //    }

        //    return HttpNotFound(); // Return 404 if image not found
        //}







    }
}

