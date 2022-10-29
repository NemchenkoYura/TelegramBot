using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace TelegramBot.Models
{
    public class HomeController:Controller
    {
        public string Index ()
        {
            return "Its my telega bot";
        }
    }
}