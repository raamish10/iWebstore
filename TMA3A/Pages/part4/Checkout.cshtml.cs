using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TMA3A.Pages.part4.Helpers;
using TMA3A.Pages.part4.Models;
using TMA3A.Pages.part4;
using System.Net.Mail;
using Newtonsoft.Json;
using System.Net;

namespace TMA3A.Pages.part4
{
    public class CheckoutModel : PageModel
    {
        public List<Item> cart;




        public IActionResult OnGet()
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "part4cart");
            SessionHelper.SetObjectAsJson(HttpContext.Session, "part4cart", cart);

            if (cart == null || cart.Count == 0)
            {
                return RedirectToPage("/part4/Cart");
            }
            return Page();
        }

        public async Task OnPost()
        {
            string Name = Request.Form["Name"];
            string Address = Request.Form["Address"];
            string Email = Request.Form["Email"];
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "part4cart");


            MailMessage msg = new MailMessage();
            msg.To.Add(Email);
            msg.Subject = "Order Placed";
            msg.Body = "Hello " + Name + "!   Below is the JSON of your order summary:               " + "     " + JsonConvert.SerializeObject(cart);
            msg.IsBodyHtml = false;
            msg.From = new MailAddress("j42mhwrocks123@gmail.com");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("j42mhwrocks123@gmail.com", "TMA3a123!");
            await smtp.SendMailAsync(msg);
            //smtp.Send(msg);
            ViewData["Message"] = "Your order has been placed. Thank you!";
        }



    }
}
