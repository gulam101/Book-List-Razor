using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace BookListRazor
{
    public class EditModel : PageModel
    {

        private ApplicationDb _db;

        public EditModel(ApplicationDb db)
        {
            _db = db;
        }

        //Allows me to call the same object without creating it again
        [BindProperty]
        public Book book { get; set; }

        public async Task OnGet(int id)
        {
            book = await _db.Book.FindAsync(id);
        }
    }
}