using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TMA3A.Pages.part3.Helpers;
using TMA3A.Pages.part3.Models;

namespace TMA3A.Pages.part3
{
    public class ComputerDetailsModel : PageModel
    {
        public List<Computers> computer_list;
        public Computers Computer { get; set; }

        public int SelectedTag { get; set; }
        public SelectList CPUOptions { get; set; }
        public SelectList DisplayOptions { get; set; }
        public SelectList FanOptions { get; set; }
        public SelectList GPUOptions { get; set; }
        public SelectList HardDriveOptions { get; set; }
        public SelectList MotherboardOptions { get; set; }
        public SelectList OSOptions { get; set; }
        public SelectList RAMOptions { get; set; }
        public SelectList SoundcardOptions { get; set; }

        public string[] CPUName;
        public string[] CPUPrice;
        public string[] DisplayName;
        public string[] DisplayPrice;
        public string[] FanName;
        public string[] FanPrice;
        public string[] GPUName;
        public string[] GPUPrice;
        public string[] HardDriveName;
        public string[] HardDrivePrice;
        public string[] MotherboardName;
        public string[] MotherboardPrice;
        public string[] OSName;
        public string[] OSPrice;
        public string[] RAMName;
        public string[] RAMPrice;
        public string[] SoundcardName;
        public string[] SoundcardPrice;

        public string[] components = new string[] { "CPU", "Display", "Fan", "GPU", "Hard_Drive", "Motherboard", "OS", "RAM", "Soundcard" };
        public List<Components> components0 = new List<Components>();
        public List<Computers> computer_data;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            computer_data = new List<Computers>
            {
                new Computers { Id = "11", Name = Request.Form["Name"], Price = Request.Form["Price"], Image = Request.Form["Image"], CPU = Request.Form["CPU"], Display = Request.Form["Display"], Fan = Request.Form["Fan"], GPU = Request.Form["GPU"], Hard_Drive = Request.Form["Hard_Drive"], Motherboard = Request.Form["Motherboard"], OS = Request.Form["OS"], RAM = Request.Form["RAM"], Soundcard = Request.Form["Soundcard"] }
            };
            SessionHelper.SetObjectAsJson(HttpContext.Session, "computer_data", computer_data);
            return RedirectToPage("/part3/Cart", "Custom");
        }

        public void OnGetViewDetails(string id, string name)
        {
            ViewData["query_id"] = id;
            ViewData["query_name"] = name;

            CPUName = new string[9];
            CPUPrice = new string[9];
            DisplayName = new string[9];
            DisplayPrice = new string[9];
            FanName = new string[9];
            FanPrice = new string[9];
            GPUName = new string[9];
            GPUPrice = new string[9];
            HardDriveName = new string[9];
            HardDrivePrice = new string[9];
            MotherboardName = new string[9];
            MotherboardPrice = new string[9];
            OSName = new string[9];
            OSPrice = new string[9];
            RAMName = new string[9];
            RAMPrice = new string[9];
            SoundcardName = new string[9];
            SoundcardPrice = new string[9];


            computer_list = SessionHelper.GetObjectFromJson<List<Computers>>(HttpContext.Session, "computer_details");
            Computer = find(computer_list, id);

            List<SelectListItem> CPUitems = new List<SelectListItem>();
            List<SelectListItem> Displayitems = new List<SelectListItem>();
            List<SelectListItem> Fanitems = new List<SelectListItem>();
            List<SelectListItem> GPUitems = new List<SelectListItem>();
            List<SelectListItem> HardDriveitems = new List<SelectListItem>();
            List<SelectListItem> Motherboarditems = new List<SelectListItem>();
            List<SelectListItem> OSitems = new List<SelectListItem>();
            List<SelectListItem> RAMitems = new List<SelectListItem>();
            List<SelectListItem> Soundcarditems = new List<SelectListItem>();

            //List<SelectListGroup> group = new List<SelectListGroup>();


            foreach (string comp in components)
            {
                ExtractJSON(comp);

                if(comp == "CPU")
                {
                    CPUitems = CPUName.Select((name, index) =>
                    {
                        return new SelectListItem
                        {
                            Value = name.ToString(),
                            Text = name.ToString(),
                        };
                    }).ToList();

                }
                else if (comp == "Display")
                {
                    Displayitems = DisplayName.Select((name, index) =>
                    {
                        return new SelectListItem
                        {
                            Value = name.ToString(),
                            Text = name.ToString(),
                        };
                    }).ToList();
                }
                else if (comp == "Fan")
                {
                    Fanitems = FanName.Select((name, index) =>
                    {
                        return new SelectListItem
                        {
                            Value = name.ToString(),
                            Text = name.ToString(),
                        };
                    }).ToList();
                }
                else if (comp == "GPU")
                {
                    GPUitems = GPUName.Select((name, index) =>
                    {
                        return new SelectListItem
                        {
                            Value = name.ToString(),
                            Text = name.ToString(),
                        };
                    }).ToList();
                }
                else if (comp == "Hard_Drive")
                {
                    HardDriveitems = HardDriveName.Select((name, index) =>
                    {
                        return new SelectListItem
                        {
                            Value = name.ToString(),
                            Text = name.ToString(),
                        };
                    }).ToList();
                }
                else if (comp == "Motherboard")
                {
                    Motherboarditems = MotherboardName.Select((name, index) =>
                    {
                        return new SelectListItem
                        {
                            Value = name.ToString(),
                            Text = name.ToString(),
                        };
                    }).ToList();
                }
                else if (comp == "OS")
                {
                    OSitems = OSName.Select((name, index) =>
                    {
                        return new SelectListItem
                        {
                            Value = name.ToString(),
                            Text = name.ToString(),
                        };
                    }).ToList();
                }
                else if (comp == "RAM")
                {
                    RAMitems = RAMName.Select((name, index) =>
                    {
                        return new SelectListItem
                        {
                            Value = name.ToString(),
                            Text = name.ToString(),
                        };
                    }).ToList();
                }
                else if (comp == "Soundcard")
                {
                    Soundcarditems = SoundcardName.Select((name, index) =>
                    {
                        return new SelectListItem
                        {
                            Value = name.ToString(),
                            Text = name.ToString(),
                        };
                    }).ToList();
                }

            }

            CPUOptions = new SelectList(CPUitems, "Text", "Value");
            DisplayOptions = new SelectList(Displayitems, "Text", "Value");
            FanOptions = new SelectList(Fanitems, "Text", "Value");
            GPUOptions = new SelectList(GPUitems, "Text", "Value");
            HardDriveOptions = new SelectList(HardDriveitems, "Text", "Value");
            MotherboardOptions = new SelectList(Motherboarditems, "Text", "Value");
            OSOptions = new SelectList(OSitems, "Text", "Value");
            RAMOptions = new SelectList(RAMitems, "Text", "Value");
            SoundcardOptions = new SelectList(Soundcarditems, "Text", "Value");

            SelectedTag = int.Parse(id);



        }

        public void ExtractJSON(String comp)
        {
            var webClient = new WebClient();
            var url_str = "./Pages/part3/db_files/"+comp+".json";
            var json = webClient.DownloadString(@url_str);
            var components_json = JsonConvert.DeserializeObject(json);

            string[] arr = ((IEnumerable)components_json).Cast<object>()
                            .Select(x => x.ToString())
                            .ToArray();



            for (int i = 0; i < 9; i++)
            {
                JObject jsonnn = JObject.Parse(arr[i]);

                if (jsonnn["type"].ToString() == "CPU")
                {
                    CPUName[i] = jsonnn["name"].ToString();
                    CPUPrice[i] = jsonnn["price"].ToString();
                }
                else if (jsonnn["type"].ToString() == "Display")
                {
                    DisplayName[i] = jsonnn["name"].ToString();
                    DisplayPrice[i] = jsonnn["price"].ToString();
                }
                else if (jsonnn["type"].ToString() == "Fan")
                {
                    FanName[i] = jsonnn["name"].ToString();
                    FanPrice[i] = jsonnn["price"].ToString();
                }
                else if (jsonnn["type"].ToString() == "GPU")
                {
                    GPUName[i] = jsonnn["name"].ToString();
                    GPUPrice[i] = jsonnn["price"].ToString();
                }
                else if (jsonnn["type"].ToString() == "Hard_Drive")
                {
                    HardDriveName[i] = jsonnn["name"].ToString();
                    HardDrivePrice[i] = jsonnn["price"].ToString();
                }
                else if (jsonnn["type"].ToString() == "Motherboard")
                {
                    MotherboardName[i] = jsonnn["name"].ToString();
                    MotherboardPrice[i] = jsonnn["price"].ToString();
                }
                else if (jsonnn["type"].ToString() == "OS")
                {
                    OSName[i] = jsonnn["name"].ToString();
                    OSPrice[i] = jsonnn["price"].ToString();
                }
                else if (jsonnn["type"].ToString() == "RAM")
                {
                    RAMName[i] = jsonnn["name"].ToString();
                    RAMPrice[i] = jsonnn["price"].ToString();
                }
                else if (jsonnn["type"].ToString() == "Soundcard")
                {
                    SoundcardName[i] = jsonnn["name"].ToString();
                    SoundcardPrice[i] = jsonnn["price"].ToString();
                }
            }
        }

        private Computers find(List<Computers> computer_list, string id)
        {
            return computer_list.Where(p => p.Id == id).FirstOrDefault();
        }



    }
}
