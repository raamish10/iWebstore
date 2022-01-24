using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System.Web;
using System.Net.Mail;
using System.Net;
using TMA3A.Pages.part4.Helpers;

namespace TMA3A.Pages.part4
{
    public class LoginModel : PageModel
    {
        public IActionResult OnGet()
        {
            string cookie = SessionHelper.GetObjectFromJson<String>(HttpContext.Session, "logged_in_session");

            if (cookie == null || cookie == "")
            {
                return Page(); 
            }
            return RedirectToPage("/part4/LoggedIn");


        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Password")]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                String email = Input.Email.ToString();
                String password = Input.Password.ToString();

                var isExist = IsAccountExist(email, password);

                if (isExist == false)
                {
                    return RedirectToPage("/part4/Login", "IncorrectDetails");
                }
                else if (isExist == true)
                {
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "logged_in_session", email);
                    return RedirectToPage("/part4/LoggedIn");

                }
            }
            return RedirectToPage("/part4/Login");

        }

        private bool IsAccountExist(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection("Server=tcp:tma3anew.database.windows.net,1433;Initial Catalog=tma3a;Persist Security Info=False;User ID=tma3anew;Password=TMA3a123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                string sqlQuery = "SELECT * FROM [dbo].[users] WHERE user_name = '" + email + "' AND passwrd = '"+password+"'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader readData = command.ExecuteReader();

                if (readData.Read() == true)
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public void OnGetIncorrectDetails()
        {
            ViewData["ErrorMessage"] = "Error! Please enter in the correct details.";
        }

    }
}


  