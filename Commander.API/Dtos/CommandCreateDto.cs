using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.API.Dtos
{
    public class CommandCreateDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
    }
}
