using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookListRazor.Model;

namespace BookListRazor
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDb _db;

        public IndexModel(ApplicationDb db)
        {
            _db = db;
        }
        public void OnGet()
        {

        }
    }
}