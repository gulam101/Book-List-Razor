using Microsoft.EntityFrameworkCore;


namespace BookListRazor.Model
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options)
        {

        }

        //Allows us to update the book information
        public DbSet<Book> Book { get; set; }

    }
}
