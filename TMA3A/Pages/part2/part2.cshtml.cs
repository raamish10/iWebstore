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

namespace TMA3A.Pages
{
    public class Part2Model : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string[] ImageArr;    
        public string[] CaptionArr;


        public Part2Model(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ExtractJSON();
        }


        public void ExtractJSON()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"./Pages/part2/images.json");
            var images_json = JsonConvert.DeserializeObject(json);

            string[] arr = ((IEnumerable)images_json).Cast<object>()
                            .Select(x => x.ToString())
                            .ToArray();

            ImageArr = new string[20];
            CaptionArr = new string[20];

            for (int i = 0; i < 20; i++)
            {
                JObject jsonnn = JObject.Parse(arr[i]);

                ImageArr[i] = jsonnn["link"].ToString();
                CaptionArr[i] = jsonnn["caption"].ToString();
            }

            //ViewData["ImgLink"] = ImageArr[15];
            //ViewData["Caption"] = CaptionArr[15];
        }

    }
}
