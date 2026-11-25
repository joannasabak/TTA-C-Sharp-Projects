using Microsoft.EntityFrameworkCore;

public class CarInsuranceContext(DbContextOptions<CarInsuranceContext> options) : DbContext(options)
{
    public DbSet<CarInsurance.Models.Insuree> Insuree { get; set; } = default!;
}
