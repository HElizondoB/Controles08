using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Controles08.Data;
using Controles08.Models;

namespace Controles08.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Controles08.Data.Controles08Context _context;

        public IndexModel(Controles08.Data.Controles08Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
