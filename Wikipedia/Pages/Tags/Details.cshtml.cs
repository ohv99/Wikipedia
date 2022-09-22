using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wikipedia.Data;
using Wikipedia.Models;

namespace Wikipedia.Pages.Tags
{
    public class DetailsModel : PageModel
    {
        private readonly Wikipedia.Data.ApplicationDbContext _context;

        public DetailsModel(Wikipedia.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Tag Tag { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tags == null)
            {
                return NotFound();
            }

            var tag = await _context.Tags.FirstOrDefaultAsync(m => m.Id == id);
            if (tag == null)
            {
                return NotFound();
            }
            else 
            {
                Tag = tag;
            }
            return Page();
        }
    }
}
