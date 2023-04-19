using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectSite.Models;
using ProjectSite.Models.JsonModel;
using ProjectSite.Models.JsonModel2;
using ProjectSite.Models.JsonViewModel;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection;

namespace ProjectSite.Controllers
{
    public class HomeController : Controller
    {
        ArticleViewModel vm=new ArticleViewModel();

        //sadece okunabilir
        private readonly ILogger<HomeController> _logger;

        //bura sabit olan url kısmımız
        string baseurl = "https://api.tmgrup.com.tr/v1/";

        //constructor
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //api'ye request(istek) atabilmek için bir client(browser) nesnesi oluşturduk
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                //burada client ile asenkron bir biçimde base urlle ilgili endpointi ekleyerek request atıp response aldık
                HttpResponseMessage response = await client.GetAsync("link/352");
                    ArticleViewModel articleViewModel = new ArticleViewModel();

                //200 okey
                if (response.IsSuccessStatusCode)
                {
                    //burada da gelen response içerisindeki content içeriğini yani json verilerini string değişkene atıyoruz.
                    string results = await response.Content.ReadAsStringAsync();
                    //data başarılı bir şekilde alınıyor bu şekilde json bizim c# ta oluşturduğumuz class'a deserialize ediliyor bu class sayesinde gelen veriyi istediğimiz gibi kullanabiliriz.
                    var jsonRoot = JsonConvert.DeserializeObject<NewsArticleRoot>(results);
                    


                    articleViewModel.NewsArticleViewModel = jsonRoot;

                    articleViewModel.CatergoryNames = jsonRoot.data.articles.Response.GroupBy(x => x.CategoryName).Select(x => x.Key).ToList(); 
                }
        
                 else
                {
                    Console.WriteLine("Web API çagirma hatasi");
                }

               var response2 = await client.GetAsync("link/424");
                if (response2.IsSuccessStatusCode)
                {
                    //burada da gelen response içerisindeki content içeriğini yani json verilerini string değişkene atıyoruz.
                    string results2 = await response2.Content.ReadAsStringAsync();
                    //data başarılı bir şekilde alınıyor bu şekilde json bizim c# ta oluşturduğumuz class'a deserialize ediliyor bu class sayesinde gelen veriyi istediğimiz gibi kullanabiliriz.
                    var jsonRoot2 = JsonConvert.DeserializeObject<NewVideosRoot>(results2);
                    articleViewModel.NewsVideosViewModel = jsonRoot2;

                }
                else
                {
                    Console.WriteLine("Web API çagirma hatasi");
                }
                return View(articleViewModel);
            }



       


      

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}