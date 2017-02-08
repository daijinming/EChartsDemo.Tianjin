using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace EChartsDemo.Tianjin
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {

            Get[@"/"] = _ =>
            {
                var model = new { title = "", body = "" };

                return View["Home.html", model];
            };
        }
    }
}