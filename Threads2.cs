using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Kapec
{
    class Threads2
    {
        private Thread4ServerListener _T4SL;
               

        public Threads2(Thread4ServerListener T4SL)
        {
            _T4SL = T4SL;
        }

        public void RunServerThreads()
        {
            Thread ThisThread1 = new Thread(ServerThreadsCreator);
            ThisThread1.IsBackground = true;
            ThisThread1.Start();
        }

        public void ServerThreadsCreator()
        {
            while (true)
            {
                _T4SL();
            }

        }
    }
}
