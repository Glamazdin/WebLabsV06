using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLabsV06.Extensions;
using WebLabsV06.Models;

namespace WebLabsV06.Components
{
    public class CartViewComponent : ViewComponent
    {
        Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            //var cart = HttpContext.Session.Get<Cart>("cart");
            return View(_cart);
        }
    }
}
