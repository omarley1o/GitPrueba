using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pk2v_RSVPwapp.Models;

namespace Pk2v_RSVPwapp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Buenos Dias!!!" : "Buenas tardes";
            return View();
        }
        //Get: /Home/RsvpFrom
        //Renderea el link de la froma del RSVP
        [HttpGet]
        public ViewResult RsvpFrom()
        {
            return View();
        }

        //Responde a un POST: /Home/RsvpForm
        [HttpPost]
        public ViewResult RsvpFrom(GuestResponse guestResponse)
        { 


            //verificando errores de validacion
            if (ModelState.IsValid)
            {

                //Todo: Enviar respuesta al correo del organizador
                return View("Agradecimientos", guestResponse);
            }
            else
            {
                //hay un prioblema de validacion
                return View();
                
            }
        }

    }
}
