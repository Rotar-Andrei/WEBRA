﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEBRA.Data;
using WEBRA.Models;

namespace WEBRA.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly WEBRA.Data.WEBRAContext _context;

        public IndexModel(WEBRA.Data.WEBRAContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}
