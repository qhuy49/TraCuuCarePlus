using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Search_Invoice.Controllers
{
    public class TestHARAController : Controller
    {
        //// GET: TestHARA
        //public async Task<ActionResult> Index()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://accounts.haravan.com/connect/authorize?response_mode=form_post&response_type=codeid_token & scope = openid profile email org userinfo & client_id = e5a87ceae07603e33fd5dc4e6b0118d5 & redirect_uri = http://localhost:57714/TestHARA/Index");
        //        //var content = new FormUrlEncodedContent(new[]
        //        //{
        //        //new KeyValuePair<string, string>("", "login")
        //        //});
        //        var result = await client.GetAsync("http://accounts.haravan.com/connect/authorize?response_mode=form_post&response_type=codeid_token & scope = openid profile email org userinfo & client_id = e5a87ceae07603e33fd5dc4e6b0118d5 & redirect_uri = http://localhost:57714/TestHARA/Index");
        //        string resultContent = await result.Content.ReadAsStringAsync();
        //        Console.WriteLine(resultContent);
        //    }

        //    return View();

        //}
    }
}