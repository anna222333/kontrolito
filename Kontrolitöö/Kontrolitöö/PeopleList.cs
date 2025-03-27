using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolitöö
{
    class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Anna",
                Age = 33,
               
            },
            new People()
            {
                Id = 2,
                Name = "Inga",
                Age = 34,
               
            },
            new People()
            {
                Id = 3,
                Name = "Heli",
                Age = 1,
                
            },
            new People()
            {
                Id = 4,
                Name = "John",
                Age = 20,
               
            },
            new People()
            {
                Id = 5,
                Name = "Andrei",
                Age = 17,
                
            },
            new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 19,
              
            },
        };
    }
}
