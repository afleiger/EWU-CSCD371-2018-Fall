using System;
using System.Threading;

namespace src
{
    public class InstanceCounter : IDisposable
    {
        private static int _instanceCount = 0;
        public static int InstanceCount{ get; internal set; }

        public Barrier Barrier { get; set; }

        public InstanceCounter()
        {
            Barrier = new Barrier(1);
            InstanceCount++;
        }

        ~InstanceCounter()
        {
            Dispose();
        }

        public void Dispose()
        {
            Barrier.Dispose();
            InstanceCount--;
        }
    }
}
