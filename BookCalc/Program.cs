namespace BookCalcul
{
    public class Book
    {
        public string Author { get; set; }
        public string BookName { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public int PageNumber { get; set; }
        public string Status { get; private set; }

        public Book(string author, string bookName)
        {
            Author = author;
            BookName = bookName;
            // Set default values for other properties
            Genre = "Unknown";
            ISBN = "N/A";
            PageNumber = 0;
            Status = "Available";
        }

        public Book(string author, string bookName, string genre, string isbn, int pageNumber, string status)
        {
            Author = author;
            BookName = bookName;
            Genre = genre;
            ISBN = isbn;
            PageNumber = pageNumber;
            Status = status;
        }

        public void ChangeStatus(string newStatus)
        {
            Status = newStatus;
        }

        public void Print(string separator = "")
        {
            Console.WriteLine("Information about the work:");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Title of the work: {BookName}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Page Number: {PageNumber}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine(new string(separator.ToCharArray()[0], 10)); // define separator and how many times it should be counting
        }
    }
    class Program
    {
        static void Main()
        {
            // Create a Book using the second constructor
            Book book1 = new Book("Mika Matveinen", "Once upon a time there was a coder", "Fiction", "1234567", 200, "On loan");

            // Create a Book using the first constructor
            Book book2 = new Book("Mikaine Mason", "Coding in C#");

            // Change the status of the first book
            book1.ChangeStatus("Available");

            // Print book information with a custom separator
            book1.Print("*");
            book2.Print("*");
        }
    }
}

