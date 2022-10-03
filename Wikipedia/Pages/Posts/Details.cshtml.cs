using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Wikipedia.Data;
using Wikipedia.Models;

namespace Wikipedia.Pages.Posts
{
    public class DetailsModel : PageModel
    {
        private readonly Wikipedia.Data.ApplicationDbContext _context;

        public DetailsModel(Wikipedia.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Post Post { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            else 
            {
                Post = post;
            }
            ViewData["Tag"] = new SelectList(_context.Tags, "Id", "Nombre"); 
            var postInfo = _context.Categorias.Where(x => x.Id == post.CategoriaId).FirstOrDefaultAsync();
            //ViewData["Categoria"] = postInfo.

            return Page();
        }
    }
}
