using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public abstract class Transport
    {
        public string Name { get; set; }
        public Transport(string name)
        {
            Name = name;

        }
    }
}
