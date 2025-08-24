using Microsoft.EntityFrameworkCore;
using TaskFlow.API.Models;
using TaskFlow.API.Controllers;
using TaskFlow.API.Data;

namespace TaskFlow.API.Data
{
    public class TaskFlowDbContext : DbContext
    {
        public TaskFlowDbContext(DbContextOptions<TaskFlowDbContext> options)
            : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
