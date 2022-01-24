using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Mail;


namespace TMA3A.Pages.part4
{
    public class ContactUsModel : PageModel
    {
        public void OnGet()
        {
        }

        public async Task OnPost()
        {
            string Subject = Request.Form["email_subject"];
            string Body = Request.Form["email_body"];

            MailMessage msg = new MailMessage();
            msg.To.Add("j42mhwrocks123@gmail.com");
            msg.Subject = Subject;
            msg.Body = Body;
            msg.IsBodyHtml = false;
            msg.From = new MailAddress("j42mhwrocks123@gmail.com");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("j42mhwrocks123@gmail.com", "TMA3a123!");
            await smtp.SendMailAsync(msg);
            //smtp.Send(msg);
            ViewData["Message"] = "Your feedback has been recorded. Thank you!";
        }

    }
}
