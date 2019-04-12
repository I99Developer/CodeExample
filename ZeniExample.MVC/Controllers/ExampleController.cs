using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ZeniExample.Core.Models.HumanResources;

namespace ZeniExample.MVC.Controllers
{
    public class ExampleController : Controller
    {
        HttpClient m_ExampleClient;
        string m_Url;
        public ExampleController()
        {
            m_ExampleClient = new HttpClient();

            m_Url = ConfigurationManager.AppSettings["ApiUrl"].ToString();

            m_ExampleClient.BaseAddress = new Uri(m_Url);
        }
        
        public async Task<ActionResult> Example()
        {
            HttpResponseMessage response = await m_ExampleClient.GetAsync(m_Url);
            
            if (response.IsSuccessStatusCode)
            {
                var retVal = response.Content.ReadAsStringAsync().Result;
                var departments = JsonConvert.DeserializeObject<List<Department>>(retVal);

                return View(departments);
            }

            return View("Ooops! Something didn't work quite right");
        }
    }
}