using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wikipedia.Data;
using Wikipedia.Models;

namespace Wikipedia.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly Wikipedia.Data.ApplicationDbContext _context;

        public IndexModel(Wikipedia.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Posts != null)
            {
                Post = await _context.Posts
                .Include(p => p.Categoria)
                .Include(p => p.Tag).ToListAsync();
            }
        }
    }
}
