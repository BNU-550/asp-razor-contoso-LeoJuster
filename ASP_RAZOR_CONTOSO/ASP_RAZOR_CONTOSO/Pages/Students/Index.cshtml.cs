using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_RAZOR_CONTOSO.Data;
using ASP_RAZOR_CONTOSO.Models;

namespace ASP_RAZOR_CONTOSO.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly ASP_RAZOR_CONTOSO.Data.ApplicationDbContext _context;

        public IndexModel(ASP_RAZOR_CONTOSO.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
