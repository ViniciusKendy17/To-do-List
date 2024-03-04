using Microsoft.EntityFrameworkCore;



namespace ToDoList.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options) 
        {

        }
        public DbSet<TaskModel> Tasks { get; set; }
    }

}
