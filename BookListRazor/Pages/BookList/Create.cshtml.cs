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
        public void OnGet()
        {

        }
    }
}