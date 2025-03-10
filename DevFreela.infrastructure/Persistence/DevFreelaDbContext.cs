using DevFreela.core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;


namespace DevFreela.infrastructure.Persistence
{


    public class DevFreelaDbContext : DbContext
    {


        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
        {

        }
        public DevFreelaDbContext()
        {
            Projects.AddRange(new List<Project>
            {
                new Project("Nome do projeto", "Descrição do projeto", 1, 2, 10000),
                new Project("Nome do projeto 2", "Descrição do projeto 2", 1, 2, 10000),
                new Project("Nome do projeto 3", "Descrição do projeto 3", 1, 2, 100000),
            });

            Users.AddRange(new List<User>
        {
            new User("teste", "teste@gmail.com" , new DateTime(2002,1,1), "teste123", "client"),
            new User("jose", "jose@gmail.com" , new DateTime(2003,1,1), "jose", "client"),
            new User("madruga", "madruga@gmail.com" , new DateTime(2004,1,1), "madruga", "client"),
        });

            Skills.AddRange(new List<Skill>
        {
            new Skill("Java"),
            new Skill("C#"),
            new Skill("Python"),
            new Skill("JavaScript"),
            new Skill("HTML"),
            new Skill("CSS"),

        });
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<ProjectComment> ProjectComments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //carregar todas configurações a partir do Assembly
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Project>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Project>()
            .HasOne(p => p.Freelancer)


            modelBuilder.Entity<ProjectComment>()
            .HasKey(p => p.Id);


            modelBuilder.Entity<Skill>()
            .HasKey(p => p.Id);


            modelBuilder.Entity<User>()
            .HasKey(p => p.Id);


            modelBuilder.Entity<UserSkill>()
            .HasKey(p => p.Id);


        }
    }

}