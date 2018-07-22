using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Kapec
{
    class Threads1
    {
        //Client
        private Thread4Listener _T4L;


        public Threads1(Thread4Listener T4L)
        {
            _T4L = T4L;
        }

        public void RunThreads()
        {
                Thread ThisThread = new Thread(ThreadsCreator);
                ThisThread.IsBackground = true;
                ThisThread.Start();
        }

        public void ThreadsCreator()
        {
            while (true)
            {
                    _T4L();
            }

        }

    }
}
