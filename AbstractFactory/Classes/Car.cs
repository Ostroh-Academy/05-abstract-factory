using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public abstract class Car : Transport
    {
        protected Car(string name) : base(name) { }
    }

}
