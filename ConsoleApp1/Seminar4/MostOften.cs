using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar4
{
    public class MostOften
    {
        public void Task()
        {
            List<User> users = new List<User>();
            users.Add(new User() { FirstName = "Vika", LastName = "Nova", Age = 18 });
            users.Add(new User() { FirstName = "Vika", LastName = "Niva", Age = 16 });
            users.Add(new User() { FirstName = "Vita", LastName = "Nova", Age = 19 });
            users.Add(new User() { FirstName = "Vinna", LastName = "Nonna", Age = 18 });

            var firstName = users.GroupBy(u => u.FirstName).OrderByDescending(g => g.Count()).First().Key;
            var age = users.GroupBy(u => u.Age).OrderBy(g => g.Count()).First().Key;
            var lastName = users.GroupBy(u => u.LastName).OrderBy(g => g.Count()).Last().Key;
            Console.WriteLine(firstName);
            Console.WriteLine(age);
            Console.WriteLine(lastName);


        }
    }
}
