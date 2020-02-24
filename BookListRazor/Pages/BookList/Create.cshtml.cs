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

        public Book book { get; set; }


        public void OnGet()
        {

        }
    }
}