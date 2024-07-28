using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaFurnitureProject.DataAccess.Context
{
	public class FurnitureContext : IdentityDbContext<AppUser,AppRole,int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=HUSEYIN\\SQLEXPRESS; initial catalog=AcunMedyaFurnitureDb;integrated security=true;trustServerCertificate=true");
		}


		public DbSet<About> Abouts { get; set; }

		public DbSet<ContactInfo> ContactInfos { get; set; }

		public DbSet<Feature> Features { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<Services> Services { get; set; }

		public DbSet<SocialMedia> SocialMedias { get; set; }

		public DbSet<Subscriber> Subscribers { get; set; }

		public DbSet<Testimonial> Testimonials { get; set; }

		public DbSet<UserMessage> UserMessages { get; set; }
	}
}
