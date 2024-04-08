using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssistant.Interfaces;

namespace VirtualAssistant.Classes
{
    public class FrenchVirtualAssistant : IVirtualAssistant
    {
        public string sayHi()
        {
            return "Bonjour! Comment puis-je vous aider?";
        }

        public string sayBye()
        {
            return "Au revoir! Bonne journée!";
        }
    }
}
