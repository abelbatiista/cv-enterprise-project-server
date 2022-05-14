using Microsoft.EntityFrameworkCore;
using Server.Model.Entities;
using Server.Model.Entities.UserDetails;
using FileEntity = Server.Model.Entities.File.File;

namespace Server.Model.Context
{
    public class ApplicationDbContext : BaseDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<ExamplePerson> ExamplePeople { get; set; }
        public DbSet<Biography> Biographies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<GeneralInformation> GeneralInformations { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<WorkPlataform> WorkPlataforms { get; set; }
        public DbSet<FileEntity> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}