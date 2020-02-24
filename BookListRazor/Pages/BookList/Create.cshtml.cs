using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookListRazor.Model;

namespace BookListRazor
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDb _db;

        public CreateModel(ApplicationDb db)
        {
            _db = db;
        }

        [BindProperty]
        public Book book { get; set; }


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _db.Book.AddAsync(book);
                //Once this command is executed this will push data into the database
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            } 
            else
            {
                return Page();
            }
        }

    }
}