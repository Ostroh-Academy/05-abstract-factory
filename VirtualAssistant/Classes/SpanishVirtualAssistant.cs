using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssistant.Interfaces;

namespace VirtualAssistant.Classes
{
    public class SpanishVirtualAssistant :IVirtualAssistant
    {
        public string sayHi()
        {
            return "¡Hola! ¿Cómo puedo ayudarte?";
        }
        public string sayBye()
        {
            return "¡Adiós! ¡Que tengas un buen día!";
        }
    }
}
