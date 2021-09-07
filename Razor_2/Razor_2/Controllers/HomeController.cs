using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //Métodos para vista calcular edad
        public ActionResult CalcularEdad()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalcularEdad(int txtan, string txtn)
        {
            int actual = DateTime.Now.Year;
            int edad = actual - txtan;
            ViewBag.e = edad;
            ViewBag.n = txtn;
            ViewBag.an = txtan;
            return View();
        }

        public ActionResult Calculadora()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculadora(float txtu, float txtd)
        {
            float  uno=txtu;
            float  dos=txtd;

            ViewBag.s = uno+dos;
            ViewBag.r = uno - dos;
            ViewBag.m = uno * dos;
            ViewBag.d = uno / dos;

            return View();
        }
        public ActionResult Conversion()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Conversion(float txtc,  float txtp)
        {
            float uno = txtc;            
            float tres = txtp;
            
            ViewBag.f = 9 / 5 * uno + 32;
            ViewBag.m = 25.5 * tres;

            return View();
        }

        public ActionResult Descuento()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Descuento(float txtprod, float txtpago)
        {
            float uno = txtprod;
            float dos = txtpago;

            ViewBag.dto = (uno - dos) /100;

            return View();
        }

        public ActionResult Estadistica()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Estadistica(float txt1, float txt2, float txt3, float txt4)
        {
            float uno = txt1;
            float dos = txt2;
            float tres = txt3;
            float cuatro = txt4;

            ViewBag.total = Math.Truncate((dos + tres + cuatro) / (uno + dos + tres + cuatro) * 100);
            ViewBag.susp = Math.Truncate(uno / (uno + dos + tres + cuatro) * 100);
            ViewBag.apr=Math.Truncate(dos/ (uno + dos + tres + cuatro) * 100);
            ViewBag.not= Math.Truncate(tres/ (uno + dos + tres + cuatro) * 100);
            ViewBag.sobre=Math.Truncate(cuatro/ (uno + dos + tres + cuatro) * 100);

            return View();
        }
    }
}