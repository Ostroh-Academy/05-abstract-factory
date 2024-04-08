using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssistant.Interfaces;

namespace VirtualAssistant.Classes
{
    public class SpanishAssistantFactory : AssistantFactory
    {
        public override IVirtualAssistant CreateAssistant()
        {
            return new SpanishVirtualAssistant();
        }
    }
}
