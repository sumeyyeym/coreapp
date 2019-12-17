using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Category
    {
        public int    CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
    public class HomeController : Controller
    {
        //Her view'ın bir action'ı olmak zorunda değil.
        
        #region View Result
        public ViewResult Index() //Mantığı: Geriye ne dönemek istiyorsun? Burada viewresult diyerek sadece view döndürürüz
        {
            return View();
            //Bir tane view, yani sayfa/ html web sayfası/ ekran dönecek. Views klasöründen Home'a gidip Index.cshtml'yi açacak. Önceki sürümlerde controllers'a bir kontrol eklendiğinde view'e aynı isimde bir klasör atardı. Bu sürümde biz kendimiz ekliyoruz.

            //View içerisindeki Homee klasörüne view eklemek için ya klasör üzerinden add yaparak ekliycez ya da yukarıdaki kod satırındaki Index üzerinden sağ tıkla ekliycez. Her ne şekilde olursa olsun viewle kod satırındaki index kısmının ismi aynı olmalı.

            //Creat as a partial view -- tek bir tasarım yapıp birden fazla yerde kullanmak için
        }

        #endregion

        #region Json Result
        public JsonResult Json() //Json objesi döner. Javascript objesi döner.
        {
            var json_data = new List<Category>() {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Beverages",
                    Description = "Soft drinks, coffees, teas, beers, and ales"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Condiments",
                    Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Confections",
                    Description = "Desserts, candies, and sweet breads"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Dairy Products",
                    Description = "Cheeses"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Grains/Cereals",
                    Description = "Breads, crackers, pasta, and cereal"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Meat/Poultry",
                    Description = "Prepared meats"
                },
                new Category
                {
                    CategoryID = 7,
                    CategoryName = "Produce",
                    Description = "Dried fruit and bean curd"
                },
                new Category
                {
                    CategoryID = 8,
                    CategoryName = "Seafood",
                    Description = "Seaweed and fish"
                }
            };

            return Json(json_data);
        }
        #endregion

        #region Redirect To Action Result
        public RedirectToActionResult About() //Action içerisinde işlem sonında kullanıcıyı farklı bir action'a yönlendirir. Bu örnekte contact sayfasına girmeye çalışsak da contact'e atacaktır. 
        {
            return RedirectToAction("Contact");
        }
        #endregion

        #region Redirect Result
        public RedirectResult Contact() //Kullanıcıyı harici bir siteye yönlendirirken kullanılır. Burada ise contact sayfası youtube'a yönlendirir.
        {
            return Redirect("https://www.youtube.com/?gl=TR&tab=r11");
        }
        #endregion

        #region Not Found Result
        public NotFoundResult Bulunamadi() //404 hatası verir.
        {
            return NotFound();
        }
        #endregion

        #region Unauthorized Result
        public UnauthorizedResult Login() //401 hatası döner. Sayfaya erişim için kimlik doğrulaması yapılması gerektiğini bildirir.
        {
            return Unauthorized();
        } 
        #endregion


        public ViewResult List()
        {
            return View();
        }

        public ViewResult Create()
        {
            return View();
        }
    }
}