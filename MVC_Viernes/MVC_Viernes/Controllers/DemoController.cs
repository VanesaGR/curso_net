using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Viernes.Models;

namespace MVC_Viernes.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            ViewBag.Mensaje = "Acceso al método por defecto";
            //Esto devuelve un libro
            //var libro = new Libro { Isbn = "1122", Titulo = "El principito", TipoLibro = "Novela" };
            //return View(libro);

            //Esto devuelve una lista de libros
            var libros = new List<Libro>{ new Libro{ Isbn = "1122",Titulo = "El principito",TipoLibro = "Novela"},
                        new Libro{ Isbn = "1122", Titulo = "Steve Jobs",TipoLibro = "Biografía"} }; 
            return View(libros);
        }

    }
}