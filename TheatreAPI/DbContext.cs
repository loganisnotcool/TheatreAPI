using Microsoft.EntityFrameworkCore;


namespace TheatreAPI
{
    public class ApplicationDbContext :  DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Showtime> Showtime { get; set; }
        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
    }   
}  
