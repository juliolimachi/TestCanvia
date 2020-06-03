using ClientMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ClientMVC.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Index()
        {
            IEnumerable<mvcPersonaModal> perList;
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("list").Result;
            perList = response.Content.ReadAsAsync<IEnumerable<mvcPersonaModal>>().Result;
            return View(perList);
        }


        public ActionResult Add()
        {
           
                return View(new mvcPersonaModal());
    
        }

        [HttpPost]
        public ActionResult Add(mvcPersonaModal persona)
        {
            if (persona.IdPersona == 0)
            {
                HttpResponseMessage response = GlobalVariables.webApiClient.PostAsJsonAsync("register", persona).Result;
                TempData["SuccessMessage"] = "Guardado Correctamente";
            }

            return RedirectToAction("Index");
        }


    }





}