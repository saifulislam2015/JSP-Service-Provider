using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Listener.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Listener.Controllers
{
    public class WorkOutController : Controller
    {
        string Baseurl = "https://localhost:44335/api/WorkOut";

        public  async Task<ActionResult> Index()
        {
       
            List<WorkOut> WorkOuts = new List<WorkOut>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage msg = await client.GetAsync("WorkOut");
                if (msg.IsSuccessStatusCode)
                {
                    var data = msg.Content.ReadAsStringAsync().Result;
                    WorkOuts = JsonConvert.DeserializeObject<List<WorkOut>>(data);
                }

            }


            return View(WorkOuts);
        }

        public async Task<ActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(WorkOut workout)
        {
            try
            {
                HttpResponseMessage response = null;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                response = client.PostAsJsonAsync("WorkOut", workout).Result;

                if (response.IsSuccessStatusCode == true)
                    return RedirectToAction("Index");
                else
                    return View(workout);
            }
            catch
            {
                return View(workout);
            }
        }
    }
}