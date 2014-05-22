using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeQuiz.Models;

namespace EmployeeQuiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            //creo el objeto del modelo de datos
            
                PayrollDm nomina = new PayrollDm(
                  @"C:\Users\zulma\Desktop\OmaProyectoRecover\Recover\EmployeeQuiz\Models\BaseEmpleados.csv");

                //Busco el empleado dado su ID
                var empleado = nomina.GetEmployeeById(emp.Id);
                if (ModelState.IsValid)
                {

                    return View("WorkerView", empleado);
                }
                else
                {
                    return View();
                }
           
        }

       
    }
}
