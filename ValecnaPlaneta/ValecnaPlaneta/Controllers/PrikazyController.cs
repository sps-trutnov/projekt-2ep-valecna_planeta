﻿using Microsoft.AspNetCore.Mvc;

namespace ValecnaPlaneta.Controllers
{
    public class PrikazyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string zadanyPrikaz)
        {
            if (zadanyPrikaz == null || zadanyPrikaz.Trim() == "")
                return View();

            zadanyPrikaz = zadanyPrikaz.Trim().ToLower();

            if (zadanyPrikaz == "income")
                return Redirect("/Engine/Prijem");

            else if (zadanyPrikaz == "send scout")
                return Redirect("/Engine/Posli");

            else if (zadanyPrikaz == "send solider")
                return Redirect("/Engine/Posli");

            else if (zadanyPrikaz == "send infiltrator")
                return Redirect("/Engine/Posli");

            if (zadanyPrikaz != "income")
            {
                ViewData["chyba"] = "Wrong syntax. Write Help for more information.";
                return View();
            }
            if (zadanyPrikaz == "help" || zadanyPrikaz == "Help")
            {
                ViewData["help"] = "Available commands: Help, Income, Capital, Send + soldier/scout/infiltrator/";
                return View();
            }
            else if (zadanyPrikaz == "capital" || zadanyPrikaz == "Capital")
                return Redirect("/Engine/Kapital");

            else
                throw new NotImplementedException();
        }
    }
}
