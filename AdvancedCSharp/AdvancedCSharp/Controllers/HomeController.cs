using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdvancedCSharp.Models;


namespace AdvancedCSharp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            return View();

        }

        public string Vista()
        {
            return "Bienvenido";

        }
     

        public ViewResult AutoProperty()
        {
            //crear un objeto
            //de la clase producto
            //Establece el valor de la propiedad
            Product myProduct = new Product
            {
                ProductID = 12,
                Name = "kayak",
                Description = "kiosteca Blue",
                Category = "SPORTS",
                Price = 12.5f
            };

            string salida =
                String.Format("{0}-{1}-{2}-{3}-{4:C0}",
                myProduct.ProductID,
                myProduct.Name,
                myProduct.Description,
                myProduct.Category,
                myProduct.Price);

            //Genera la vista
            return View("Results", (object)salida);
        }

        public ViewResult CreateCollection()
        {
            string[] stringArray = { "manzana", "naranja", "lima" };

            List<int> intList = new List<int> { 10, 20, 30, 40 };

            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"Manzana",10},
                {"Naranja",20},
                {"Lima",30},


            };

            return View("Results", (object)myDict["Lima"].ToString());



        }

        public ViewResult UseExtension()
        {
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product {Name = "Kayak", Price = 3250.0f},
                    new Product {Name = "Lentes", Price = 1500.0f},
                    new Product {Name = "Balon", Price = 50.0f},
                    new Product {Name = "Disco Volador", Price = 130.0f},

                }
            };


            double total = cart.TotalPrices();
            
            return View("Results", (object)String.Format("Total: {0:c}", total));


        }


    }
}

