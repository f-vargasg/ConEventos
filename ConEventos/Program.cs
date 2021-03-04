using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += Bl_ProcessCompleted;
            bl.StartProcess();
            Console.ReadKey();
        }

        private static void Bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!!!");
        }
    }
}
