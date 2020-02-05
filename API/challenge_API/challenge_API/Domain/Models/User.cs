using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_API.Domain.Models
{
    public class User
    {
        public int Id { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }

        public int Participation { get; set; }
    }
}
