using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jokes.Models
{
    public class Joke
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string JokeQuestion { get; set; }

        public string JokeAnswer { get; set; }
    }
}
