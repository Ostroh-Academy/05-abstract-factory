using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssistant.Interfaces;

namespace VirtualAssistant.Classes
{
    public abstract  class AssistantFactory 
    {
        public abstract IVirtualAssistant CreateAssistant();
    }
}
