using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc;
using UnderstandingControllersViews.Models;
using UnderstandingControllersViews.Services;

namespace UnderstandingControllersViews.Components
{
    public class Cart : ViewComponent
    {
        /*public string Invoke()
        {
            return "This is from View Component";
        }*/

        /*public IViewComponentResult Invoke()
        {
            return Content("This is from <h2>View Component</h2>");
        }*/

        /*public IViewComponentResult Invoke()
        {
            return new HtmlContentViewComponentResult(new HtmlString("This is from <h2>View Component</h2>"));
        }*/

        private Coupon coupon;
        public Cart(Coupon coupon)
        {
            this.coupon = coupon;
        }

        public IViewComponentResult Invoke()
        {
            Product[] products = new Product[] {
                new Product() { Name = "Women Shoes", Price = 99 },
                new Product() { Name = "Mens Shirts", Price = 59 },
                new Product() { Name = "Children Belts", Price = 19 },
                new Product() { Name = "Girls Socks", Price = 9 }
            };

            ViewBag.Coupon = coupon.GetCoupon();

            return View(products);
        }

        /*public IViewComponentResult Invoke(bool showCart)
        {
            Product[] products;
            if (showCart)
            {
                products = new Product[] {
                    new Product() { Name = "Women Shoes", Price = 99 },
                    new Product() { Name = "Mens Shirts", Price = 59 },
                    new Product() { Name = "Children Belts", Price = 19 },
                    new Product() { Name = "Girls Socks", Price = 9 }
                };
            }
            else
            {
                products = new Product[] { };
            }

            return View(products);
        }*/
    }
}
