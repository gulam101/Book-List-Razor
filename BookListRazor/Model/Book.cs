using System.ComponentModel.DataAnnotations;

namespace BookListRazor.Model
{
    public class Book
    {
        //Creates the KEY information using a class in the Model
        [Key]
        public int Id { get; set; }

        //Requires means that Name cannot be empty!
        [Required]
        public string Name { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}
