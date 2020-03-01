using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityPortal.Models
{
    public class Teacher : UserId
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Sections> Sections { get; set; }

    }
}
