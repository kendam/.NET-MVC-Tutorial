using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NETAPP.Model;

namespace NETAPP.Pages.Book
{
    public class IndexModel : PageModel
    {
        private readonly NETAPPContext _context;

        public IndexModel(NETAPPContext context)
        {
            _context = context;
        }

        public IList<NETAPP.Model.Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
