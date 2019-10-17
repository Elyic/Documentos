using Documentos.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Documentos.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(String Usuario, String Contraseña)
        {
            using (BibliotecaEntities bd =  new BibliotecaEntities())
            {

                Console.WriteLine(bd.usuario.Where(x => x.usuario1 == Usuario && 
                x.contraseña == Contraseña));
                if (bd.usuario.Where(x => x.usuario1 == Usuario &&
                x.contraseña == Contraseña).Count() > 0)
                {
                    HttpCookie Login = new HttpCookie("Logueado");
                    DateTime now = DateTime.Now;
                    Login.Value = Usuario;
                    Login.Expires = now.AddHours(1);

                    Response.Cookies.Add(Login);
                    Response.Cookies.Add(Login);
                    return View("~/Views/Documento/Index.cshtml");
                }
                else
                {
                    return View("~/Views/Usuario/Index.cshtml");
                }
            }
            
        }
        //public ActionResult Nuevo(PersonaViewModel persona)
        //{
        //    try
        //    {
        //        //validar datos
        //        if (ModelState.IsValid)
        //        {
        //            //guardamos datos en bd

        //            using (PersonaEntities2 bd = new PersonaEntities2())
        //            {
        //                var opersona = new Persona();
        //                opersona.Nombre = persona.Nombre;
        //                opersona.Apellido = persona.Apellido;
        //                opersona.Edad = persona.Edad;

        //                bd.Persona.Add(opersona);
        //                bd.SaveChanges();
        //            }
        //            //luego de agregar registro redirecionamos hacia nuestro index
        //            return Redirect("~/Persona/");
        //        }

        //        return View(persona);
        //    }

        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}
    }
}