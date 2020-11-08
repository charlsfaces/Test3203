using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test3203.ModelLayer
{
    public class Gateway: BaseDevice
    {
        /// <summary>
        /// IP address number
        /// </summary>
        protected string IP { get; set; }

        /// <summary>
        /// Port number
        /// </summary>
        protected int Port { get; set; }
    }
}
