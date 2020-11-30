using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebLabsV06.DAL.Data;
using WebLabsV06.DAL.Entities;
using WebLabsV06.Extensions;
using WebLabsV06.Models;

namespace WebLabsV06.Controllers
{
    public class CartController : Controller
    {
        readonly ApplicationDbContext _context;        
        Cart _cart;

        public CartController(ApplicationDbContext context, Cart cart)
        {
            _context = context;
            _cart = cart;
        }
        public IActionResult Index()
        {
            return View(_cart.Items.Values);
        }

        [Authorize]
        public IActionResult Add(int id, string returnUrl)
        {
            
            var dish = _context.Dishes.Find(id);
            if(dish!=null)
            {
                _cart.AddToCart(dish);                
            }
            return Redirect(returnUrl);
        }


    }
}