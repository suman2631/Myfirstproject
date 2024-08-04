using Myfirstproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Myfirstproject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Information(string userName)
        {
            Logindata logindata = new Logindata();
            logindata.Username = userName;
            return View(logindata);
        }
        public ActionResult CHECKLOGIN(Logindata logindata)
        {
            string uname = logindata.Username;
            string password = logindata.Password;
            string usertype = logindata.Usertype;
            if(uname == "suman" && password == "12345")
            {
                return View("Landingpage",logindata);
            }
            else
            {
                return View("error");
            }
        }

        


            


    }
}
/*
 *         <div class="pro-container">
            <div class="pro">
                <img src="~/image/Logo.jpg" />
                <div class="des">
                    <span>adidas</span>
                    <h5>cartoon astronaut tshirts</h5>
                    <h4>$45</h4>

                </div>

            </div>

        </div>
        <div class="pro-container">
            <div class="pro">
                <img src="~/image/Logo.jpg" />
                <div class="des">
                    <span>adidas</span>
                    <h5>cartoon astronaut tshirts</h5>
                    <h4>$45</h4>

                </div>

            </div>

        </div>
        <div class="pro-container">
            <div class="pro">
                <img src="~/image/Logo.jpg" />
                <div class="des">
                    <span>adidas</span>
                    <h5>cartoon astronaut tshirts</h5>
                    <h4>$45</h4>

                </div>

            </div>

        </div>


    </section>
    <section id="product1" class="section-p1">

        <div class="pro-container">
            <div class="pro">
                <img src="~/image/Logo.jpg" />
                <div class="des">
                    <span>adidas</span>
                    <h5>cartoon astronaut tshirts</h5>
                    <h4>$45</h4>

                </div>

            </div>

        </div>
        <div class="pro-container">
            <div class="pro">
                <img src="~/image/Logo.jpg" />
                <div class="des">
                    <span>adidas</span>
                    <h5>cartoon astronaut tshirts</h5>
                    <h4>$45</h4>

                </div>

            </div>

        </div>
        <div class="pro-container">
            <div class="pro">
                <img src="~/image/Logo.jpg" />
                <div class="des">
                    <span>adidas</span>
                    <h5>cartoon astronaut tshirts</h5>
                    <h4>$45</h4>

                </div>

            </div>

        </div>
        <div class="pro-container">
            <div class="pro">
                <img src="~/image/Logo.jpg" />
                <div class="des">
                    <span>adidas</span>
                    <h5>cartoon astronaut tshirts</h5>
                    <h4>$45</h4>

                </div>

            </div>

        </div>


    </section>
    <section id="product1" class="section-p1">

        <div class="pro-container">
            <div class="pro">
                <img src="~/image/Logo.jpg" />
                <div class="des">
                    <span>adidas</span>
                    <h5>cartoon astronaut tshirts</h5>
                    <h4>$45</h4>

                </div>

            </div>

        </div>
        <div class="pro-container">
            <div class="pro">
                <img src="~/image/Logo.jpg" />
                <div class="des">
                    <span>adidas</span>
                    <h5>cartoon astronaut tshirts</h5>
                    <h4>$45</h4>

                </div>

            </div>

        </div>
        <div class="pro-container">
            <div class="pro">
                <img src="~/image/Logo.jpg" />
                <div class="des">
                    <span>adidas</span>
                    <h5>cartoon astronaut tshirts</h5>
                    <h4>$45</h4>

                </div>

            </div>

        </div>
        <div class="pro-container">
            <div class="pro">
                <img src="~/image/Logo.jpg" />
                <div class="des">
                    <span>adidas</span>
                    <h5>cartoon astronaut tshirts</h5>
                    <h4>$45</h4>

                </div>

            </div>

        </div>

 */
