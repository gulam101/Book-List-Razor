using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor
{
    public class EditModel : PageModel
    {

        private ApplicationDb _db;

        public EditModel(ApplicationDb db)
        {
            _db = db;
        }

        [BindProperty]
        public Book book { get; set; }

        public async Task OnGet(int id)
        {
            book = await _db.Book.FindAsync(id);
        }
    }
}