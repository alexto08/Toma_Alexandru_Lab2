using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Toma_Alexandru_Lab2.Data;
using Toma_Alexandru_Lab2.Models;

namespace Toma_Alexandru_Lab2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Toma_Alexandru_Lab2.Data.Toma_Alexandru_Lab2Context _context;

        public IndexModel(Toma_Alexandru_Lab2.Data.Toma_Alexandru_Lab2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}
