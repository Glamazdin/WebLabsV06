using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebLabsV06.DAL.Data;
using WebLabsV06.DAL.Entities;

namespace WebLabsV06
{
    public class IndexModel : PageModel
    {
        private readonly WebLabsV06.DAL.Data.ApplicationDbContext _context;

        public IndexModel(WebLabsV06.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; }

        public async Task OnGetAsync()
        {
            Dish = await _context.Dishes
                .Include(d => d.Group).ToListAsync();
        }
    }
}
