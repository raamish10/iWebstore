using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TMA3A.Pages.part4.Helpers;
using TMA3A.Pages.part4.Models;
using System.Globalization;
using Newtonsoft.Json;
using System.Collections;
using Newtonsoft.Json.Linq;

namespace TMA3A.Pages.part4
{
    public class CartModel : PageModel
    {
        public List<Item> cart;
        public List<Components> comp_list;
        public List<Computers> computer_data;
        public List<Components> custom_component = new List<Components>();

        public void OnGet()
        {
        }

        public void OnGetBuyNow(string id, string name)
        {

            comp_list = SessionHelper.GetObjectFromJson<List<Components>>(HttpContext.Session, "part4component_list");
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "part4cart");

            if (cart == null)
            {
                cart = new List<Item>();
                cart.Add(new Item
                {
                    Component = find(comp_list, id),
                    Quantity = 1,
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "part4cart", cart);
            }
            else
            {
                int index = QuantityUpdate(cart, name);
                if (index == -1)
                {
                    cart.Add(new Item
                    {
                        Component = find(comp_list, id),
                        Quantity = 1,
                    });
                }
                else
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "part4cart", cart);

            }

        }

        public void OnGetCustom()
        {
            computer_data = SessionHelper.GetObjectFromJson<List<Computers>>(HttpContext.Session, "part4computer_data");
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "part4cart");

            String json_string = JsonConvert.SerializeObject(computer_data);
            var images_json = JsonConvert.DeserializeObject(json_string);

            string[] arr = ((IEnumerable)images_json).Cast<object>()
                            .Select(x => x.ToString())
                            .ToArray();

            JObject jsonnn = JObject.Parse(arr[0]);

            String str = jsonnn["Name"].ToString() + " Customized with CPU: " + jsonnn["CPU"].ToString() + ", Display: " + jsonnn["Display"].ToString() + ", Fan: " + jsonnn["Fan"].ToString() + ", GPU: " + jsonnn["GPU"].ToString() + ", Hard Drive: " + jsonnn["Hard_Drive"].ToString() + ", Motherboard: " + jsonnn["Motherboard"].ToString() + ", RAM: " + jsonnn["RAM"].ToString() + ", OS: " + jsonnn["OS"].ToString() + ", Soundcard: " + jsonnn["Soundcard"].ToString();
            String price = jsonnn["Price"].ToString();
            String image = jsonnn["Image"].ToString();

            custom_component.Add(new Components { Id = "999", Name = str, Image = image, Price = price });


            if (cart == null)
            {
                cart = new List<Item>();
                cart.Add(new Item
                {
                    Component = custom_component.LastOrDefault(),
                    Quantity = 1,
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "part4cart", cart);
            }
            else
            {
                int index = QuantityUpdate(cart, str);
                if (index == -1)
                {
                    cart.Add(new Item
                    {
                        Component = custom_component.LastOrDefault(),
                        Quantity = 1,
                    });
                }
                else
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "part4cart", cart);

            }
        }
        public void OnGetRemove(string id)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "part4cart");
            int index = Exists(cart, id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "part4cart", cart);
        }

        public void OnGetLoad(string id)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "part4cart");
            SessionHelper.SetObjectAsJson(HttpContext.Session, "part4cart", cart);
        }


        private int Exists(List<Item> cart, string id)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Component.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        private int QuantityUpdate(List<Item> cart, string name)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Component.Name == name)
                {
                    return i;
                }
            }
            return -1;
        }



        public Components find(List<Components> component, string id)
        {
            return component.Where(p => p.Id == id).FirstOrDefault();
        }



    }
}
