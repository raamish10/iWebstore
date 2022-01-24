using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Data.SqlClient;

namespace TMA3A.Pages.part4
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                String email = Input.Email.ToString();
                String password = Input.Password.ToString();

                var isExist = IsEmailExist(email);

                if (isExist == false)
                {
                    using (SqlConnection connection = new SqlConnection("Server=tcp:tma3anew.database.windows.net,1433;Initial Catalog=tma3a;Persist Security Info=False;User ID=tma3anew;Password=TMA3a123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                    {
                        string sqlQuery = "INSERT INTO [dbo].[users] (user_name,passwrd) VALUES('" + email + "','" + password + "')";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);

                        connection.Open();
                        SqlDataReader readData = command.ExecuteReader();
                        connection.Close();

                    }
                    return RedirectToPage("/part4/Register", "Successful");
                }
                else if (isExist == true)
                {
                    return RedirectToPage("/part4/Register", "Exists");
                }
                return Page();
            }
            else
            {
                return Page();
            }
        }

        public void OnGetExists()
        {
            ViewData["ErrorMessage"] = "Error! A user with that email already exists.";
        }

        public void OnGetSuccessful()
        {
            ViewData["SuccessMessage"] = "Your account has been registered. You can now log in.";
        }

        private bool IsEmailExist(string email)
        {
            using (SqlConnection connection = new SqlConnection("Server=tcp:tma3anew.database.windows.net,1433;Initial Catalog=tma3a;Persist Security Info=False;User ID=tma3anew;Password=TMA3a123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                string sqlQuery = "SELECT * FROM [dbo].[users] WHERE user_name = '" + email + "'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader readData = command.ExecuteReader();

                if(readData.Read() == true)
                {
                    connection.Close();
                    return true;
                } else
                {
                    connection.Close();
                    return false;
                }
            }
        }
    }
}
