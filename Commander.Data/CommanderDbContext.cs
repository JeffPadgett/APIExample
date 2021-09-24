using Commander.Domain;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderDbContext : DbContext
    {
        public CommanderDbContext(DbContextOptions<CommanderDbContext> options) : base(options) { }

        public DbSet<Command> Commands { get; set; }
    }
}
