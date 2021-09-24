using Commander.Data.Interfaces;
using Commander.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.Data.Repository
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderDbContext _dbContext;
        public SqlCommanderRepo(CommanderDbContext commandDb)
        {
            _dbContext = commandDb;
        }

        public void CreateCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _dbContext.Commands.Add(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _dbContext.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _dbContext.Commands.FirstOrDefault(i => i.Id == id);
        }

        public bool SaveChanges()
        {
            return (_dbContext.SaveChanges() >= 0);
        }
    }
}
