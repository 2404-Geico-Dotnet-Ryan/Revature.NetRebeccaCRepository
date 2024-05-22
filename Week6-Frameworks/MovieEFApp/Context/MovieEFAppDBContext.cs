using Microsoft.EntityFrameworkCore;

class MovieEFAppDBContext : DbContext
{
    public DbSet <User> Users { get; set; } 
    //public DbSet <Movie> Movies { get; set; } // we are not using this now so does not need to be active 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Read in our connection String from our txt file 
        string connectionString = File.ReadAllText(@"C:\Users\U713PY\RevatureTraining.NET\Revature.NetRebeccaCRepository\MovieApp-db.txt");
        optionsBuilder.UseSqlServer(connectionString);
    }
}