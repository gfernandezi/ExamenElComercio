using ExamenMetrica.Entidades;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ExamenMetrica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ChangeString ch = new ChangeString();
            CompleteRange cr = new CompleteRange();
            MoneyParts mp = new MoneyParts();

            //Ejercicio 1.
            string resultado_1 =  ch.build("123abc*3");

            //Ejercicio 2.
            List<int> numeros = new List<int>();
            numeros.Add(58);
            numeros.Add(60);
            numeros.Add(55);
        
            List<int> resultado_2 = cr.build(numeros);


            //Ejercicio 3.
            List<List<decimal>> resultado_3 = null;
            //resultado_3 = mp.build(10.5M);
            resultado_3 = mp.build(33);



            return View();  
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}