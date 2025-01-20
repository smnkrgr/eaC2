using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public abstract class Listener
    {
        public abstract string Name { get; }

        public abstract Task Start();
        public abstract void Stop();
    }
}