using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEventos
{
    public delegate void Notify();
    class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started...");
            // some code here
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}
