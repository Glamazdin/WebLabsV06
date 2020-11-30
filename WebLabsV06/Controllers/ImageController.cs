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
        UserManager<ApplicationUser> _userManager;        

        public ImageController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
           
        }

        public async Task<FileResult> GetAvatar([FromServices]IWebHostEnvironment env)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user.AvatarImage != null)
                return File(user.AvatarImage, "image/...");
            else
            {
                var avatarPath = "/Images/anonymous.png";
               
                return File(env.WebRootFileProvider
                    .GetFileInfo(avatarPath)
                    .CreateReadStream(), "image/...");
            }
        }

    }
}