
//Challenge : Make Platform a primary object, and have command be a child object of that object. 
using System.ComponentModel.DataAnnotations;

namespace Commander.Domain
{
    public class Command
    {
        public int Id { get; set; }

        [Required]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }

    }
}
