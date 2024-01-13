using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEBRA.Data;
using WEBRA.Models;

namespace WEBRA.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly WEBRA.Data.WEBRAContext _context;

        public IndexModel(WEBRA.Data.WEBRAContext context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
