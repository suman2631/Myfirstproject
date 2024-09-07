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
    public class productController : Controller
    {
        // GET: product
        public ActionResult Index()
        {
            return View();
        }
        AppSettingsReader aps = new AppSettingsReader();
        [HttpPost]

        public ActionResult Addproduct(details pdetail)
        {
            SqlConnection con = new SqlConnection(aps.GetValue("ConnectionString", typeof(System.String)).ToString());
            if (pdetail.ImageData != null &&  pdetail.price != null)
            {
                byte[] Imagedt = null;

                using (var binaryReader = new System.IO.BinaryReader(pdetail.ImageData.InputStream))
                    {
                    Imagedt = binaryReader.ReadBytes(pdetail.ImageData.ContentLength);
                    //Imagedt.ImageMimeType = pdetail.ImageData.ContentType;
                    }

                    // Save the product, including the image, to the database

                // Convert the uploaded image to a byte array
                //byte[] ImageData = null;
                //using (var binaryReader = new System.IO.BinaryReader(ImageData.InputStream))
                //{
                //    ImageData = binaryReader.ReadBytes(ImageData.ContentLength);
                //}

        

                con.Open();
                string sql = "insert into ProductDetails(SN,Image, Name, Price, Description) Values (@SN,@image, @name, @price, @Description)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@image", Imagedt);
                cmd.Parameters.AddWithValue("@name", pdetail.productname);
                cmd.Parameters.AddWithValue("@SN", pdetail.pdcode);
                cmd.Parameters.AddWithValue("@price", pdetail.price);
                cmd.Parameters.AddWithValue("@Description", pdetail.description);


                cmd.ExecuteNonQuery();
                con.Close();

                return View ("Index");
            }
            else
            {
                return View("ErrorPage");  // Redirect to error page if validation fails
            }




        }
    }
}