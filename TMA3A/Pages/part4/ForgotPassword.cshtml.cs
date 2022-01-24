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
using Microsoft.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace TMA3A.Pages.part4
{
    public class ForgotPasswordModel : PageModel
    {
        public void OnGet()
        {
        }


        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }

  
        public async Task OnPost()
        {
            if (ModelState.IsValid)
            {
                String email = Input.Email.ToString();
                var isExist = IsEmailExist(email);

                if (isExist == false)
                {
                    ViewData["ErrorMessage"] = "The email is not registered on this website. Please enter a valid email.";
                }
                else if (isExist == true)
                {
                    String password;

                    using (SqlConnection connection = new SqlConnection("Server=tcp:tma3anew.database.windows.net,1433;Initial Catalog=tma3a;Persist Security Info=False;User ID=tma3anew;Password=TMA3a123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                    {
                        string sqlQuery = "SELECT * FROM [dbo].[users] WHERE user_name = '" + email + "'";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);

                        connection.Open();
                        SqlDataReader readData = command.ExecuteReader();

                        if (readData.Read() == true)
                        {

                            password = readData["passwrd"].ToString();


                            MailMessage msg = new MailMessage();
                            msg.To.Add(email);
                            msg.Subject = "Password Recovery Request";
                            msg.Body = "Your password is " + password;
                            msg.IsBodyHtml = false;
                            msg.From = new MailAddress("j42mhwrocks123@gmail.com");
                            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                            smtp.Port = 587;
                            smtp.UseDefaultCredentials = true;
                            smtp.EnableSsl = true;
                            smtp.Credentials = new NetworkCredential("j42mhwrocks123@gmail.com", "TMA3a123!");
                            await smtp.SendMailAsync(msg);
                            connection.Close();

                            ViewData["SuccessMessage"] = "Your password has been sent to your email.";
                        }
                        else
                        {
                            connection.Close();
                            ViewData["ErrorMessage"] = "Something went wrong.";
                        }
                    }

                }
            }
        }

        private bool IsEmailExist(string email)
        {
            using (SqlConnection connection = new SqlConnection("Server=tcp:tma3anew.database.windows.net,1433;Initial Catalog=tma3a;Persist Security Info=False;User ID=tma3anew;Password=TMA3a123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                string sqlQuery = "SELECT * FROM [dbo].[users] WHERE user_name = '" + email + "'";
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

    }
}
