namespace TheatreAPI.Controllers
{
    public class MockDB
    {
        public static List<Movie> Movies { get; set; } = new List<Movie>()
        {
            new Movie { Id = 1, Title = "Iron Giant", Description = "Mock Descript"}
        };
        public static List<Showtime> Showtime { get; set; } = new List<Showtime>()
        {
            new Showtime { Id = 1, StartTime = DateTime.Now, MovieId = 1 }
        };
        public static List<Admission> Admissions { get; } = new List<Admission>
        {
            new Admission { Id = 1, MovieId = 1, ShowtimeId = 1 }
        };

        public static List<Receipt> Receipts { get; } = new List<Receipt>
        {
            new Receipt { Id = 1, AdmissionId = 1, PurchaseDate = DateTime.Now, TotalAmount = 25.00 }
        };
    }
}
