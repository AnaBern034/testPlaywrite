using Microsoft.EntityFrameworkCore;

public class Banco : DbContext
{
public DbSet<PersonModel> Friends {get; set; }
public Banco(DbContextOptions<Banco> options) : base(options){}
}