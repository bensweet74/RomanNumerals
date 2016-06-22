﻿using RomanNumerals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RomanNumerals.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Convert(ConvertViewModel convert)
        {
            BusinessLogic businessLogic = new BusinessLogic();
            if (convert.NumberToConvert > 0)
            {
                convert.RomanNumber = businessLogic.ConvertNumberToRomanNumeral(convert.NumberToConvert);
            }

            return View(convert);
        }
    }
}