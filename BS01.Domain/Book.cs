namespace BS01.Domain
{
    public class Book
    {
        public int Id { get; private set; }
        public string? Title { get; private set; }
        public double Price { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreateDatetime { get; private set; }


        public Book()
        {

        }

        public Book(string tilte, double price)
        {
            Title = tilte;
            Price = price;
            IsDeleted = false;
            CreateDatetime = DateTime.Now;
        }

    }
}