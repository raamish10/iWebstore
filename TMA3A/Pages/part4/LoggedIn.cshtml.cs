using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using TMA3A.Pages.part3.Helpers;

namespace TMA3A.Pages.part4
{
    public class LoggedInModel : PageModel
    {
        public void OnGet()
        {
            string cookie = SessionHelper.GetObjectFromJson<String>(HttpContext.Session, "logged_in_session");
            ViewData["username"] = JsonConvert.SerializeObject(cookie);

        }

        public IActionResult OnPost()
        {
            string cookie = SessionHelper.GetObjectFromJson<String>(HttpContext.Session, "logged_in_session");
            cookie = "";
            SessionHelper.SetObjectAsJson(HttpContext.Session, "logged_in_session", cookie);

            return RedirectToPage("/part4/LogIn");

        }
    }
}
