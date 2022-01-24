using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace TMA3A.Pages
{
    public class Part1Model : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Part1Model(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }



        public void OnGet()
        {
            string cookie = Request.Cookies["count"];

            if (cookie == null)
            {
                CookieOptions new_cookie = new CookieOptions();
                new_cookie.Expires = DateTime.Now.AddDays(2);
                int counter = 1;
                Response.Cookies.Append("count", counter.ToString(), new_cookie);
                ViewData["cookie_count"] = 1;
            }
            else
            {
                CookieOptions updated = new CookieOptions();
                int cookieCount = int.Parse(cookie);       
                int newCount = cookieCount + 1;
                Response.Cookies.Append("count", newCount.ToString(), updated);
                ViewData["cookie_count"] = newCount;
            }
            //RedirectToAction("part1", "part1");
        }



    }
}
