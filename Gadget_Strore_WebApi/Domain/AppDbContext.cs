using System;
using Gadget_Strore_WebApi.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Gadget_Strore_WebApi.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2d4a2c72-38c7-4611-9b6d-35c0881aa5ae",
                Name="admin",
                NormalizedName = "ADMIN",
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id= "1249185b-069b-446f-8282-873927cb29df",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@mail.com",
                NormalizedEmail = "MY@MAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp=string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "2d4a2c72-38c7-4611-9b6d-35c0881aa5ae",
                UserId = "1249185b-069b-446f-8282-873927cb29df"
                
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("cfbbc030-3563-4ac7-b29d-2dfd16377992"),
                CodeWord = "PageIndex",
                Title="Головна"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("8ef6b58f-6b99-44cb-bac1-ce64518fa51e"),
                CodeWord = "PageServices",
                Title = "Наші послуги"

            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("9a102932-2580-483b-b75a-df6bc1ce29ac"),
                CodeWord = "PageContacts",
                Title = "Контакти"

            });
        }
    }
}
