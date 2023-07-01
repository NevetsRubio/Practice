namespace WindowsFormsApp.Models
{
    public class Book
    {
        public Book(string author, string title)
        {
            Author = author;
            Title = title;
        }
        public string Author { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}
