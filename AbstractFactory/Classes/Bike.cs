using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public abstract  class Bike : Transport
    {
        public Bike(string name) : base(name) { }
    }
}
