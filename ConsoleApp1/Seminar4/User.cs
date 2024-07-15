using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar4
{
    public class User: IEquatable<User>
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public bool Equals(User? other)
        {
            if (other == null) return false;
            return FirstName == other.FirstName && LastName == other.LastName && Age == other.Age;
            
        }
    }
}
