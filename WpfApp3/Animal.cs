using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Animal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Animal(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }
    }
}
