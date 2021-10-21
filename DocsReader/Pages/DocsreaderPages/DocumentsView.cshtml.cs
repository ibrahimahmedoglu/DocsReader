using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocsReader.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DocsReader.Pages.DocsreaderPages
{
    public class DocumentsViewModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DocumentsViewModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Documents> Documents { get; set; }

        public async Task OnGet()
        {
            Documents = await _db.Documents.ToListAsync();
        }
    }
}
