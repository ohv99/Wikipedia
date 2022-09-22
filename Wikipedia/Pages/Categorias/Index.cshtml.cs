using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wikipedia.Data;
using Wikipedia.Models;

namespace Wikipedia.Pages.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly Wikipedia.Data.ApplicationDbContext _context;

        public IndexModel(Wikipedia.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Categoria> Categoria { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Categorias != null)
            {
                Categoria = await _context.Categorias.ToListAsync();
            }
        }
    }
}
