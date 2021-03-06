using Microsoft.EntityFrameworkCore;
using simple_ef_core.Models;

namespace simple_ef_core.Data
{
    public class TodoItemContext : DbContext
    {
        public DbSet<TodoEntity> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=todoitem.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            // todo
        }
    }
}