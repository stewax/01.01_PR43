using System.Data.Entity;
using TaskManager_Osennikov.Models;

namespace TaskManager_Osennikov.Context
{
    public class TasksContext : DbContext
    {
        public TasksContext() : base("name=TaskManagerContext"){}

        public DbSet<Tasks> Tasks { get; set; }
    }
}