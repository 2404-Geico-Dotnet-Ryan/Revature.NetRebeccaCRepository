using Microsoft.EntityFrameworkCore;

class MovieEFAppDBContext : DbContext
{
   
    public DbSet <User> Users { get; set; } 
    public DbSet <Movie> Movies { get; set; }  
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Read in our connection String from our txt file 
        string connectionString = File.ReadAllText(@"C:\Users\U713PY\RevatureTraining.NET\Revature.NetRebeccaCRepository\MovieApp-db.txt");
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.Entity<Movie>().HasOne(m=>m.Renter);
       // this can be concatinated to add .WithMany().HasForeignKey();

    }
}