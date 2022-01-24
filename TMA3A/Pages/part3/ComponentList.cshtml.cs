using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Timers;
using TMA3A.Pages.part3.Models;
using TMA3A.Pages.part3.Helpers;

namespace TMA3A.Pages.part3
{
    public class ComponentListModel : PageModel
    {
        public string[] name;
        public string[] price;
        public string[] image;

        public List<Components> components0 = new List<Components>();
        public List<Components> componentz;

        public void OnGet()
        {
            ViewData["component_type"] = Request.Query["type"];
            ExtractJSON();
        }


        public void ExtractJSON()
        {
            var webClient = new WebClient();
            var url_str = "./Pages/part3/db_files/" + Request.Query["type"].ToString() + ".json";
            var json = webClient.DownloadString(@url_str);
            var components_json = JsonConvert.DeserializeObject(json);

            string[] arr = ((IEnumerable)components_json).Cast<object>()
                            .Select(x => x.ToString())
                            .ToArray();

            name = new string[9];
            price = new string[9];
            image = new string[9];

            for (int i = 0; i < 9; i++)
            {
                JObject jsonnn = JObject.Parse(arr[i]);

                if (jsonnn["type"].ToString() == Request.Query["type"].ToString())
                {
                    name[i] = jsonnn["name"].ToString();
                    price[i] = jsonnn["price"].ToString();
                    image[i] = jsonnn["link"].ToString();

                    components0.Add(new Components { Id = i.ToString(), Name = name[i], Image = image[i], Price = price[i] });

                }

            }
            //SessionHelper.SetObjectAsJson(HttpContext.Session, "component_list", components0);
            //ViewData["ImgLink"] = image[6];
            //ViewData["Caption"] = name.Count();
            componentz = SessionHelper.GetObjectFromJson<List<Components>>(HttpContext.Session, "component_list");

            if (componentz == null)
            {
                componentz = new List<Components>();
                SessionHelper.SetObjectAsJson(HttpContext.Session, "component_list", components0);
            }
            else
            {
                SessionHelper.SetObjectAsJson(HttpContext.Session, "component_list", components0);
            }

            //omfggg = SessionHelper.GetObjectFromJson<List<Components>>(HttpContext.Session, "component_list");
            //String temp = JsonConvert.SerializeObject(omfggg);
            //ViewData["fml123"] = temp;

        }
        //public ComponentListModel()
        //{
        //    componentz = SessionHelper.GetObjectFromJson<List<Components>>(HttpContext.Session, "component_list");
        //}
        public Components find(string id)
        {
            return componentz.Where(p => p.Id == id).FirstOrDefault();
        }

    }
}
