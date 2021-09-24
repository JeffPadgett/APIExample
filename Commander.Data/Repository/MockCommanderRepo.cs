using Commander.Data.Interfaces;
using Commander.Domain;
using System;
using System.Collections.Generic;

namespace Commander.Data.Repository
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public Command CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
            new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" },
            new Command { Id = 1, HowTo = "Be cool", Line = "Comb your hair", Platform = "Don't know" },
            new Command { Id = 2, HowTo = "Be a good dad", Line = "Spend time", Platform = "Take to disney" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Be a good dad", Line = "Spend time", Platform = "Take to disney" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        void ICommanderRepo.CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
