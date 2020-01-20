using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebLabsV06.DAL.Entities;

namespace WebLabsV06.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult GetAvatar(IWebHostEnvironment env, UserManager<ApplicationUser> userManager)
        {
            return View();
        }
    }
}