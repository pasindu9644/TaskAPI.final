using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=LP-HQ-6CRG8Y2;Database=myTodoDb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
                {
                    new Author {Id=1, FullName="Pasindu Dilhan", AddressNo="96",Street="Ihaladeniya",City="Weligama",JobRole="Developer"},
                    new Author {Id=2, FullName="shashikala Udeshani", AddressNo="96",Street="Leelasewana",City="Weligama",JobRole="Telecom Eng"},
                    new Author {Id=3, FullName="Minura Pabasara", AddressNo="96",Street="Dampewaththa",City="Weligama",JobRole="Business Analyst"},
                    new Author {Id=4, FullName="Manasa ayasankha", AddressNo="96",Street="Badullehome",City="Weligama",JobRole="Telecom Eng"},
                    new Author {Id=5, FullName="Naween Ransara", AddressNo="96",Street="Koswatta",City="Weligama",JobRole="QA Eng"},

                });
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                Id = 1,
                Title = "Get books for school from DB",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 1
            },
            new Todo

            {
                Id = 2,
                Title = "Get Bags for school",
                Description = "Get some bags for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Inprogress,
                AuthorId=2
            },
            new Todo

            {
                Id = 3,
                Title = "Get Shoes for school",
                Description = "Get some shoes for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId=1
            }
            
            );
        }
    }
}
