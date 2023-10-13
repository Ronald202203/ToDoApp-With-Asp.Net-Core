using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options){ }

        public DbSet<ToDo> ToDos { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Status> Statuses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "work", Name = "Travail" },
                new Category { CategoryId = "home", Name = "Maison" },
                new Category { CategoryId = "ex", Name = "Exercice" },
                new Category { CategoryId = "shop", Name = "Achat" },
                new Category { CategoryId = "call", Name = "Contact" }
                );

            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId= "open", Name="Ouverte"},
                new Status { StatusId = "closed", Name = "Complète" }
                );
        }
    }
}
