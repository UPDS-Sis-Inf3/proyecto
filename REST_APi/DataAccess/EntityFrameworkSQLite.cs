namespace REST_APi.DataAccess
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using REST_APi.Model;


    public class EntityFrameworkSQLite : DbContext
    {
        public DbSet<Users> User { get; set; }
        public DbSet<tareas> Tarea { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Tareas.db");
        }

    }
}
