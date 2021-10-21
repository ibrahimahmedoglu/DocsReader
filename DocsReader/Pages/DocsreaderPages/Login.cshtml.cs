using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocsReader.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DocsReader.Pages.DocsreaderPages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Admins admin { get; set; }

        public void OnGet(String Username)
        {
        }

        public async Task<IActionResult> OnPost()
        {
                if (admin.Password=="ibo" && admin.Username=="admin")
                {
                    return RedirectToPage("DocumentsView");
                }

                return RedirectToPage();
            
            
        }
    }
}

