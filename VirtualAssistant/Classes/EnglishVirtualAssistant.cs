
using VirtualAssistant.Interfaces;

namespace VirtualAssistant.Classes
{
    public class EnglishVirtualAssistant : IVirtualAssistant
    {
        public string sayBye()
        {
            return "Goodbye! Have a nice day!";
        }

        public string sayHi()
        {
            return "Hello ! How do u feel?";
        }
    }
}
