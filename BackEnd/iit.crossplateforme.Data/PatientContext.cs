using iit.crossplateforme.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace iit.crossplateforme.Data
{
    public class PatientContext : DbContext
	{

		public DbSet<Patient> Patients { get; set; }
		public IConfiguration Configuration { get; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

			=> optionsBuilder.UseSqlite("data source=C:\\Users\\Nounou\\Desktop\\Doctor-catalog\\db\\AppDB.db");




		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			{
				modelBuilder.Entity<Patient>().HasData(
					new Patient
				{
					Id = 1,
					Name = "Amine",
					FamilyName = "chaker",
					HealthCare = "Flu",
					TelNumber = 12345


				}, new Patient
				{
					Id = 2,
					Name = "Nawel",
					FamilyName = "felah",
					HealthCare = "Allergies",
					TelNumber = 22335
				},
					new Patient
					{
						Id = 3,
						Name = "ahlem",
						FamilyName = "zouari",
						HealthCare = "Headaches",
						TelNumber = 22365


					});
			}
		}
	}
}