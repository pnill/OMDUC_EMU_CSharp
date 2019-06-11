using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMDUC_EMU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[-] OMDUC Dashboard Server Emulator...");
            Networking net = new OMDUC_EMU.Networking();
            net.StartListening();

        }
    }
}
