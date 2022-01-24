using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TMA3A.Pages.part3.Helpers;
using TMA3A.Pages.part3.Models;

namespace TMA3A.Pages.part3
{
    public class TestModel : PageModel
    {
        public List<Computers> computer_data;

        public void OnGet()
        {

            computer_data = SessionHelper.GetObjectFromJson<List<Computers>>(HttpContext.Session, "computer_data");

            String json_string = JsonConvert.SerializeObject(computer_data);
            var images_json = JsonConvert.DeserializeObject(json_string);

            string[] arr = ((IEnumerable)images_json).Cast<object>()
                            .Select(x => x.ToString())
                            .ToArray();

            JObject jsonnn = JObject.Parse(arr[0]);

            String str = jsonnn["Name"].ToString() + " Customized with CPU: " + jsonnn["CPU"].ToString() + ", Display: " + jsonnn["Display"].ToString() + ", Fan: " + jsonnn["Fan"].ToString() + ", GPU: " + jsonnn["GPU"].ToString() + ", Hard Drive: " + jsonnn["Hard_Drive"].ToString() + ", Motherboard: " + jsonnn["Motherboard"].ToString() + ", RAM: " + jsonnn["RAM"].ToString() + ", OS: " + jsonnn["OS"].ToString() + ", Soundcard: " + jsonnn["Soundcard"].ToString();
           // String str = jsonnn["name"].ToString() + "Customized with CPU: ";


            ViewData["name"] = str;
            ViewData["price"] = jsonnn["Price"].ToString();
            ViewData["image"] = jsonnn["Image"].ToString();



        }
    }
}
